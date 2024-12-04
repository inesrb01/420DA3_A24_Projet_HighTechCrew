using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class ShippingOrderProduct {
    public int ShippingOrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public virtual Product  Product { get; set; }
    public ShippingOrder ShippingOrder() { get; set; }
    public ShippingOrderProduct(int shippingOrderId, int productId, int quantity, Product product) {
        this.ShippingOrderId = shippingOrderId;
        this.ProductId = productId;
        this.Quantity = quantity;
        this.Product = product;
    }
}
