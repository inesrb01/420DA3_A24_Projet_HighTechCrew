namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShipmentView {
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
        this.label1 = new Label();
        this.lblMode = new Label();
        this.label2 = new Label();
        this.centre = new TableLayoutPanel();
        this.dtpDateExpedition = new DateTimePicker();
        this.lbldateexpedition = new Label();
        this.dtpDateSuppression = new DateTimePicker();
        this.dtpDateModification = new DateTimePicker();
        this.dtpDateCreation = new DateTimePicker();
        this.lblDeletDate = new Label();
        this.lblModificationDate = new Label();
        this.lblCreationDate = new Label();
        this.centerPanel = new Panel();
        this.txtNumSuivi = new TextBox();
        this.numId = new NumericUpDown();
        this.cmbClient = new ComboBox();
        this.cmbStatut = new ComboBox();
        this.lblNumSuivi = new Label();
        this.lblClient = new Label();
        this.lblStatus = new Label();
        this.lblId = new Label();
        this.btnAction = new Button();
        this.btnAnnuler = new Button();
        this.centre.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numId).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(38, 27);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0, 25);
        this.label1.TabIndex = 0;
        // 
        // lblMode
        // 
        this.lblMode.AutoSize = true;
        this.lblMode.Location = new Point(27, 27);
        this.lblMode.Name = "lblMode";
        this.lblMode.Size = new Size(63, 25);
        this.lblMode.TabIndex = 1;
        this.lblMode.Text = "Mode:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(111, 27);
        this.label2.Name = "label2";
        this.label2.Size = new Size(106, 25);
        this.label2.TabIndex = 2;
        this.label2.Text = "PlaceHolder";
        // 
        // centre
        // 
        this.centre.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.centre.ColumnCount = 3;
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 522F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centre.Controls.Add(this.centerPanel, 1, 0);
        this.centre.Location = new Point(38, 8);
        this.centre.Name = "centre";
        this.centre.RowCount = 1;
        this.centre.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centre.Size = new Size(1287, 554);
        this.centre.TabIndex = 3;
        // 
        // dtpDateExpedition
        // 
        this.dtpDateExpedition.Location = new Point(141, 370);
        this.dtpDateExpedition.Name = "dtpDateExpedition";
        this.dtpDateExpedition.Size = new Size(300, 31);
        this.dtpDateExpedition.TabIndex = 25;
        // 
        // lbldateexpedition
        // 
        this.lbldateexpedition.Location = new Point(-39, 375);
        this.lbldateexpedition.Name = "lbldateexpedition";
        this.lbldateexpedition.Size = new Size(197, 34);
        this.lbldateexpedition.TabIndex = 24;
        this.lbldateexpedition.Text = "Date d'expidition";
        // 
        // dtpDateSuppression
        // 
        this.dtpDateSuppression.Location = new Point(141, 467);
        this.dtpDateSuppression.Name = "dtpDateSuppression";
        this.dtpDateSuppression.Size = new Size(300, 31);
        this.dtpDateSuppression.TabIndex = 22;
        // 
        // dtpDateModification
        // 
        this.dtpDateModification.Location = new Point(141, 420);
        this.dtpDateModification.Name = "dtpDateModification";
        this.dtpDateModification.Size = new Size(300, 31);
        this.dtpDateModification.TabIndex = 21;
        // 
        // dtpDateCreation
        // 
        this.dtpDateCreation.Location = new Point(144, 333);
        this.dtpDateCreation.Name = "dtpDateCreation";
        this.dtpDateCreation.Size = new Size(300, 31);
        this.dtpDateCreation.TabIndex = 20;
        // 
        // lblDeletDate
        // 
        this.lblDeletDate.Location = new Point(-39, 464);
        this.lblDeletDate.Name = "lblDeletDate";
        this.lblDeletDate.Size = new Size(197, 34);
        this.lblDeletDate.TabIndex = 19;
        this.lblDeletDate.Text = "Date de suppression";
        // 
        // lblModificationDate
        // 
        this.lblModificationDate.Location = new Point(-84, 406);
        this.lblModificationDate.Name = "lblModificationDate";
        this.lblModificationDate.Size = new Size(197, 34);
        this.lblModificationDate.TabIndex = 18;
        this.lblModificationDate.Text = "Date de modification";
        // 
        // lblCreationDate
        // 
        this.lblCreationDate.Location = new Point(-39, 338);
        this.lblCreationDate.Name = "lblCreationDate";
        this.lblCreationDate.Size = new Size(197, 34);
        this.lblCreationDate.TabIndex = 17;
        this.lblCreationDate.Text = "Date de Création";
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.txtNumSuivi);
        this.centerPanel.Controls.Add(this.numId);
        this.centerPanel.Controls.Add(this.lbldateexpedition);
        this.centerPanel.Controls.Add(this.lblDeletDate);
        this.centerPanel.Controls.Add(this.dtpDateExpedition);
        this.centerPanel.Controls.Add(this.lblModificationDate);
        this.centerPanel.Controls.Add(this.cmbClient);
        this.centerPanel.Controls.Add(this.cmbStatut);
        this.centerPanel.Controls.Add(this.lblCreationDate);
        this.centerPanel.Controls.Add(this.dtpDateSuppression);
        this.centerPanel.Controls.Add(this.lblNumSuivi);
        this.centerPanel.Controls.Add(this.dtpDateModification);
        this.centerPanel.Controls.Add(this.lblClient);
        this.centerPanel.Controls.Add(this.dtpDateCreation);
        this.centerPanel.Controls.Add(this.lblStatus);
        this.centerPanel.Controls.Add(this.lblId);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(318, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(444, 548);
        this.centerPanel.TabIndex = 0;
        // 
        // txtNumSuivi
        // 
        this.txtNumSuivi.Location = new Point(214, 197);
        this.txtNumSuivi.Name = "txtNumSuivi";
        this.txtNumSuivi.PlaceholderText = "Numero de Suivi";
        this.txtNumSuivi.Size = new Size(227, 31);
        this.txtNumSuivi.TabIndex = 11;
        this.txtNumSuivi.TextChanged += this.txtNumSuivi_TextChanged;
        // 
        // numId
        // 
        this.numId.Location = new Point(214, 11);
        this.numId.Name = "numId";
        this.numId.Size = new Size(227, 31);
        this.numId.TabIndex = 10;
        // 
        // cmbClient
        // 
        this.cmbClient.FormattingEnabled = true;
        this.cmbClient.Location = new Point(214, 87);
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
        // lblNumSuivi
        // 
        this.lblNumSuivi.Location = new Point(3, 194);
        this.lblNumSuivi.Name = "lblNumSuivi";
        this.lblNumSuivi.Size = new Size(197, 34);
        this.lblNumSuivi.TabIndex = 4;
        this.lblNumSuivi.Text = "Numero de Suivi";
        // 
        // lblClient
        // 
        this.lblClient.Location = new Point(11, 85);
        this.lblClient.Name = "lblClient";
        this.lblClient.Size = new Size(194, 34);
        this.lblClient.TabIndex = 3;
        this.lblClient.Text = "service d'expedition";
        this.lblClient.TextAlign = ContentAlignment.MiddleRight;
        this.lblClient.Click += this.lblClient_Click;
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
        this.lblId.Location = new Point(0, 6);
        this.lblId.Name = "lblId";
        this.lblId.Size = new Size(188, 34);
        this.lblId.TabIndex = 0;
        this.lblId.Text = "Id: ";
        this.lblId.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(1172, 584);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(112, 34);
        this.btnAction.TabIndex = 4;
        this.btnAction.Text = "Action";
        this.btnAction.UseVisualStyleBackColor = true;
        this.btnAction.Click += this.btnAction_Click;
        // 
        // btnAnnuler
        // 
        this.btnAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAnnuler.Location = new Point(1290, 584);
        this.btnAnnuler.Name = "btnAnnuler";
        this.btnAnnuler.Size = new Size(112, 34);
        this.btnAnnuler.TabIndex = 5;
        this.btnAnnuler.Text = "Annuler";
        this.btnAnnuler.UseVisualStyleBackColor = true;
        this.btnAnnuler.Click += this.btnAnnuler_Click;
        // 
        // ShipmentView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1463, 644);
        this.Controls.Add(this.btnAnnuler);
        this.Controls.Add(this.btnAction);
        this.Controls.Add(this.centre);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.lblMode);
        this.Controls.Add(this.label1);
        this.Name = "ShipmentView";
        this.Text = "ShipmentView";
        this.centre.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.numId).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private Label lblMode;
    private Label label2;
    private TableLayoutPanel centre;
    private DateTimePicker dtpDateExpedition;
    private Label lbldateexpedition;
    private DateTimePicker dtpDateSuppression;
    private DateTimePicker dtpDateModification;
    private DateTimePicker dtpDateCreation;
    private Label lblDeletDate;
    private Label lblModificationDate;
    private Label lblCreationDate;
    private Panel centerPanel;
    private TextBox txtNumSuivi;
    private NumericUpDown numId;
    private ComboBox cmbClient;
    private ComboBox cmbStatut;
    private Label lblNumSuivi;
    private Label lblClient;
    private Label lblStatus;
    private Label lblId;
    private Button btnAction;
    private Button btnAnnuler;
}