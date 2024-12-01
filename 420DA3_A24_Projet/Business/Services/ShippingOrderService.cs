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

    public ShippingOrderService(WsysApplication parentApp, AppDbContexte context) {
        this.parentApp = parentApp;
        this.dao = new ShippingOrderDAO(context);
        this.view = new ShippingOrderView(parentApp);
    }

    public void OpenView(ForViewActionsEnum action, ShippingOrder? shippingOrder = null) {
        view.Display(action, shippingOrder);

    }
    public ShippingOrder = ShipmentDAO.Create(shippingOrder)
    {
        return dao.Create(shippingOrder);
    }

      public ShippingOrder GetById(int id) 
      {
         var shippingOrder = dao.GetById(id);
          if (shippingOrder == null) 
          {
           parentApp.Notify($"Aucun ShippingOrder trouvé avec l'ID {id}.");
           return shippingOrder;
          }
      }

     public List<ShippingOrder> GetUnassignedInWarehouse(Warehouse warehouse)
     {
          return dao.GetByWarehouse(warehouse, ShippingOrderStatusEnum.Unassigned);
     }
      public List<ShippingOrder> GetPackagedInWarehouse(Warehouse warehouse)
      {
           return dao.GetByWarehouse(warehouse, ShippingOrderStatusEnum.Packaged);
      }
      public List<ShippingOrder> GetProcessingOrdersForWhEmployee(User user) 
      {
            return dao.GetByFulfillUser(user, ShippingOrderStatusEnum.Processing);
      }
       public List<ShippingOrder> Search(string keyword)
       {
             return dao.Search(keyword);
       }

    public ShippingOrder Update(ShippingOrder shippingOrder)
    {
         var updatedOrder = dao.Update(shippingOrder);
         parentApp.Notify("ShippingOrder mis à jour ");
         return updatedOrder;

    }
     public void Delete(ShippingOrder shippingOrder, bool hardDelete = true) 
     {
      dao.Delete(shippingOrder, hardDelete);
      parrentApp.Notify("ShippingOrder supprimé");


     }
     
}


