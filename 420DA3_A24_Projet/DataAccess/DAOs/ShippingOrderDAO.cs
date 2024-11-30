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
    private readonly AppDbContexte _context;

    public ShippingOrderDAO(AppDbContexte context) {
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
        if (string.IsNullOrWhiteSpace(keyword))
            throw new ArgumentException("Le mot-clé de recherche ne peut pas être vide ou nul.", nameof(keyword));
        return _context.ShippingOrders
            .Where(so => so..Contains(keyword) && so.DateDeleted == null)
            .Include(so => so.SourceClient)
            .Include(so => so.DestinationAddress)
            .Include(so => so.CreatorEmplyee)
            .Include(so => so.FulfillEmployee)
            .Include(so => so.ShippingOrderProducts)
            .ToList();

        return this._context.ShippingOrders
    .Include(so => so.SourceClient)
        .ThenInclude(client => client.Entrepot)
    .Include(so => so.CreatorEmployee)
    .Include(so => so.DestinationAddress)
    .Include(so => so.Shipment)
    .Include(so => so.ShippingOrderProducts)
        .ThenInclude(sop => sop.Product)
    .Where(so =>
            so.Id.ToString().Contains(criterion)
            || so.Status.ToString().ToLower().Contains(criterion.ToLower())
            || so.SourceClient.NomCompagnie.ToLower().Contains(criterion.ToLower())
            || so.DestinationAddress.Destinataire.ToLower().Contains(criterion.ToLower())
            || so.ShippingOrderProducts.Any(sop => sop.Product.Id.ToString().Contains(criterion))
            || so.ShippingOrderProducts.Any(sop => sop.Product.nomproduit.ToLower().Contains(criterion.ToLower()))
            || ((so.Shipment == null || so.Shipment.CodeSuivi.ToLower().Contains(criterion.ToLower()))
        && (includeDeleted || so.DateDeleted == null))
    )
    .ToList();

    }
    public ShippingOrder Update(ShippingOrder shippingOrder)
    {
        if (shippingOrder == null)
            throw new ArgumentNullException(nameof(shippingOrder), "L'ordre d'expédition ne peut pas être nul.");

        _context.ShippingOrders.Update(shippingOrder);
        _context.SaveChanges();

        return shippingOrder;

    }
    public ShippingOrder Delete(ShippingOrder shippingOrder, bool hardDelete = true)
    {
       if (shippingOrder == null)
            throw new ArgumentNullException(nameof(shippingOrder), "L'ordre d'expédition ne peut pas être nul.");

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
