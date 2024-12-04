using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class SupplierDAO {

    private readonly AppDbContexte _context;

    public SupplierDAO(AppDbContexte context) {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

   
    public List<Supplier> GetAll() {
        return _context.Suppliers.Include(s => s.Products).ToList(); 
    }
 
    public Supplier? GetById(int id) {
        return _context.Suppliers
                       .Include(s => s.Products) 
                       .FirstOrDefault(s => s.Id == id);
    }

   
    public List<Supplier> Search(string filter) {
        return _context.Suppliers
                       .Include(s => s.Products)
                       .Where(s => s.SupplierName.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                                   s.ContactEmail.Contains(filter, StringComparison.OrdinalIgnoreCase))
                       .ToList();
    }

   
    public Supplier Create(Supplier supplier) {
        if (supplier == null)
            throw new ArgumentNullException(nameof(supplier));

        _context.Suppliers.Add(supplier);
        _context.SaveChanges();
        return supplier;
    }

    
    public Supplier Update(Supplier supplier) {
        if (supplier == null)
            throw new ArgumentNullException(nameof(supplier));

        Supplier? existing = _context.Suppliers.Find(supplier.Id);
        if (existing == null)
            throw new Exception($"Fournisseur avec l'ID {supplier.Id} introuvable.");

        
        existing.SupplierName = supplier.SupplierName;
        existing.ContactEmail = supplier.ContactEmail;
        existing.ContactTelephone = supplier.ContactTelephone;
        existing.ContactFirstName = supplier.ContactFirstName;
        existing.ContactLastName = supplier.ContactLastName;
        existing.DateModified = DateTime.Now;

        _context.SaveChanges();
        return existing;
    }

   
    public void Delete(Supplier supplier) {
        if (supplier == null)
            throw new ArgumentNullException(nameof(supplier));

        _context.Suppliers.Remove(supplier);
        _context.SaveChanges();
    }
}
