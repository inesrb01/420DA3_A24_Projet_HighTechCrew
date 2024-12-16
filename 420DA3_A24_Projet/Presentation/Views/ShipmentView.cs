using _420DA3_A24_Projet.Business.Services;
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
internal partial class ShipmentView : Form {
    public ShipmentView(WsysApplication application) {
        
        InitializeComponent();
    }
    private void InitializeShipmentView() {
        this.Text = "Shipment View";
        this.MinimumSize = new System.Drawing.Size(800, 600);
    }
    private void lblClient_Click(object sender, EventArgs e) {

    }

    private void btnAction_Click(object sender, EventArgs e) {
        MessageBox.Show("Action exécutée !");
    }

    private void txtNumSuivi_TextChanged(object sender, EventArgs e) {

    }

    private void btnAnnuler_Click(object sender, EventArgs e) {
        this.Close();
    }
}
