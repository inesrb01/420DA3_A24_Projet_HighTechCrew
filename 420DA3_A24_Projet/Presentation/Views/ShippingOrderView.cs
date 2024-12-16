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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ShippingOrderView : Form {
    private WsysApplication parentApp;
    private bool isInitialized = false;
    private ComboBox statusValue;
  
    public ShippingOrderView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }
    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadStatusComboBox();
            this.InitializeComponent();
        }
    }
    private void ReloadStatusComboBox() {
        this.statusValue.Items.Clear();
        this.statusValue.Items.AddRange(Enum.GetNames(typeof(ShippingOrderStatusEnum)));
    }
    public DialogResult OpenForCreation(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un ordre d'expédition", "Créer");
        return this.ShowDialog();
    }
    public DialogResult OpenForDetailsView(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Details d'un ", "Créer");
        return this.ShowDialog();
    }

    public void PreOpenSetup(ShippingOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        this.Initialize();
        this.CurrentAction = action;
        this.CurrentEntityInstance = instance;

        this.Text = windowTitle;
        this.btnAction.Text = actionButtonText;

        this.LoadDataInControls(instance);
        this.ActivateControls();
    }
    
}
   
    

    private void Label1_Click(object sender, EventArgs e) {

    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
        
    }

    private void label1_Click_1(object sender, EventArgs e) {

    }

    private void btnAction_Click(object sender, EventArgs e) {
        MessageBox.Show("Action exécutée avec succès !");

    }

    private void btnAnnuler_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void btnAjouterProduit_Click(object sender, EventArgs e) {
        if (listProduitsDisponible.SelectedItem == null) {
            MessageBox.Show("Veuillez sélectionner un produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        string selectedProduct = listProduitsDisponible.SelectedItem?.ToString();
        int quantity = (int) numQuantiteAjouter.Value;

        if (!string.IsNullOrEmpty(selectedProduct) && quantity > 0) {
            productOrderList.Items.Add($"{selectedProduct} - Quantité : {quantity}");
            MessageBox.Show("Produit ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } else {
            MessageBox.Show("Veuillez sélectionner un produit et une quantité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void btnRetirerProduit_Click(object sender, EventArgs e) {
        if (productOrderList.SelectedItems != null) {
            productOrderList.Items.Remove(productOrderList.SelectedItems);
            MessageBox.Show("Produit retiré avec succès !");
        } else {
            MessageBox.Show("Veuillez sélectionner un produit à retirer.");
        }

    }

    private void numChangerQuantite_ValueChanged(object sender, EventArgs e) {
        if (productOrderList.SelectedItems == null) {
            string selectedProduct = productOrderList.SelectedItem?.ToString();
            int nouvelleQuantite = (int) numChangerQuantite.Value;
            string productName = productOrderList.SelectedItem?.ToString();
            productOrderList.Items[productOrderList.SelectedIndex] = $"{productName} - Quantité : {nouvelleQuantite}";
        }
    }

    private void txtQuantiteAjoute_TextChanged(object sender, EventArgs e) {

    }

    private void numQuantiteAjouter_ValueChanged(object sender, EventArgs e) {

    }

    private void ShippingOrderView_Load(object sender, EventArgs e) {

    }
}
