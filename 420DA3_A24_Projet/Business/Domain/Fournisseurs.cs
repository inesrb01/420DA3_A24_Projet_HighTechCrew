using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Produits;

namespace _420DA3_A24_Projet.Business.Domain;
internal class Fournisseurs {
    public int Id { get; set; } 
    public string Nom { get; set; }
    public string NomContact { get; set; } 
    public string PrenomContact { get; set; } 
    public string EmailContact { get; set; } 
    public string TelephoneContact { get; set; } 
    public DateTime DateCreation { get; set; } 
    public DateTime? DateModification { get; set; } 
    public DateTime? DateSuppression { get; set; } 

    public virtual List<Produit> Produits { get; set; } = new List<Produit>(); 

    
    public void AjouterProduit(Produit produit) {
        if (produit != null) {
            produit.FournisseurId = Id; 
            Produits.Add(produit);
        }
    }

    public void SupprimerProduit(Produit produit) {
        Produits.Remove(produit);
    }
    public int CompterProduits() {
        return Produits.Count; 
    }
    public void MettreAJourCoordonnees(string email, string telephone) {
        EmailContact = email; 
        TelephoneContact = telephone; 
    }
}

