﻿namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShippingOrderView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.TopPanel = new Panel();
        this.lastPanel = new Panel();
        this.btnAnnuler = new Button();
        this.btnAction = new Button();
        this.centre = new TableLayoutPanel();
        this.panel2 = new Panel();
        this.button3 = new Button();
        this.textBox3 = new TextBox();
        this.groupBox2 = new GroupBox();
        this.label1 = new Label();
        this.button4 = new Button();
        this.textBox4 = new TextBox();
        this.centerPanel = new Panel();
        this.textBox1 = new TextBox();
        this.numId = new NumericUpDown();
        this.grpBoxGestion = new GroupBox();
        this.numQuantiteAjouter = new NumericUpDown();
        this.btnAjouterProduit = new Button();
        this.lblQuantiteAjouter = new Label();
        this.txtQuantiteAjoute = new TextBox();
        this.listProduitsDisponible = new ListBox();
        this.btnCreerAdresse = new Button();
        this.txtDestinationAddresse = new TextBox();
        this.cmbClient = new ComboBox();
        this.cmbStatus = new ComboBox();
        this.lblAdresse = new Label();
        this.lblClient = new Label();
        this.lblStatus = new Label();
        this.lblId = new Label();
        this.lastPanel.SuspendLayout();
        this.centre.SuspendLayout();
        this.panel2.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numId).BeginInit();
        this.grpBoxGestion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numQuantiteAjouter).BeginInit();
        this.SuspendLayout();
        // 
        // TopPanel
        // 
        this.TopPanel.Dock = DockStyle.Top;
        this.TopPanel.Location = new Point(0, 0);
        this.TopPanel.Name = "TopPanel";
        this.TopPanel.Size = new Size(1120, 50);
        this.TopPanel.TabIndex = 0;
        // 
        // lastPanel
        // 
        this.lastPanel.Controls.Add(this.btnAnnuler);
        this.lastPanel.Controls.Add(this.btnAction);
        this.lastPanel.Dock = DockStyle.Bottom;
        this.lastPanel.Location = new Point(0, 600);
        this.lastPanel.Name = "lastPanel";
        this.lastPanel.Size = new Size(1120, 50);
        this.lastPanel.TabIndex = 1;
        // 
        // btnAnnuler
        // 
        this.btnAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAnnuler.Location = new Point(996, 13);
        this.btnAnnuler.Name = "btnAnnuler";
        this.btnAnnuler.Size = new Size(112, 34);
        this.btnAnnuler.TabIndex = 1;
        this.btnAnnuler.Text = "Annuler";
        this.btnAnnuler.UseVisualStyleBackColor = true;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(860, 13);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(112, 34);
        this.btnAction.TabIndex = 0;
        this.btnAction.Text = "Action";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // centre
        // 
        this.centre.ColumnCount = 4;
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centre.Controls.Add(this.panel2, 2, 0);
        this.centre.Controls.Add(this.centerPanel, 1, 0);
        this.centre.Dock = DockStyle.Fill;
        this.centre.Location = new Point(0, 50);
        this.centre.Name = "centre";
        this.centre.RowCount = 1;
        this.centre.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centre.Size = new Size(1120, 550);
        this.centre.TabIndex = 2;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.button3);
        this.panel2.Controls.Add(this.textBox3);
        this.panel2.Controls.Add(this.groupBox2);
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(563, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(444, 544);
        this.panel2.TabIndex = 2;
        // 
        // button3
        // 
        this.button3.Location = new Point(13, 480);
        this.button3.Name = "button3";
        this.button3.Size = new Size(112, 34);
        this.button3.TabIndex = 12;
        this.button3.Text = "Retirer";
        this.button3.UseVisualStyleBackColor = true;
        // 
        // textBox3
        // 
        this.textBox3.Location = new Point(204, 501);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new Size(150, 31);
        this.textBox3.TabIndex = 11;
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.label1);
        this.groupBox2.Controls.Add(this.button4);
        this.groupBox2.Controls.Add(this.textBox4);
        this.groupBox2.Location = new Point(17, 251);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new Size(374, 234);
        this.groupBox2.TabIndex = 9;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Gestion des produits";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(91, 175);
        this.label1.Name = "label1";
        this.label1.Size = new Size(149, 25);
        this.label1.TabIndex = 4;
        this.label1.Text = "Produits ajoutés :";
        // 
        // button4
        // 
        this.button4.Location = new Point(251, 134);
        this.button4.Name = "button4";
        this.button4.Size = new Size(112, 34);
        this.button4.TabIndex = 3;
        this.button4.Text = "Ajouter";
        this.button4.UseVisualStyleBackColor = true;
        // 
        // textBox4
        // 
        this.textBox4.Location = new Point(45, 98);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new Size(150, 31);
        this.textBox4.TabIndex = 1;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.textBox1);
        this.centerPanel.Controls.Add(this.numId);
        this.centerPanel.Controls.Add(this.grpBoxGestion);
        this.centerPanel.Controls.Add(this.btnCreerAdresse);
        this.centerPanel.Controls.Add(this.txtDestinationAddresse);
        this.centerPanel.Controls.Add(this.cmbClient);
        this.centerPanel.Controls.Add(this.cmbStatus);
        this.centerPanel.Controls.Add(this.lblAdresse);
        this.centerPanel.Controls.Add(this.lblClient);
        this.centerPanel.Controls.Add(this.lblStatus);
        this.centerPanel.Controls.Add(this.lblId);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(113, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(444, 544);
        this.centerPanel.TabIndex = 0;
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(214, 102);
        this.textBox1.Name = "textBox1";
        this.textBox1.PlaceholderText = "Rechercher un client";
        this.textBox1.Size = new Size(227, 31);
        this.textBox1.TabIndex = 11;
        this.textBox1.TextChanged += this.textBox1_TextChanged;
        // 
        // numId
        // 
        this.numId.Location = new Point(214, 11);
        this.numId.Name = "numId";
        this.numId.Size = new Size(227, 31);
        this.numId.TabIndex = 10;
        // 
        // grpBoxGestion
        // 
        this.grpBoxGestion.Controls.Add(this.numQuantiteAjouter);
        this.grpBoxGestion.Controls.Add(this.btnAjouterProduit);
        this.grpBoxGestion.Controls.Add(this.lblQuantiteAjouter);
        this.grpBoxGestion.Controls.Add(this.txtQuantiteAjoute);
        this.grpBoxGestion.Controls.Add(this.listProduitsDisponible);
        this.grpBoxGestion.Location = new Point(3, 300);
        this.grpBoxGestion.Name = "grpBoxGestion";
        this.grpBoxGestion.Size = new Size(438, 232);
        this.grpBoxGestion.TabIndex = 9;
        this.grpBoxGestion.TabStop = false;
        this.grpBoxGestion.Text = "Gestion des produits";
        // 
        // numQuantiteAjouter
        // 
        this.numQuantiteAjouter.Location = new Point(258, 91);
        this.numQuantiteAjouter.Name = "numQuantiteAjouter";
        this.numQuantiteAjouter.Size = new Size(180, 31);
        this.numQuantiteAjouter.TabIndex = 11;
        // 
        // btnAjouterProduit
        // 
        this.btnAjouterProduit.Location = new Point(258, 128);
        this.btnAjouterProduit.Name = "btnAjouterProduit";
        this.btnAjouterProduit.Size = new Size(183, 34);
        this.btnAjouterProduit.TabIndex = 3;
        this.btnAjouterProduit.Text = "Ajouter";
        this.btnAjouterProduit.UseVisualStyleBackColor = true;
        // 
        // lblQuantiteAjouter
        // 
        this.lblQuantiteAjouter.AutoSize = true;
        this.lblQuantiteAjouter.Location = new Point(258, 67);
        this.lblQuantiteAjouter.Name = "lblQuantiteAjouter";
        this.lblQuantiteAjouter.Size = new Size(154, 25);
        this.lblQuantiteAjouter.TabIndex = 2;
        this.lblQuantiteAjouter.Text = "Quantité à ajouter";
        // 
        // txtQuantiteAjoute
        // 
        this.txtQuantiteAjoute.Location = new Point(6, 30);
        this.txtQuantiteAjoute.Name = "txtQuantiteAjoute";
        this.txtQuantiteAjoute.Size = new Size(246, 31);
        this.txtQuantiteAjoute.TabIndex = 1;
        // 
        // listProduitsDisponible
        // 
        this.listProduitsDisponible.FormattingEnabled = true;
        this.listProduitsDisponible.ItemHeight = 25;
        this.listProduitsDisponible.Location = new Point(6, 67);
        this.listProduitsDisponible.Name = "listProduitsDisponible";
        this.listProduitsDisponible.Size = new Size(246, 154);
        this.listProduitsDisponible.TabIndex = 0;
        // 
        // btnCreerAdresse
        // 
        this.btnCreerAdresse.Location = new Point(214, 178);
        this.btnCreerAdresse.Name = "btnCreerAdresse";
        this.btnCreerAdresse.Size = new Size(230, 34);
        this.btnCreerAdresse.TabIndex = 8;
        this.btnCreerAdresse.Text = "Créer Adresse";
        this.btnCreerAdresse.UseVisualStyleBackColor = true;
        // 
        // txtDestinationAddresse
        // 
        this.txtDestinationAddresse.Location = new Point(214, 218);
        this.txtDestinationAddresse.Multiline = true;
        this.txtDestinationAddresse.Name = "txtDestinationAddresse";
        this.txtDestinationAddresse.Size = new Size(230, 76);
        this.txtDestinationAddresse.TabIndex = 7;
        // 
        // cmbClient
        // 
        this.cmbClient.FormattingEnabled = true;
        this.cmbClient.Location = new Point(214, 139);
        this.cmbClient.Name = "cmbClient";
        this.cmbClient.Size = new Size(227, 33);
        this.cmbClient.TabIndex = 6;
        // 
        // cmbStatus
        // 
        this.cmbStatus.FormattingEnabled = true;
        this.cmbStatus.Location = new Point(214, 52);
        this.cmbStatus.Name = "cmbStatus";
        this.cmbStatus.Size = new Size(227, 33);
        this.cmbStatus.TabIndex = 5;
        // 
        // lblAdresse
        // 
        this.lblAdresse.Location = new Point(11, 183);
        this.lblAdresse.Name = "lblAdresse";
        this.lblAdresse.Size = new Size(197, 34);
        this.lblAdresse.TabIndex = 4;
        this.lblAdresse.Text = "Adresse de destination:";
        // 
        // lblClient
        // 
        this.lblClient.Location = new Point(14, 100);
        this.lblClient.Name = "lblClient";
        this.lblClient.Size = new Size(194, 34);
        this.lblClient.TabIndex = 3;
        this.lblClient.Text = "Client source: ";
        this.lblClient.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatus
        // 
        this.lblStatus.Location = new Point(22, 50);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new Size(186, 34);
        this.lblStatus.TabIndex = 2;
        this.lblStatus.Text = "Status: ";
        this.lblStatus.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblId
        // 
        this.lblId.Location = new Point(20, 8);
        this.lblId.Name = "lblId";
        this.lblId.Size = new Size(188, 34);
        this.lblId.TabIndex = 0;
        this.lblId.Text = "Id: ";
        this.lblId.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ShippingOrderView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1120, 650);
        this.Controls.Add(this.centre);
        this.Controls.Add(this.lastPanel);
        this.Controls.Add(this.TopPanel);
        this.MinimumSize = new Size(450, 500);
        this.Name = "ShippingOrderView";
        this.Text = "ShippingOrderView";
        this.lastPanel.ResumeLayout(false);
        this.centre.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.numId).EndInit();
        this.grpBoxGestion.ResumeLayout(false);
        this.grpBoxGestion.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.numQuantiteAjouter).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel TopPanel;
    private Panel lastPanel;
    private TableLayoutPanel centre;
    private Button btnAction;
    private Button btnAnnuler;
    private Panel centerPanel;
    private Label lblAdresse;
    private Label lblClient;
    private Label lblStatus;
    private Label lblId;
    private Button btnCreerAdresse;
    private TextBox txtDestinationAddresse;
    private ComboBox cmbClient;
    private ComboBox cmbStatus;
    private GroupBox grpBoxGestion;
    private ListBox listProduitsDisponible;
    private Label lblQuantiteAjouter;
    private TextBox txtQuantiteAjoute;
    private Button btnAjouterProduit;
    private Panel panel2;
    private Button button3;
    private TextBox textBox3;
    private GroupBox groupBox2;
    private Label label1;
    private Button button4;
    private TextBox textBox4;
    private NumericUpDown numId;
    private NumericUpDown numQuantiteAjouter;
    private TextBox textBox1;
}