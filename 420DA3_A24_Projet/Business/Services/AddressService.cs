using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _420DA3_A24_Projet.Business.Services;
internal class AddressService {

    private WsysApplication parentApp;
    private AddressDAO dao;
    private AddressView View;
    private AppDbContext context;

    public AddressService(WsysApplication application, AppDbContext contexte) {
        this.parentApp = application;  // Utilisez 'application' au lieu de 'parentApp'
        this.context = contexte;       // Utilisez 'contexte' au lieu de 'context'
        this.dao = new AddressDAO(contexte);
        this.view = new AddressView();
    }

    public Address? OpenViewFor(ViewActionsEnum viewAction, Address? address = null) {
        try {
            DialogResult result = this.View.OpenFor(viewAction, address);
            if (result == DialogResult.OK) {
                switch (viewAction) {
                    case ViewActionsEnum.Creation:
                    case ViewActionsEnum.Edition:
                        _ = this.OpenViewFor(ViewActionsEnum.Visualization, this.view.GetCurrentInstance());
                        break;
                }
            }
            return this.view.GetCurrentInstance();
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
            return null;
        }
    }





}
