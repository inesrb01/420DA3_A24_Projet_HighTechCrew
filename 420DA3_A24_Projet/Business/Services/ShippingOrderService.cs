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
    private  WsysApplication parentApp;
    private  ShippingOrderDAO dao;
    private  ShippingOrderView view;
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
    public ShippingOrder CreateOrder(ShippingOrder shippingOrder)
    {
        if (shippingOrder == null)
            throw new ArgumentNullException(nameof(shippingOrder), "L'ordre d'expédition ne peut pas être nul.");
        try
        {
            ValidateShippingOrder(shippingOrder);

            dao.Create(shippingOrder);

            view.DisplayMessage("L'ordre d'expédition a été créé avec succès.");
        }
        catch (Exception ex)
        {
            view.DisplayError($"Erreur lors de la création de l'ordre d'expédition ");
            throw;
        }
    }
    public void Search(string keyword)
    {
        try 
        {
            var results = dao.Search(keyword);
            view.DisplaySearchResults(results);
        }
        catch (Exception ex)
        {
            view.DisplayError($"Erreur lors de la recherche ");
            throw;
        }
    }
    public void UpdateOrder(ShippingOrder order, List<ShippingOrderProductModification> modifications) 
    {
        if (order == null)
            throw new ArgumentNullException(nameof(order), "L'ordre d'expédition ne peut pas être nul.");

        if (order.Status != ShippingOrderStatusEnum.Unassigned)
            throw new Exception("Seuls les ordres d'expédition non assignés peuvent être modifiés.");

        foreach (var modification in modifications)
        {
            switch (modification.ModificationType) 
            {
                case ShippingOrderProductModificationTypeEnum.Addition:
                    modification.ShippingOrderProduct.Product.qteStock -= modification.ShippingOrderProduct.Quantity;
                    context.ShippingOrderProducts.Add(modification.ShippingOrderProduct);
                    break;
                case ShippingOrderProductModificationTypeEnum.Modification:
                    if (modification.NewQuantity != modification.OriginalQuantity) 
                        
                    {
                        int quantityChange = modification.NewQuantity - modification.OriginalQuantity;
                        modification.ShippingOrderProduct.Product.qteStock -= quantityChange;
                        modification.ShippingOrderProduct.Quantity = modification.NewQuantity;

                        if (modification.ShippingOrderProduct.Product.qteStock < modification.ShippingOrderProduct.Quantity * 0.5) 
                        {
                            
                        }
                    }
                    break;

                case ShippingOrderProductModificationTypeEnum.Removal:
                    modification.ShippingOrderProduct.Product.qteStock += modification.ShippingOrderProduct.Quantity;
                    context.ShippingOrderProducts.Remove(modification.ShippingOrderProduct);
                    break;

                default:
                    throw new InvalidOperationException("Type de modification non pris en charge.");
            }
        }

        context.SaveChanges();
    }

    public void Delete(ShippingOrder shippingOrder, bool hardDelete = true) {
     {
            if (shippingOrder == null)
                throw new ArgumentNullException(nameof(shippingOrder), "L'ordre d'expédition ne peut pas être nul.");
            try {
                if (hardDelete) {
                    dao.Delete(shippingOrder);
                    view.DisplayMessage("L'ordre d'expédition a été supprimé définitivement.");
                } else {
                    shippingOrder.DateDeleted = DateTime.Now;
                    dao.Equals(shippingOrder);
                    view.DisplayMessage("L'ordre d'expédition a été marqué comme supprimé.");

                }

     }
     public List<ShippingOrder> GetAllOrders()
     {
                try {
                    return dao.GetAll();
                } catch (Exception ex) {
                    view.DisplayError($"Erreur lors de la récupération des ordres d'expédition");
                    throw;
                }
     }
            private void ValidateShippingOrder(ShippingOrder order) 
     {
                    if (order.SourceClientId <= 0)
                        throw new Exception("L'ID du client source est invalide.");
                    if (order.DestinationAddressId <= 0)
                        throw new Exception("L'ID de l'adresse de destination est invalide.");
                    if (order.CreatorEmployeeId <= 0)
     }


     