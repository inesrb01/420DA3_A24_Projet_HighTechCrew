using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
public partial class WarehouseView : Form {
    private ProjetApplication app;

    public WarehouseView(ProjetApplication app) {
        InitializeComponent();
    }

    public WarehouseView(ProjetApplication app) {
        this.app = app;
    }

    internal Warehouse? GetCurrentInstance() {
        throw new NotImplementedException();
    }

    internal DialogResult OpenFor(ViewActionsEnum viewAction, Warehouse? warehouse) {
        throw new NotImplementedException();
    }
}
