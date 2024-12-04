using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Product;

namespace _420DA3_A24_Projet.Business.Domain;
public class Warehouse 
    { 
    public int Id { get; set; } 
    public string Name { get; set; }
    public string AddressId  {get;set; } 
    public DateTime DateCreated { get; set; } 
    public DateTime? DateModified { get; set; } 
    public DateTime? DateDeleted { get; set; } 
    public byte[] RowVersion { get; set; }
   

    public virtual List<Client> Clients { get; set; } 
    public virtual Address Address { get; set; } 
    public virtual List<PurshaseOrder> PurshaseOrders { get; set; } 
    internal virtual List<User> WarehouseEmployees { get; set; }

    public Warehouse() 
    {
        Clients = new List<Client>();
        PurshaseOrders = new List<PurshaseOrder>();
        WarehouseEmployees = new List<User>();
    }

    public Warehouse(string name, int AddressId) {
        Name = name;
        AddressId = AddressId;
        DateCreated = DateTime.Now; 
        Clients = new List<Client>();
        PurshaseOrders = new List<PurshaseOrder>();
        WarehouseEmployees = new List<User>();
    }

    public Warehouse(int id, string name, int AddressId, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion) {
        Id = id;
        Name = name;
        AddressId = AddressId;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
        Clients = new List<Client>();
        PurshaseOrders = new List<PurshaseOrder>();
        WarehouseEmployees = new List<User>();
    }

    public override string ToString() 
    {
        return $"Entrepôt: {Name} (ID: {Id})\n" +
               $"Adresse ID: {AddressId}, Date de création: {DateCreated}\n" +
               $"Nombre de clients: {Clients?.Count ?? 0}, Nombre d'employés: {WarehouseEmployees?.Count ?? 0}";
    }

}



