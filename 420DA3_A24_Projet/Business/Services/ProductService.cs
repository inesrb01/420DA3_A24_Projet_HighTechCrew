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
internal class ProductService {

    private readonly ProductDAO _productDAO;

    public ProductService(ProductDAO productDAO) {
        _productDAO = productDAO ?? throw new ArgumentNullException(nameof(productDAO));
    }

    
    public List<Product> GetAll() {
        return _productDAO.GetAll();
    }

    public Product? GetById(int id) {
        return _productDAO.GetById(id);
    }

   
    public Product Create(Product product) {
        ValidateProduct(product);
        return _productDAO.Create(product);
    }

    
    public Product Update(Product product) {
        if (product == null || product.Id <= 0)
            throw new ArgumentException("Produit invalide.");

        ValidateProduct(product);
        return _productDAO.Update(product);
    }

   
    public void Delete(int id) {
        Product? product = _productDAO.GetById(id);
        if (product == null)
            throw new Exception($"Produit avec l'ID {id} introuvable.");

        if (!product.CanBeDeleted())
            throw new Exception("Le produit ne peut pas être supprimé car il a du stock.");

        _productDAO.Delete(product);
    }

   
    public List<Product> Search(string filter) {
        if (string.IsNullOrWhiteSpace(filter))
            throw new ArgumentException("Filtre de recherche invalide.");

        return _productDAO.Search(filter);
    }

    
    private void ValidateProduct(Product product) {
        if (string.IsNullOrWhiteSpace(product.ProductName))
            throw new ArgumentException("Le nom du produit est requis.");
        if (string.IsNullOrWhiteSpace(product.UpcCode))
            throw new ArgumentException("Le code UPC est requis.");
        if (product.DesiredQty < 0)
            throw new ArgumentException("La quantité désirée ne peut pas être négative.");
        if (product.SupplierId <= 0)
            throw new ArgumentException("Un produit doit être associé à un fournisseur valide.");
    }
}

