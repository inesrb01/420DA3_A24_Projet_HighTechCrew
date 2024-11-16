using Microsoft.VisualBasic.ApplicationServices;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class ShippingOrder {
    public int Id { get; set; }
    public  ShippingOrderStatusEnum Status { get; set; }
    public int SourceClientId { get; set; }
    public int CreatorEmployeeId {  get; set; }
    public int DestinationAddressId { get; set; }
    public int? FulfillEmployeedId { get; set; }
    public DateTime? ShippingDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; }
    public virtual client SourceClient { get; set; }
    public virtual User CreatorEmplyee { get; set; }
    public  virtual User? FulfillEmployee { get; set; }
    public virtual Address DestinationAddress { get; set; }

    public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; } = new List<ShippingOrderProduct>();
    
    public void AssignToWhEmployee(User user)
    {
        FulfillEmployee = user;
        FulfillEmployeedId = user.Id;
        Status = ShippingOrderStatusEnum.Processing;

    }
    public void MarkPackaged() 
    {
        if (Status == ShippingOrderStatusEnum.Processing)
        {
            Status = ShippingOrderStatusEnum.Packaged;
            DateModified = DateTime.Now;
        } else
        {
            throw new InvalidOperationException("he order must be 'Processing");
        }
    }
    public void MarkShipped()
    {
        if (Status == ShippingOrderStatusEnum.Packaged) 
        {
            Status = ShippingOrderStatusEnum.Shipped;
            DateModified = DateTime.Now;
            ShippingDate = DateTime.Now;
        }
        else 
        {
            throw new InvalidOperationException("Order cannot be marked as 'Shipped'");
        }

    }


}

