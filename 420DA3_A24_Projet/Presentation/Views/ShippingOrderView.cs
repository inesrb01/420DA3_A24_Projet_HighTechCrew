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
        cmbStatut.Items.Clear();
        cmbStatut.Items.AddRange(Enum.GetNames(typeof(ShippingOrderStatusEnum)));
    }
    public DialogResult OpenForCreation(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un ordre d'expédition", "Créer");
        return this.ShowDialog();
    }
    public DialogResult OpenForDetailsView(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un ordre d'expédition", "Créer");
        return this.ShowDialog();
    }

    public void PreOpenSetup(ShippingOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        {
            this.Initialize();
            this.Text = windowTitle;
            this.btnAction.Text = actionButtonText;

        }

    }

    private void productOrderList_SelectedIndexChanged(object sender, EventArgs e) {
        if (productOrderList.SelectedItem != null) {
            string selectedItem = productOrderList.SelectedItem.ToString();
            string[] parts = selectedItem.Split('-');
            if (parts.Length == 2) {
                string productName = parts[0].Trim();
                string productDescription = parts[1].Trim().Replace("Quantité :", "").Trim();
                if (int.TryParse(productDescription, out int quantity)) {
                    numChangerQuantite.Value = quantity;
                }
                {
                    numChangerQuantite.Value = quantity;

                }
            }

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


    private void numChangerQuantite_ValueChanged(object sender, EventArgs e) {
        if (productOrderList.SelectedItem != null) {
            string selectedProduct = productOrderList.SelectedItem?.ToString();
            int nouvelleQuantite = (int) numChangerQuantite.Value;

            productOrderList.Items[productOrderList.SelectedIndex] = $"{selectedProduct.Split('-')[0]} - Quantité : {nouvelleQuantite}";
        }
    }

    private void txtQuantiteAjoute_TextChanged(object sender, EventArgs e) {
        if (int.TryParse(txtQuantiteAjoute.Text, out int valeur)) {
            numQuantiteAjouter.Value = Math.Min(numQuantiteAjouter.Maximum, Math.Max(numQuantiteAjouter.Minimum, valeur));
        }

    }

    private void numQuantiteAjouter_ValueChanged(object sender, EventArgs e) {
        txtQuantiteAjoute.Text = numQuantiteAjouter.Value.ToString();

    }

    private void btnRetirerProduit_Click_1(object sender, EventArgs e) {
        if (productOrderList.SelectedItem != null) {
            productOrderList.Items.Remove(productOrderList.SelectedItem);
            MessageBox.Show("Produit retiré avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } else {
            MessageBox.Show("Veuillez sélectionner un produit à retirer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void numQuantiteAjouter_ValueChanged_1(object sender, EventArgs e) {

        txtQuantiteAjoute.Text = numQuantiteAjouter.Value.ToString();


    }

    private void lblId_Click(object sender, EventArgs e) {

    }

    private void ShippingOrderView_Load(object sender, EventArgs e) {

    }
}
