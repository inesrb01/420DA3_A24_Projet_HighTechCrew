using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class WsysApplication {
    private AppDbContext appDbContext;
    public ShipmentService ShipmentService { get; set; }
    public ShippingOrderService ShippingOrderService { get; set; }

    public ClientService ClientService { get; set; }


    public WsysApplication() {
        appDbContext = new AppDbContext();
        this.ShipmentService = new ShipmentService(this, appDbContext);
        this.ShippingOrderService = new ShippingOrderService(this,appDbContext);
    }

}
