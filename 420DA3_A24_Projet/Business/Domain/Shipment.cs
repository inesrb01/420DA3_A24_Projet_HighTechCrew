using Microsoft.VisualBasic;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _420DA3_A24_Projet.Business.Domain;
public class Shipment {
    public const int trackingNumberMaxLength = 50;
    public int Id { get; set; }
    public ShipmentStatusEnum Status { get; set; }
    public ShippingProvidersEnum ShippingService { get; set; }
    public int ShippingOrderId { get; set; }
    public string TrackingNumber { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; }
    public virtual ShippingOrder ShippingOrder { get; set; }

    public Shipment(int shippingOrderId, ShippingProvidersEnum shippingService, string trackingNumber) {
        {
            this.ShippingOrderId = shippingOrderId;
            this.ShippingService = shippingService;
            this.TrackingNumber = trackingNumber;
            this.Status = ShipmentStatusEnum.New;
            
           
}
        Protected Shipment(int id, ShipmentStatusEnum status,
        ShippingProvidersEnum shippingService,
        int shippingOrderId,
        string trackingNumber,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
         : this(shippingOrderId, shippingService, trackingNumber)
        {
            this.Id = id;
            this.Status = status;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
        }
    }
        public bool ValidateTrackingNumber(string trackingNumber)
    {
        return !string.IsNullOrEmpty(trackingNumber) && trackingNumber.Length <= trackingNumberMaxLength;

    }
}
