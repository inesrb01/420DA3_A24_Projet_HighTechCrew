using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShippingOrderService {
    private WsysApplication parentApp;
    private ShippingOrderDAO dao;
    private ShippingOrderView view;
    private AppDbContexte context;

    /// <summary>
    ///   hajar      
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>


    public ShippingOrderService(WsysApplication parentApp, AppDbContexte context) {
        this.parentApp = parentApp;
        this.context = context;
        this.dao = new ShippingOrderDAO(context);
        this.view = new ShippingOrderView(parentApp);
    }
    public ShippingOrder CreateOrder(ShippingOrder shippingOrder) {
        try { 

            return dao.Create(shippingOrder);


        } catch (Exception ex) {
            throw new Exception("echec de la creation de shippingOrder", ex);
        }
    }
    public List<ShippingOrder> Search(string keyword) {
        return dao.Search(keyword);
    }
    public ShippingOrder UpdateOrder(ShippingOrder order, List<ShippingOrderProductModification> modifications) {

        if (order.Status != ShippingOrderStatusEnum.Unassigned && order.Status != ShippingOrderStatusEnum.New)
            throw new Exception("Seuls les ordres d'expédition nouveaux ou non assignés peuvent être modifiés.");

        foreach (ShippingOrderProductModification modification in modifications) {
            switch (modification.ModificationType) {
                case ShippingOrderProductModificationTypeEnum.Addition:
                    modification.ShippingOrderProduct.Product.InStockQty -= modification.ShippingOrderProduct.Quantity;
                    context.ShippingOrderProducts.Add(modification.ShippingOrderProduct);
                    if (modification.ShippingOrderProduct.Product.InStockQty < modification.ShippingOrderProduct.Product.DesiredQty * 0.5) {
                        PurshaseOrder newPO = new PurshaseOrder();
                        newPO.Status = Domain.PurchaseOrderStatusEnum.Pending;
                        newPO.ProductId = modification.ShippingOrderProduct.Product.Id;
                        newPO.Quantity = (modification.ShippingOrderProduct.Product.DesiredQty - modification.ShippingOrderProduct.Product.InStockQty);
                        this.parentApp.PurchaseOrderService.Create(newPO);
                    }
                    break;
                case ShippingOrderProductModificationTypeEnum.Modification:
                    if (modification.NewQuantity > modification.OriginalQuantity) {
                        int quantityChange = modification.NewQuantity - modification.OriginalQuantity;
                        modification.ShippingOrderProduct.Product.InStockQty -= quantityChange;
                        modification.ShippingOrderProduct.Quantity = modification.NewQuantity;

                        if (modification.ShippingOrderProduct.Product.InStockQty < modification.ShippingOrderProduct.Product.DesiredQty * 0.5) {
                            PurshaseOrder newPO = new PurshaseOrder();
                            newPO.Status = Domain.PurchaseOrderStatusEnum.Pending;
                            newPO.ProductId = modification.ShippingOrderProduct.Product.Id;
                            newPO.Quantity = (modification.ShippingOrderProduct.Product.DesiredQty - modification.ShippingOrderProduct.Product.InStockQty);
                            this.parentApp.PurchaseOrderService.Create(newPO);
                        }
                    } else {
                        // newQuantity < Originalquantity
                        int quantityChange = modification.OriginalQuantity - modification.NewQuantity;
                        modification.ShippingOrderProduct.Product.InStockQty += quantityChange;
                        modification.ShippingOrderProduct.Quantity = modification.NewQuantity;

                    }
                    break;

                case ShippingOrderProductModificationTypeEnum.Removal:
                    modification.ShippingOrderProduct.Product.InStockQty += modification.ShippingOrderProduct.Quantity;
                    context.ShippingOrderProducts.Remove(modification.ShippingOrderProduct);
                    break;

                default:
                    throw new InvalidOperationException("Type de modification non pris en charge.");
            }
        }

        return this.dao.Update(order);
    }

    public ShippingOrder Delete(ShippingOrder shippingOrder, bool hardDelete = true) {
        return dao.Delete(shippingOrder, hardDelete);
    }
    public List<ShippingOrder> GetAllOrders() {
        try {
            return dao.GetAll();
        } catch (Exception ex) {
            throw;
        }
    }
}

     