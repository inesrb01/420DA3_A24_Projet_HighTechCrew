using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _420DA3_A24_Projet.Business.Domain;

// TODO @BRAHEM: supprimer: Utiliser Project_Utilities.Enums.PurchaseOrderStatusEnum déjà fourni
public enum PurchaseOrderStatusEnum {
    Pending,
    Approved,
    Rejected,
    Completed
}
public class PurchaseOrder {


    // Attributs de la Classe PurshaseOrder 
    public int Id { get; set; }
    public PurchaseOrderStatusEnum Status { get; set; } // TODO @BRAHEM: Utiliser l'enum fourni dans Project_Utilities.Enums
    public int ProductId { get; set; }
    public int WarehouseId { get; set; }
    public int Quantity { get; set; }
    public DateTime? CompletionDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    public Warehouse Entrepot { get; set; }

    // UNDONE @BRAHEM: ajouter une propriété anti-concurrence RowVersion, type byte[]

    // Associations

    // TODO @BRAHEM: Attention d'ajouter le modificateur 'virtual' aux propriétés de navigation
    //public Product OrderedProduct { get; set; } // Utilisation directe de la classe existante
    //public Warehouse Warehouse { get; set; }   // Utilisation directe de la classe existante



    // UNDONE @BRAHEM: créer 2 constructeurs: 1 orienté création par utilisateurs, 1 orienté EF Core

    public PurchaseOrder(int ProductId, int WarehouseId , int Quantity) {
        ProductId = ProductId;
        WarehouseId = WarehouseId;
        Quantity = Quantity;
        Status = PurchaseOrderStatusEnum.Pending;
        DateCreated = DateTime.Now;

    }

    // Constructeur orienté EF Core (sans paramètres explicites)
    public PurchaseOrder() {

    }


    // Methode Complete pour 
    // TODO @BRAHEM: à revoir / compléter
    public bool Complete() {
        if (this.Status == PurchaseOrderStatusEnum.Completed) {
            return false; // Déjà complété
        }

        // Exemple de validation supplémentaire
        if (this.Quantity <= 0) {
            throw new InvalidOperationException("La quantité ne peut pas être inférieure ou égale à zéro.");
        }

        this.Status = PurchaseOrderStatusEnum.Completed;
        this.CompletionDate = DateTime.Now;
        return true;
    }


}
