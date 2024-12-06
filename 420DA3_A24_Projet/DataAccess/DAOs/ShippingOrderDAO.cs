using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ShippingOrderDAO {
    private readonly AppDbContext context;

    public ShippingOrderDAO(AppDbContext context) {
        this.context = context ?? throw new ArgumentNullException(nameof(context));

    }
    public ShippingOrder Create(ShippingOrder shippingOrder)
    {
      if (shippingOrder == null) throw new ArgumentNullException(nameof(shippingOrder), "L'ordre d'expédition ne peut pas être nul.");
        context.ShippingOrders.Add(shippingOrder);
        context.SaveChanges();
        return shippingOrder;
    }
    public List<ShippingOrder> Search(string keyword)
    {
        return this.context.ShippingOrders
            .Include(so => so.SourceClient)
                .ThenInclude(client => client.Warehouse)
            .Include(so => so.CreatorEmplyee)
            .Include(so => so.DestinationAddress)
            .Include(so => so.Shipment)
            .Include(so => so.ShippingOrderProducts)
                .ThenInclude(sop => sop.Product)
            .Where(so =>
                    so.Id.ToString().Contains(keyword)
                    || so.Status.ToString().ToLower().Contains(keyword.ToLower())
                    || so.SourceClient.ClientName.ToLower().Contains(keyword.ToLower())
                    || so.DestinationAddress.Addressee.ToLower().Contains(keyword.ToLower())
                    || so.ShippingOrderProducts.Any(sop => sop.Product.Id.ToString().Contains(keyword))
                    || so.ShippingOrderProducts.Any(sop => sop.Product.ProductName.ToLower().Contains(keyword.ToLower()))
                    || ((so.Shipment == null || so.Shipment.TrackingNumber.ToLower().Contains(keyword.ToLower()))
                && so.DateDeleted == null)
            )
            .ToList();

    }
    public ShippingOrder Update(ShippingOrder shippingOrder)
    {

        context.ShippingOrders.Update(shippingOrder);
        context.SaveChanges();

        return shippingOrder;

    }
    public ShippingOrder Delete(ShippingOrder shippingOrder, bool hardDelete = true)
    {
    

        if (hardDelete) 
        {
            context.ShippingOrders.Remove(shippingOrder);

        }
        else 
        {
            shippingOrder.DateDeleted = DateTime.Now;
            context.ShippingOrders.Update(shippingOrder);
        }
        context.SaveChanges();
        return shippingOrder;
    }
    public ShippingOrder? GetById(int id) 
    {
        if (id <= 0)
            throw new ArgumentException("L'ID doit être supérieur à zéro.", nameof(id));

        return context.ShippingOrders
            .Include(so => so.SourceClient)
            .Include(so => so.DestinationAddress)
            .Include(so => so.CreatorEmplyee)
            .Include(so => so.FulfillEmployee)
            .Include(so => so.ShippingOrderProducts)
            .FirstOrDefault(so => so.Id == id && so.DateDeleted == null);
    }
    public List<ShippingOrder> GetAll() 
    {
        return context.ShippingOrders
                .Where(so => so.DateDeleted == null)
                .Include(so => so.SourceClient)
                .Include(so => so.DestinationAddress)
                .Include(so => so.CreatorEmplyee)
                .Include(so => so.FulfillEmployee)
                .Include(so => so.ShippingOrderProducts)
                .ToList();
    }
}
