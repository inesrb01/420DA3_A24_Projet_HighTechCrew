using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Product;

namespace _420DA3_A24_Projet.Business.Services;

internal class SupplierService {
    private readonly SupplierDAO _supplierDAO;

    public SupplierService(SupplierDAO supplierDAO) {
        _supplierDAO = supplierDAO ?? throw new ArgumentNullException(nameof(supplierDAO));
    }

    
    public List<Supplier> GetAll() {
        return _supplierDAO.GetAll();
    }

    
    public Supplier? GetById(int id) {
        return _supplierDAO.GetById(id);
    }

    
    public Supplier Create(Supplier supplier) {
        ValidateSupplier(supplier);
        return _supplierDAO.Create(supplier);
    }

   
    public Supplier Update(Supplier supplier) {
        if (supplier == null || supplier.Id <= 0)
            throw new ArgumentException("Fournisseur invalide.");

        ValidateSupplier(supplier);
        return _supplierDAO.Update(supplier);
    }

    
    public void Delete(int id) {
        Supplier? supplier = _supplierDAO.GetById(id);
        if (supplier == null)
            throw new Exception($"Fournisseur avec l'ID {id} introuvable.");

        if (supplier.Products.Count > 0)
            throw new Exception("Le fournisseur ne peut pas être supprimé car il a des produits associés.");

        _supplierDAO.Delete(supplier);
    }

    
    public List<Supplier> Search(string filter) {
        if (string.IsNullOrWhiteSpace(filter))
            throw new ArgumentException("Filtre de recherche invalide.");

        return _supplierDAO.Search(filter);
    }

   
    private void ValidateSupplier(Supplier supplier) {
        if (string.IsNullOrWhiteSpace(supplier.SupplierName))
            throw new ArgumentException("Le nom du fournisseur est requis.");
        if (string.IsNullOrWhiteSpace(supplier.ContactEmail))
            throw new ArgumentException("L'adresse email du fournisseur est requise.");
        if (!supplier.ValidateContactEmail(supplier.ContactEmail))
            throw new ArgumentException("L'adresse email est invalide.");
    }

}
