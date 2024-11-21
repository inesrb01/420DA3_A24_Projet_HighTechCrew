using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;

// TODO @AKRAM: DANGER: classe imbriquée. Supprimer la classe excédentaire (l'externe).
internal class Produits {


    public class Produit {
        public int Id { get; set; }

        // UNDONE @AKRAM: Validation dans les propriétés de type string
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

        // UNDONE @AKRAM: ajouter une propriété anti-concurrence RowVersion, type byte[]

        public int IdFournisseur { get; set; }  // TODO @AKRAM: supprimer: duplicata, mauvais nom
        public virtual Fournisseurs Fournisseur { get; set; }

        public int FournisseurId { get; set; } 
        public virtual Fournisseurs Fournisseurs { get; set; }   // TODO @AKRAM: supprimer: duplicata, mauvais nom


        // UNDONE @AKRAM: Il manque des propriétés de navigation:
        // OwnerClient, type Client
        // PurchaseOrders, type List<PurchaseOrder>
        // ShippingOrderProducts, type List<ShippingOrderProduct>



        // UNDONE @AKRAM: créer 2 constructeurs: 1 orienté création par utilisateurs, 1 orienté EF Core




        public bool PeutEtreSupprimer() {
            return QuantiteEnStock == 0;
        }

        public bool verifierSiReapprovisionner() {
            return QuantiteEnStock < QuantiteDesiree; // TODO @AKRAM: la vérification devrait être si < à 50% de la quantitée désirée
        }

        public void AjouterAuStock(int quantite) {
            QuantiteEnStock += quantite;
            DateModification = DateTime.Now; // TODO @AKRAM: supprimer, l'assignement d'une nouvelle date de modification devrait se faire directement dans le DAO
        }

        public void RetirerDuStock(int quantite) {
            if (QuantiteEnStock - quantite < 0) {
                throw new InvalidOperationException("Impossible de retirer plus que la quantité disponible.");
            }

            QuantiteEnStock -= quantite;
            DateModification = DateTime.Now; // TODO @AKRAM: supprimer, l'assignement d'une nouvelle date de modification devrait se faire directement dans le DAO
        }
        public void MettreAJourInfos(string nom, string description) {
            Nom = nom;
            Description = description;
            DateModification = DateTime.Now; // TODO @AKRAM: supprimer, l'assignement d'une nouvelle date de modification devrait se faire directement dans le DAO
        }

    }

}
