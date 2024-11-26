using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _420DA3_A24_Projet.Business.Domain;
public class Shipment {

    // TODO @HAJAR: ajouter un champ privé pour le tracking number

    // TODO @HAJAR: renommer la constante pour respecter les convention de casse de C# pour les membres publics (PascalCase)
    public const int trackingNumberMaxLength = 50; // TrackingNumberMaxLength
    public int Id { get; set; }
    public ShipmentStatusEnum Status { get; set; }
    public ShippingProvidersEnum ShippingService { get; set; }
    public int ShippingOrderId { get; set; }

    // TODO @HAJAR: valider la valeur assignée à la propriété dans le 'set' de TrackingNumber
    public string TrackingNumber { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; }
    public virtual ShippingOrder ShippingOrder { get; set; }


    // TODO @HAJAR: supprimer le paramètre trackingNumber de ce constructeur-ci
    public Shipment(int shippingOrderId, ShippingProvidersEnum shippingService, string trackingNumber) {
        this.ShippingOrderId = shippingOrderId;
        this.ShippingService = shippingService;

        // TODO @HAJAR: Utiliser la factory pour générer un tracking number en fonction du service de livraison:
        // this.TrackingNumber = TrackingNumberFactory.GetInstance().GetNewTrackingNumber(shippingService);
        this.TrackingNumber = trackingNumber; // supprimer
        this.Status = ShipmentStatusEnum.New;
    }

    protected Shipment(
        int id, 
        ShipmentStatusEnum status,
        ShippingProvidersEnum shippingService,
        int shippingOrderId,
        string trackingNumber,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(shippingOrderId, shippingService, trackingNumber) {

        this.Id = id;
        this.Status = status;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }
    public bool ValidateTrackingNumber(string trackingNumber) {
        return !string.IsNullOrEmpty(trackingNumber) && trackingNumber.Length <= trackingNumberMaxLength;
    }
}
