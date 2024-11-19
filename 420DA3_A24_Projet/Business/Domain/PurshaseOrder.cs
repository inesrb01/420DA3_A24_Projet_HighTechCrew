using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;

public enum PurchaseOrderStatusEnum {
    Pending,
    Approved,
    Rejected,
    Completed
}
public class PurshaseOrder {


    // Attributs de la Classe PurshaseOrder 
    public int Id { get; set; }
    public PurchaseOrderStatusEnum Status { get; set; }
    public int ProductId { get; set; }
    public int WarehouseId { get; set; }
    public int Quantity { get; set; }
    public DateTime? CompletionDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    // Associations

    //public Product OrderedProduct { get; set; } // Utilisation directe de la classe existante
    //public Warehouse Warehouse { get; set; }   // Utilisation directe de la classe existante


    // Methode Complete pour 
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
