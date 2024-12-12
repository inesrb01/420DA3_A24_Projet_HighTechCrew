using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class AdressDAO {
    private readonly AppDbContext context;

    public AdressDAO(AppDbContext context) {
        this.context = context;
    }       
    public Address Create(Address address) {
        _=this.context.Addresses.Add(address); // Ajoute l'adresse au DbSet
        _=this.context.SaveChanges();         // Enregistre les modifications dans la base
        return address;                     // Retourne l'adresse créée
    }

    public Address GetById(int id) {
        return this.context.Addresses.FirstOrDefault(a => a.Id == id)
               ?? throw new KeyNotFoundException($"Adresse avec ID {id} introuvable.");
    }
        
    public Address Update(Address address) {
        Address existingAddress = this.context.Addresses.FirstOrDefault(a => a.Id == address.Id);
        if (existingAddress == null)
            throw new KeyNotFoundException($"Adresse avec ID {address.Id} introuvable.");

        this.context.Entry(existingAddress).CurrentValues.SetValues(address);
        _=this.context.SaveChanges();
        return address;
    }


    public void Delete(Address address) {
        Address existingAddress = this.context.Addresses.FirstOrDefault(a => a.Id == address.Id);
        if (existingAddress == null)
            throw new KeyNotFoundException($"Adresse avec ID {address.Id} introuvable.");

        existingAddress.DateDeleted = DateTime.Now;
        this.context.SaveChanges();
    }

    public List<Address> Search(string keyword) {
        return this.context.Addresses
                   .Where(a =>
                       a.Addressee.Contains(keyword) ||
                       a.Street.Contains(keyword) ||
                       a.City.Contains(keyword) ||
                       a.State.Contains(keyword) ||
                       a.PostalCode.Contains(keyword))
                   .ToList();
    }

    //public Address GetByWarehouse(entrepots warehouse) {
    //    return this.context.Addresses.FirstOrDefault(a => a.entrepotID == entrepots.ID)
    //           ?? throw new KeyNotFoundException($"Adresse pour l'entrepôt {entrepots.Id} introuvable.");
    //}

    //public Address GetByShipOrder(ShippingOrder order) {
    //    return this.context.Addresses.FirstOrDefault(a => a.ShippingOrderId == order.Id)
    //           ?? throw new KeyNotFoundException($"Adresse pour la commande d'expédition {order.Id} introuvable.");
    //}

}
