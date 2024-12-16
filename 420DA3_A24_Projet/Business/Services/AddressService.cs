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

    private WsysApplication ParentApp;
    private AddressDAO Dao;
    public AddressView View;
    public AppDbContext Context;

    public AddressService(WsysApplication application, AppDbContext context) {
        this.ParentApp = application;  // Utilisez 'application' au lieu de 'parentApp'
        this.Context = context;       // Utilisez 'contexte' au lieu de 'context'
        this.Dao = new AddressDAO(context);
        this.View = new AddressView();
    }

    public Address? OpenViewFor(ViewActionsEnum viewAction, Address? address = null) {
        try {
            DialogResult result = this.View.OpenFor(viewAction, address);
            if (result == DialogResult.OK) {
                switch (viewAction) {
                    case ViewActionsEnum.Creation:
                    case ViewActionsEnum.Edition:
                        _ = this.OpenViewFor(ViewActionsEnum.Visualization, this.View.GetCurrentInstance());
                        break;
                }
            }
            return this.View.GetCurrentInstance();
        } catch (Exception ex) {
            this.ParentApp.HandleException(ex);
            return null;
        }
    }





}
