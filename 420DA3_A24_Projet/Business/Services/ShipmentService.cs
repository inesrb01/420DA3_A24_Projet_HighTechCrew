using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShipmentService 
{
    private WsysApplication parentApp;
    private ShipmentDAO dao;
    private ShipmentView view;
    private AppDbContext context;

    public ShipmentService(WsysApplication application, AppDbContext contexte)
    {
        this.parentApp = parentApp;
        this.context = context;
        this.dao = new ShipmentDAO(context);
        this.view = new ShipmentView(parentApp);
    }
    /// <summary>
    /// cree un nouvel envoi(shipment)
    /// </summary>
  
    public Shipment CreateShipment(Shipment shipment) 
    {
        try 
        {
          
            return dao.Create(shipment);


        }
        catch (Exception ex) 
        {
            throw new Exception("Erreur lors de la création de l'envoi.", ex);
        }
    }
    public List<Shipment> Search(string keyword) {
        return dao.Search(keyword);

    }       
        
    public Shipment Update(Shipment shipment) 
    {
        try
        {
            return dao.Update(shipment);
        } catch (Exception ex) 
        {
            throw new Exception("Erreur lors de la mise à jour de l'envoi.", ex);
        }


    }

    public Shipment Delete(Shipment shipment, bool hardDelete = true)
    {
        return dao.Delete(shipment, hardDelete);



    }

    public Shipment? GetById(int id) {
        try {
            return dao.GetById(id);
        } catch (Exception ex) {
            throw new Exception($"Erreur lors de la récupération de l'envoi avec l'ID {id}.", ex);
        }

    }

}
