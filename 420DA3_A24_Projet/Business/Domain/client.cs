using _420DA3_A24_Projet.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain 
    {
    public class Client 
    {

        public int Id { get; set; } 
        public string ClientName { get; set; }
        public string ContactFirstName { get; set; } 
        public string ContactLastName { get; set; } 
        public string ContactEmail { get; set; } 
        public string ContactTelephone { get; set; }
        public int WarehouseID { get; set; } 
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public int WarehouseId {  get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse AssignedWarehouse { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<ShippingOrder> Orders { get; set; }
        
        public Client() {
            Orders = new List<ShippingOrder>(); 
            Products = new List<Product>();
        }


        public Client(string ClientName, string Contactfirstname, string Contactlastname, string ContactEmail, string ContactTelephone, int WarehouseID) {
            ClientName = ClientName;
            Contactfirstname = Contactfirstname;
            Contactlastname = Contactlastname;
            ContactEmail = ContactEmail;
            ContactTelephone = ContactTelephone;
            WarehouseID = WarehouseID;
            DateCreated = DateTime.Now; 
            Orders = new List<ShippingOrder>();
            Products = new List<Product>();

        }
        public Client(int id, string ClientName, string ContactFirstName, string ContactLastName, string ContactEmail, string ContactTelephone, int WarehouseID, DateTime dateCreated, DateTime? dateDeleted, byte[] rowVersion) {
            ClientName = ClientName;
            ContactFirstName = ContactFirstName;
            ContactLastName = ContactLastName;
            ContactEmail = ContactEmail;
            ContactTelephone = ContactTelephone;
            WarehouseID = WarehouseID;
            DateCreated = DateCreated;
            DateDeleted = DateDeleted;
            DateModified = DateModified;
            RowVersion = rowVersion;
            Orders = new List<ShippingOrder>();
            Products = new List<Product>();
        }
            public override string ToString() 
            {

            return $"Client: {ClientName} ({ContactFirstName} {ContactLastName})\n" +
                   $"Email: {ContactEmail}, Téléphone: {ContactTelephone}\n" +
                   $"Entrepôt assigné: {WarehouseID}, Date de création: {DateCreated}";

        }

            }

    }


