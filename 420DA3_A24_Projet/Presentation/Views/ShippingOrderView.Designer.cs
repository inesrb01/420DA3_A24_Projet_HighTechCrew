namespace _420DA3_A24_Projet.Presentation.Views;

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
        this.label1 = new Label();
        this.lblMode = new Label();
        this.lastPanel = new Panel();
        this.btnAnnuler = new Button();
        this.btnAction = new Button();
        this.centre = new TableLayoutPanel();
        this.panel2 = new Panel();
        this.lblChangQuantite = new Label();
        this.btnRetirerProduit = new Button();
        this.numChangerQuantite = new NumericUpDown();
        this.dtpDateExpedition = new DateTimePicker();
        this.lbldateexpedition = new Label();
        this.productOrderList = new ListBox();
        this.dtpDateSuppression = new DateTimePicker();
        this.dtpDateModification = new DateTimePicker();
        this.dtpDateCreation = new DateTimePicker();
        this.lblDeletDate = new Label();
        this.lblModificationDate = new Label();
        this.lblCreationDate = new Label();
        this.label3 = new Label();
        this.lblPlaceHolder = new Label();
        this.centerPanel = new Panel();
        this.txtClientSource = new TextBox();
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
        this.cmbStatut = new ComboBox();
        this.lblAdresse = new Label();
        this.lblClient = new Label();
        this.lblStatus = new Label();
        this.lblId = new Label();
        this.TopPanel.SuspendLayout();
        this.lastPanel.SuspendLayout();
        this.centre.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numChangerQuantite).BeginInit();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numId).BeginInit();
        this.grpBoxGestion.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numQuantiteAjouter).BeginInit();
        this.SuspendLayout();
        // 
        // TopPanel
        // 
        this.TopPanel.Controls.Add(this.label1);
        this.TopPanel.Controls.Add(this.lblMode);
        this.TopPanel.Dock = DockStyle.Top;
        this.TopPanel.Location = new Point(0, 0);
        this.TopPanel.Name = "TopPanel";
        this.TopPanel.Size = new Size(1120, 50);
        this.TopPanel.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(128, 12);
        this.label1.Name = "label1";
        this.label1.Size = new Size(106, 25);
        this.label1.TabIndex = 1;
        this.label1.Text = "PlaceHolder";
        // 
        // lblMode
        // 
        this.lblMode.AutoSize = true;
        this.lblMode.Location = new Point(39, 12);
        this.lblMode.Name = "lblMode";
        this.lblMode.Size = new Size(63, 25);
        this.lblMode.TabIndex = 0;
        this.lblMode.Text = "Mode:";
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
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 522F));
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
        this.panel2.Controls.Add(this.lblChangQuantite);
        this.panel2.Controls.Add(this.btnRetirerProduit);
        this.panel2.Controls.Add(this.numChangerQuantite);
        this.panel2.Controls.Add(this.dtpDateExpedition);
        this.panel2.Controls.Add(this.lbldateexpedition);
        this.panel2.Controls.Add(this.productOrderList);
        this.panel2.Controls.Add(this.dtpDateSuppression);
        this.panel2.Controls.Add(this.dtpDateModification);
        this.panel2.Controls.Add(this.dtpDateCreation);
        this.panel2.Controls.Add(this.lblDeletDate);
        this.panel2.Controls.Add(this.lblModificationDate);
        this.panel2.Controls.Add(this.lblCreationDate);
        this.panel2.Controls.Add(this.label3);
        this.panel2.Controls.Add(this.lblPlaceHolder);
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(527, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(516, 544);
        this.panel2.TabIndex = 2;
        // 
        // lblChangQuantite
        // 
        this.lblChangQuantite.AutoSize = true;
        this.lblChangQuantite.Location = new Point(355, 367);
        this.lblChangQuantite.Name = "lblChangQuantite";
        this.lblChangQuantite.Size = new Size(148, 25);
        this.lblChangQuantite.TabIndex = 28;
        this.lblChangQuantite.Text = "Changer quantite";
        // 
        // btnRetirerProduit
        // 
        this.btnRetirerProduit.Location = new Point(320, 327);
        this.btnRetirerProduit.Name = "btnRetirerProduit";
        this.btnRetirerProduit.Size = new Size(183, 34);
        this.btnRetirerProduit.TabIndex = 27;
        this.btnRetirerProduit.Text = "Retirer";
        this.btnRetirerProduit.UseVisualStyleBackColor = true;
        // 
        // numChangerQuantite
        // 
        this.numChangerQuantite.Location = new Point(333, 406);
        this.numChangerQuantite.Name = "numChangerQuantite";
        this.numChangerQuantite.Size = new Size(180, 31);
        this.numChangerQuantite.TabIndex = 26;
        // 
        // dtpDateExpedition
        // 
        this.dtpDateExpedition.Location = new Point(213, 141);
        this.dtpDateExpedition.Name = "dtpDateExpedition";
        this.dtpDateExpedition.Size = new Size(300, 31);
        this.dtpDateExpedition.TabIndex = 25;
        // 
        // lbldateexpedition
        // 
        this.lbldateexpedition.Location = new Point(10, 142);
        this.lbldateexpedition.Name = "lbldateexpedition";
        this.lbldateexpedition.Size = new Size(197, 34);
        this.lbldateexpedition.TabIndex = 24;
        this.lbldateexpedition.Text = "Date d'expidition";
        // 
        // productOrderList
        // 
        this.productOrderList.FormattingEnabled = true;
        this.productOrderList.ItemHeight = 25;
        this.productOrderList.Location = new Point(15, 330);
        this.productOrderList.Name = "productOrderList";
        this.productOrderList.Size = new Size(288, 204);
        this.productOrderList.TabIndex = 23;
        // 
        // dtpDateSuppression
        // 
        this.dtpDateSuppression.Location = new Point(213, 230);
        this.dtpDateSuppression.Name = "dtpDateSuppression";
        this.dtpDateSuppression.Size = new Size(300, 31);
        this.dtpDateSuppression.TabIndex = 22;
        // 
        // dtpDateModification
        // 
        this.dtpDateModification.Location = new Point(213, 186);
        this.dtpDateModification.Name = "dtpDateModification";
        this.dtpDateModification.Size = new Size(300, 31);
        this.dtpDateModification.TabIndex = 21;
        // 
        // dtpDateCreation
        // 
        this.dtpDateCreation.Location = new Point(213, 98);
        this.dtpDateCreation.Name = "dtpDateCreation";
        this.dtpDateCreation.Size = new Size(300, 31);
        this.dtpDateCreation.TabIndex = 20;
        // 
        // lblDeletDate
        // 
        this.lblDeletDate.Location = new Point(10, 235);
        this.lblDeletDate.Name = "lblDeletDate";
        this.lblDeletDate.Size = new Size(197, 34);
        this.lblDeletDate.TabIndex = 19;
        this.lblDeletDate.Text = "Date de suppression";
        // 
        // lblModificationDate
        // 
        this.lblModificationDate.Location = new Point(10, 191);
        this.lblModificationDate.Name = "lblModificationDate";
        this.lblModificationDate.Size = new Size(197, 34);
        this.lblModificationDate.TabIndex = 18;
        this.lblModificationDate.Text = "Date de modification";
        // 
        // lblCreationDate
        // 
        this.lblCreationDate.Location = new Point(3, 103);
        this.lblCreationDate.Name = "lblCreationDate";
        this.lblCreationDate.Size = new Size(197, 34);
        this.lblCreationDate.TabIndex = 17;
        this.lblCreationDate.Text = "Date de Création";
        // 
        // label3
        // 
        this.label3.Location = new Point(15, 28);
        this.label3.Name = "label3";
        this.label3.Size = new Size(197, 34);
        this.label3.TabIndex = 14;
        this.label3.Text = "emplye creator:";
        // 
        // lblPlaceHolder
        // 
        this.lblPlaceHolder.Location = new Point(234, 21);
        this.lblPlaceHolder.Margin = new Padding(5);
        this.lblPlaceHolder.Name = "lblPlaceHolder";
        this.lblPlaceHolder.Size = new Size(249, 38);
        this.lblPlaceHolder.TabIndex = 13;
        this.lblPlaceHolder.Text = "PLACEHOLDER";
        this.lblPlaceHolder.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.txtClientSource);
        this.centerPanel.Controls.Add(this.numId);
        this.centerPanel.Controls.Add(this.grpBoxGestion);
        this.centerPanel.Controls.Add(this.btnCreerAdresse);
        this.centerPanel.Controls.Add(this.txtDestinationAddresse);
        this.centerPanel.Controls.Add(this.cmbClient);
        this.centerPanel.Controls.Add(this.cmbStatut);
        this.centerPanel.Controls.Add(this.lblAdresse);
        this.centerPanel.Controls.Add(this.lblClient);
        this.centerPanel.Controls.Add(this.lblStatus);
        this.centerPanel.Controls.Add(this.lblId);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(77, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(444, 544);
        this.centerPanel.TabIndex = 0;
        // 
        // txtClientSource
        // 
        this.txtClientSource.Location = new Point(214, 102);
        this.txtClientSource.Name = "txtClientSource";
        this.txtClientSource.PlaceholderText = "Rechercher un client";
        this.txtClientSource.Size = new Size(227, 31);
        this.txtClientSource.TabIndex = 11;
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
        // cmbStatut
        // 
        this.cmbStatut.FormattingEnabled = true;
        this.cmbStatut.Location = new Point(214, 52);
        this.cmbStatut.Name = "cmbStatut";
        this.cmbStatut.Size = new Size(227, 33);
        this.cmbStatut.TabIndex = 5;
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
        this.TopPanel.ResumeLayout(false);
        this.TopPanel.PerformLayout();
        this.lastPanel.ResumeLayout(false);
        this.centre.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.numChangerQuantite).EndInit();
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
    private ComboBox cmbStatut;
    private GroupBox grpBoxGestion;
    private ListBox listProduitsDisponible;
    private Label lblQuantiteAjouter;
    private TextBox txtQuantiteAjoute;
    private Button btnAjouterProduit;
    private Panel panel2;
    private NumericUpDown numId;
    private NumericUpDown numQuantiteAjouter;
    private TextBox txtClientSource;
    private Label lblPlaceHolder;
    private Label lblModificationDate;
    private Label lblCreationDate;
    private Label label3;
    private Label lblDeletDate;
    private DateTimePicker dtpDateSuppression;
    private DateTimePicker dtpDateModification;
    private DateTimePicker dtpDateCreation;
    private ListBox productOrderList;
    private DateTimePicker dtpDateExpedition;
    private Label lbldateexpedition;
    private Label lblChangQuantite;
    private Button btnRetirerProduit;
    private NumericUpDown numChangerQuantite;
    private Label lblMode;
    private Label label1;
}