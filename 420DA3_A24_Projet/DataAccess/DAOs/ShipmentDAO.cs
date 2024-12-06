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
    private readonly AppDbContexte context;
    public ShipmentDAO(AppDbContexte context) 
    {
        this.context = context;throw new ArgumentNullException(nameof(context));
    }
    public Shipment Create(Shipment shipment)
    {
        
        context.Shipments.Add(shipment);
        context.SaveChanges();
        return shipment;

    }

    public List<Shipment> Search(string keyword)
    {
       
        return context.Shipments
             .Where(s => s.TrackingNumber.Contains(keyword) || s.Status.ToString().Contains(keyword))
             .Include(s => s.ShippingOrder) // Inclut l'ordre d'expédition lié
             .ToList();
    }
    public Shipment Update(Shipment shipment)
    {
        shipment.DateModified = DateTime.Now;
        context.Shipments.Update(shipment);
        context.SaveChanges();

        return shipment;
    }
    public Shipment Delete(Shipment shipment,bool hardDelete = true)
    {
        
        if (hardDelete)
        {
            context.Shipments.Remove(shipment);

        } 
        else
        {
            shipment.DateDeleted = DateTime.Now;
            context.Shipments.Update(shipment);  

        }
        context.SaveChanges();
        return shipment;
    }
    public Shipment? GetById(int id)
    {
        if (id <= 0) 
        {
            throw new ArgumentException("L'ID doit être supérieur à zéro.", nameof(id));
        }
   
        return context.Shipments
            .Include(so => so.ShippingOrder)
            .FirstOrDefault(s => s.Id == id && s.DateDeleted == null);
    }
    public List<Shipment> GetAll()
    {
        return context.Shipments
            .Where(s => s.DateDeleted == null)
            .Include(s => s.ShippingOrder)
            .ToList();

    }



}

