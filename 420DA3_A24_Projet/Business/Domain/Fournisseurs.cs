using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Produits;

namespace _420DA3_A24_Projet.Business.Domain;

// TODO @AKRAM: rendre la classe public et non internal
internal class Fournisseurs {
    public int Id { get; set; }

    // UNDONE @AKRAM: Validation dans les propriétés de type string
    public string Nom { get; set; }
    public string NomContact { get; set; } 
    public string PrenomContact { get; set; } 
    public string EmailContact { get; set; } 
    public string TelephoneContact { get; set; } 
    public DateTime DateCreation { get; set; } 
    public DateTime? DateModification { get; set; } 
    public DateTime? DateSuppression { get; set; }

    // UNDONE @AKRAM: ajouter une propriété anti-concurrence RowVersion, type byte[]


    public virtual List<Produit> Produits { get; set; } = new List<Produit>();


    // UNDONE @AKRAM: créer 2 constructeurs: 1 orienté création par utilisateurs, 1 orienté EF Core




    // TODO @AKRAM: méthode inutile, on a déjà accès à la liste de produits publique et sa méthode Add().
    // Changer l'Id du fournisseur dans le produit sera géré automatiquement par EF Core
    public void AjouterProduit(Produit produit) {
        if (produit != null) {
            produit.FournisseurId = Id; 
            Produits.Add(produit);
        }
    }

    // TODO @AKRAM: méthode inutile, on a déjà accès à la liste de produits publique et sa méthode Remove().
    public void SupprimerProduit(Produit produit) {
        Produits.Remove(produit);
    }

    // TODO @AKRAM: méthode inutile, on a déjà accès à la liste de produits publique et sa propriété Count.
    public int CompterProduits() {
        return Produits.Count; 
    }

    public void MettreAJourCoordonnees(string email, string telephone) {
        EmailContact = email; 
        TelephoneContact = telephone; 
    }
}

