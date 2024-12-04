using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ShipmentDAO {
    private readonly AppDbContexte _context;
    public ShipmentDAO(AppDbContexte context) 
    {
        _context = context;throw new ArgumentNullException(nameof(context));
    }
    public Shipment create(Shipment shipment)
    {
        if (shipment == null)
            throw new ArgumentNullException(nameof(shipment), "L'envoi ne peut pas être nul.");
        _context.Shipments.Add(shipment);
        _context.SaveChanges();
        return shipment;

    }

    public List<Shipment> Search(string keyword)
    {
       
        return _context.Shipment
             .Where(s => s.TrackingNumber.Contains(keyword) || s.Status.ToString().Contains(keyword))
             .Include(s => s.ShippingOrder) // Inclut l'ordre d'expédition lié
             .ToList();
    }
    public Shipment Update(Shipment shipment)
    {
        if(shipment == null)
            throw new ArgumentNullException(nameof(shipment), "L'envoi ne peut pas être nul.");
        _context.Shipments.Update(shipment);
        _context.SaveChanges();

        return shipment;
    }
    public Shipment Delete(Shipment shipment,bool hardDelete = true)
    {
        if (shipment == null)
            throw new ArgumentNullException(nameof(shipment), "L'envoi ne peut pas être nul.");
        if (hardDelete)
        {
            _context.Shipments.Remove(shipment);

        } 
        else
        {
            shipment.DateDeleted = DateTime.Now;
            _context.Shipments.Update(shipment);  

        }
        _context.SaveChanges();
        return shipment;
    }
    public Shipment? GetById(int id)
    {
        if (id <= 0)
            throw new ArgumentException("L'ID doit être supérieur à zéro.", nameof(id));

        return _context.Shipments
            .Include(so => so.ShippingOrder)
            .FirstOrDefault(s => s.Id == id && s.DateDeleted == null);
    }
    public List<Shipment> GetAll()
    {
        return _context.Shipments
            .Where(s => s.DateDeleted == null)
            .Include(s => s.ShippingOrder)
            .ToList();

    }



}

