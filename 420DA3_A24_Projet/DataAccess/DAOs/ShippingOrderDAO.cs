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
    private readonly AppDbContext _context;

    public ShippingOrderDAO(AppDbContext context) {
        _context = context ?? throw new ArgumentNullException(nameof(context));

    }
    public ShippingOrder Create(ShippingOrder shippingOrder)
    {
      if (shippingOrder == null) throw new ArgumentNullException(nameof(shippingOrder), "L'ordre d'expédition ne peut pas être nul.");
        _context.ShippingOrders.Add(shippingOrder);
        _context.SaveChanges();
        return shippingOrder;
    }
    public List<ShippingOrder> Search(string keyword)
    {
        return this._context.ShippingOrders
    .Include(so => so.SourceClient)
        .ThenInclude(client => client.Entrepot)
    .Include(so => so.CreatorEmployee)
    .Include(so => so.DestinationAddress)
    .Include(so => so.Shipment)
    .Include(so => so.ShippingOrderProducts)
        .ThenInclude(sop => sop.Product)
    .Where(so =>
            so.Id.ToString().Contains(keyword)
            || so.Status.ToString().ToLower().Contains(keyword.ToLower())
            || so.SourceClient.NomCompagnie.ToLower().Contains(keyword.ToLower())
            || so.DestinationAddress.Destinataire.ToLower().Contains(keyword.ToLower())
            || so.ShippingOrderProducts.Any(sop => sop.Product.Id.ToString().Contains(keyword))
            || so.ShippingOrderProducts.Any(sop => sop.Product.nomproduit.ToLower().Contains(keyword.ToLower()))
            || ((so.Shipment == null || so.Shipment.CodeSuivi.ToLower().Contains(keyword.ToLower()))
        && so.DateDeleted == null)
    )
    .ToList();

    }
    public ShippingOrder Update(ShippingOrder shippingOrder)
    {

        _context.ShippingOrders.Update(shippingOrder);
        _context.SaveChanges();

        return shippingOrder;

    }
    public ShippingOrder Delete(ShippingOrder shippingOrder, bool hardDelete = true)
    {
    

        if (hardDelete) 
        {
            _context.ShippingOrders.Remove(shippingOrder);

        }
        else 
        {
            shippingOrder.DateDeleted = DateTime.Now;
            _context.ShippingOrders.Update(shippingOrder);
        }
        _context.SaveChanges();
        return shippingOrder;
    }
    public ShippingOrder? GetById(int id) 
    {
        if (id <= 0)
            throw new ArgumentException("L'ID doit être supérieur à zéro.", nameof(id));

        return _context.ShippingOrders
            .Include(so => so.SourceClient)
            .Include(so => so.DestinationAddress)
            .Include(so => so.CreatorEmplyee)
            .Include(so => so.FulfillEmployee)
            .Include(so => so.ShippingOrderProducts)
            .FirstOrDefault(so => so.Id == id && so.DateDeleted == null);
    }
    public List<ShippingOrder> GetAll() 
    {
        return _context.ShippingOrders
                .Where(so => so.DateDeleted == null)
                .Include(so => so.SourceClient)
                .Include(so => so.DestinationAddress)
                .Include(so => so.CreatorEmplyee)
                .Include(so => so.FulfillEmployee)
                .Include(so => so.ShippingOrderProducts)
                .ToList();
    }
}
