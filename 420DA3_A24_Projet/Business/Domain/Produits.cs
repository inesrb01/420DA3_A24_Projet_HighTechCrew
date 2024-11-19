using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class Produits {

    public class Produit {
        public int Id { get; set; }
        public string CodeUPC { get; set; } 
        public string Nom { get; set; } 
        public string Description { get; set; } 
        public string? NomFichierImage { get; set; } 
        public string CodeFournisseur { get; set; } 
        public int QuantiteEnStock { get; set; } 
        public int QuantiteDesiree { get; set; } 
        public double PoidsEnKg { get; set; } 
        public DateTime DateCreation { get; set; } 
        public DateTime? DateModification { get; set; } 
        public DateTime? DateSuppression { get; set; } 

        public int IdFournisseur { get; set; } 
        public virtual Fournisseurs Fournisseur { get; set; }

        public int FournisseurId { get; set; } 
        public virtual Fournisseurs Fournisseurs { get; set; }

        public bool PeutEtreSupprimer() {
            return QuantiteEnStock == 0;
        }

        public bool verifierSiReapprovisionner() {
            return QuantiteEnStock < QuantiteDesiree;
        }

        public void AjouterAuStock(int quantite) {
            QuantiteEnStock += quantite;
            DateModification = DateTime.Now; 
        }

        public void RetirerDuStock(int quantite) {
            if (QuantiteEnStock - quantite < 0) {
                throw new InvalidOperationException("Impossible de retirer plus que la quantité disponible.");
            }

            QuantiteEnStock -= quantite;
            DateModification = DateTime.Now;
        }
        public void MettreAJourInfos(string nom, string description) {
            Nom = nom;
            Description = description;
            DateModification = DateTime.Now; 
        }

    }

}
