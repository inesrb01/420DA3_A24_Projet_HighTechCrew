using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Product;

namespace _420DA3_A24_Projet.Business.Domain;


public class Warehouse {
    public int Id { get; set; } 
    public string WarehouseName { get; set; } 
    public int AddressId { get; set; } 
    public DateTime DateCreated { get; set; } 
    public DateTime? DateModified { get; set; } 
    public DateTime? DateDeleted { get; set; } 
    public byte[] RowVersion { get; set; } 

    public virtual List<Client> Clients { get; set; } = new List<Client>(); 
    public virtual Address Address { get; set; } 
    public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>(); 
    public virtual List<User> WarehouseEmployees { get; set; } = new List<User>(); 

    public Warehouse() 
    {

    }

    public Warehouse(string warehouseName, int addressId) {
        WarehouseName = warehouseName;
        AddressId = addressId;
        DateCreated = DateTime.Now; 
    }

    public Warehouse(int id, string warehouseName, int addressId, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion) {
        Id = id;
        WarehouseName = warehouseName;
        AddressId = addressId;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
    }

    public override string ToString() {
        return $"Warehouse: {WarehouseName} (ID: {Id}), AddressId: {AddressId}, Created: {DateCreated}, Modified: {DateModified?.ToString() ?? "N/A"}, Deleted: {DateDeleted?.ToString() ?? "N/A"}";
    }
}

