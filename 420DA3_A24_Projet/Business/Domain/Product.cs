using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;

    public class Product {
       
        public int Id { get; set; }
        public string UpcCode { get; set; } 
        public string ProductName { get; set; } 
        public string ProductDescription { get; set; } 
        public string ImageFileName { get; set; } 
        public string SupplierCode { get; set; } 
        public int InStockQty { get; set; } 
        public int DesiredQty { get; set; } 
        public double WeightInKg { get; set; } 
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }

    
        public virtual Supplier Supplier { get; set; }




        public byte[] RowVersion { get; set; }

        
        public int OwnerClientId { get; set; }

        public int SupplierId { get; set; }
        

        public virtual List<PurshaseOrder> PurchaseOrders { get; set; } = new(); 
        public virtual List<ShippingOrder> ShippingOrderProducts { get; set; } = new(); 

        
        public Product() { }

        
        public Product(string productName, string productDescription, string upcCode, int desiredQty, string supplierCode) {
            ProductName = productName;
            ProductDescription = productDescription;
            UpcCode = upcCode;
            DesiredQty = desiredQty;
            SupplierCode = supplierCode;
            DateCreated = DateTime.Now;
        }

      
        public bool IsDueForRestocking() {
           
            return InStockQty < DesiredQty / 2;
        }

        public void AddToStock(int quantity) {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive.");
            InStockQty += quantity;
        }

        public void RemoveFromStock(int quantity) {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive.");
            if (InStockQty - quantity < 0)
                throw new InvalidOperationException("Cannot remove more stock than available.");
            InStockQty -= quantity;
        }

        public void UpdateProductInfo(string productName, string productDescription) {
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public bool CanBeDeleted() {
            // A product can only be deletrd if we dont have a stock
            return InStockQty == 0;
        }


    }


