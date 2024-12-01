using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShipmentService 
{
    private ShipmentView view;
    private WsysApplication application;
    private ShipmentDAO dao;

    public ShipmentService(WsysApplication application, AppDbContexte contexte)
    {
        this.application = application;
        this.dao = new ShipmentDAO(contexte);
        this.view = new ShipmentView(Application);
    }
    public void OpenView(ForViewActionsEnum action, Shipment? shipment = null)
    {
        view.Display(action, shipment);
    }
    public Shipment Creat(Shipment shipment) 
    {
        var createdShipment = dao.Create(shipment);
        application.Notify("Shipment créé avec succès");
        return createdShipment;
    }
    public List<Shipment> Search(string keyword) 
    {
        return dao.Search(keyword);
    }
    public Shipment Update(Shipment shipment) 
    {
        var updatedShipment = dao.Update(shipment);
        application.Notify("Shipment mis à jour avec succès ");
        return updatedShipment;
    }
    public void Delete(Shipment shipment, bool hardDelete = true)
    {
        if (hardDelete) 
        {
            dao.Delete(shipment);
            application.Notify("Shipment supprimé avec succès");
        } else 
        {
            shipment.DateDeleted = DateTime.Now;
            dao.Update(shipment);
            application.Notify("Shipment marqué est deja supprimé ");
        }
    }
}
