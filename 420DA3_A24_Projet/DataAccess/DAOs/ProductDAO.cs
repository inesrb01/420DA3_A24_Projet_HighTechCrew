using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ProductDAO {
    private readonly AppDbContexte _context;

    public ProductDAO(AppDbContexte context) {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

  
    public List<Product> GetAll() {
        return _context.Products.Include(p => p.Supplier).ToList(); 
    }

  
    public Product? GetById(int id) {
        return _context.Products
                       .Include(p => p.Supplier) 
                       .FirstOrDefault(p => p.Id == id);
    }

   
    public List<Product> Search(string filter) {
        return _context.Products
                       .Include(p => p.Supplier)
                       .Where(p => p.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                                   p.UpcCode.Contains(filter, StringComparison.OrdinalIgnoreCase))
                       .ToList();
    }

    
    public Product Create(Product product) {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        _context.Products.Add(product);
        _context.SaveChanges();
        return product;
    }

    
    public Product Update(Product product) {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        Product? existing = _context.Products.Find(product.Id);
        if (existing == null)
            throw new Exception($"Produit avec l'ID {product.Id} introuvable.");

        
        existing.ProductName = product.ProductName;
        existing.ProductDescription = product.ProductDescription;
        existing.InStockQty = product.InStockQty;
        existing.DesiredQty = product.DesiredQty;
        existing.SupplierId = product.SupplierId;
        existing.WeightInKg = product.WeightInKg;
        existing.DateModified = DateTime.Now;

        _context.SaveChanges();
        return existing;
    }

    
    public void Delete(Product product) {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        _context.Products.Remove(product);
        _context.SaveChanges();
    }
}

