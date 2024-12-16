using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
namespace _420DA3_A24_Projet.Presentation.Views;

partial class AddressView {
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
    public void OpenFor(ViewModeEnum, Address? = null) {
        Console.WriteLine($"Ouverture de la vue pour le type d'adresse : {addressType}");
        // Ajoutez ici le code nécessaire pour ouvrir ou afficher une vue spécifique.
    }
    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.panel1 = new Panel();
        this.panel4 = new Panel();
        this.PostalCodeTextBox = new TextBox();
        this.PostalCodeLabel = new Label();
        this.textBox1 = new TextBox();
        this.CountryLabel = new Label();
        this.textBox2 = new TextBox();
        this.StateLabel = new Label();
        this.CityLabel = new Label();
        this.CityTextBox = new TextBox();
        this.AddAddressButton = new Button();
        this.dateTimePicker1 = new DateTimePicker();
        this.label1 = new Label();
        this.WarehouseIdTextBox = new TextBox();
        this.ProductIdTextBox = new TextBox();
        this.QuantityTextBox = new TextBox();
        this.IdTextBox = new TextBox();
        this.dateDeletedDTPicker = new DateTimePicker();
        this.dateModifiedDTPicker = new DateTimePicker();
        this.dateCreatedDTPicker = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.StreetLabel = new Label();
        this.AddresseeLabel = new Label();
        this.CivicNumberLabel = new Label();
        this.PrchaseOrderIdLabel = new Label();
        this.panel3 = new Panel();
        this.panel2 = new Panel();
        this.GetAddressButton = new Button();
        this.UpdateAddressButton = new Button();
        this.panel1.SuspendLayout();
        this.panel4.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.panel4);
        this.panel1.Controls.Add(this.panel3);
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Location = new Point(12, 27);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(776, 396);
        this.panel1.TabIndex = 1;
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.UpdateAddressButton);
        this.panel4.Controls.Add(this.GetAddressButton);
        this.panel4.Controls.Add(this.PostalCodeTextBox);
        this.panel4.Controls.Add(this.PostalCodeLabel);
        this.panel4.Controls.Add(this.textBox1);
        this.panel4.Controls.Add(this.CountryLabel);
        this.panel4.Controls.Add(this.textBox2);
        this.panel4.Controls.Add(this.StateLabel);
        this.panel4.Controls.Add(this.CityLabel);
        this.panel4.Controls.Add(this.CityTextBox);
        this.panel4.Controls.Add(this.AddAddressButton);
        this.panel4.Controls.Add(this.dateTimePicker1);
        this.panel4.Controls.Add(this.label1);
        this.panel4.Controls.Add(this.WarehouseIdTextBox);
        this.panel4.Controls.Add(this.ProductIdTextBox);
        this.panel4.Controls.Add(this.QuantityTextBox);
        this.panel4.Controls.Add(this.IdTextBox);
        this.panel4.Controls.Add(this.dateDeletedDTPicker);
        this.panel4.Controls.Add(this.dateModifiedDTPicker);
        this.panel4.Controls.Add(this.dateCreatedDTPicker);
        this.panel4.Controls.Add(this.dateDeletedLabel);
        this.panel4.Controls.Add(this.dateModifiedLabel);
        this.panel4.Controls.Add(this.dateCreatedLabel);
        this.panel4.Controls.Add(this.StreetLabel);
        this.panel4.Controls.Add(this.AddresseeLabel);
        this.panel4.Controls.Add(this.CivicNumberLabel);
        this.panel4.Controls.Add(this.PrchaseOrderIdLabel);
        this.panel4.Location = new Point(144, 17);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(529, 376);
        this.panel4.TabIndex = 2;
        // 
        // PostalCodeTextBox
        // 
        this.PostalCodeTextBox.Location = new Point(351, 121);
        this.PostalCodeTextBox.Name = "PostalCodeTextBox";
        this.PostalCodeTextBox.Size = new Size(125, 27);
        this.PostalCodeTextBox.TabIndex = 34;
        // 
        // PostalCodeLabel
        // 
        this.PostalCodeLabel.AutoSize = true;
        this.PostalCodeLabel.Location = new Point(265, 121);
        this.PostalCodeLabel.Name = "PostalCodeLabel";
        this.PostalCodeLabel.Size = new Size(83, 20);
        this.PostalCodeLabel.TabIndex = 33;
        this.PostalCodeLabel.Text = "PostalCode";
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(113, 121);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(125, 27);
        this.textBox1.TabIndex = 32;
        // 
        // CountryLabel
        // 
        this.CountryLabel.AutoSize = true;
        this.CountryLabel.Location = new Point(17, 124);
        this.CountryLabel.Name = "CountryLabel";
        this.CountryLabel.Size = new Size(60, 20);
        this.CountryLabel.TabIndex = 31;
        this.CountryLabel.Text = "Country";
        // 
        // textBox2
        // 
        this.textBox2.Location = new Point(351, 88);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new Size(125, 27);
        this.textBox2.TabIndex = 30;
        // 
        // StateLabel
        // 
        this.StateLabel.AutoSize = true;
        this.StateLabel.Location = new Point(260, 91);
        this.StateLabel.Name = "StateLabel";
        this.StateLabel.Size = new Size(43, 20);
        this.StateLabel.TabIndex = 29;
        this.StateLabel.Text = "State";
        // 
        // CityLabel
        // 
        this.CityLabel.AutoSize = true;
        this.CityLabel.Location = new Point(17, 95);
        this.CityLabel.Name = "CityLabel";
        this.CityLabel.Size = new Size(34, 20);
        this.CityLabel.TabIndex = 28;
        this.CityLabel.Text = "City";
        // 
        // CityTextBox
        // 
        this.CityTextBox.Location = new Point(113, 88);
        this.CityTextBox.Name = "CityTextBox";
        this.CityTextBox.Size = new Size(125, 27);
        this.CityTextBox.TabIndex = 27;
        // 
        // AddAddressButton
        // 
        this.AddAddressButton.Location = new Point(128, 302);
        this.AddAddressButton.Name = "AddAddressButton";
        this.AddAddressButton.Size = new Size(128, 29);
        this.AddAddressButton.TabIndex = 26;
        this.AddAddressButton.Text = "Add Address";
        this.AddAddressButton.UseVisualStyleBackColor = true;
        // 
        // dateTimePicker1
        // 
        this.dateTimePicker1.Enabled = false;
        this.dateTimePicker1.Location = new Point(226, 256);
        this.dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
        this.dateTimePicker1.Name = "dateTimePicker1";
        this.dateTimePicker1.Size = new Size(221, 27);
        this.dateTimePicker1.TabIndex = 25;
        // 
        // label1
        // 
        this.label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.Location = new Point(16, 256);
        this.label1.Name = "label1";
        this.label1.Size = new Size(128, 21);
        this.label1.TabIndex = 24;
        this.label1.Text = "Completion Date";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // WarehouseIdTextBox
        // 
        this.WarehouseIdTextBox.Location = new Point(361, 55);
        this.WarehouseIdTextBox.Name = "WarehouseIdTextBox";
        this.WarehouseIdTextBox.Size = new Size(125, 27);
        this.WarehouseIdTextBox.TabIndex = 23;
        // 
        // ProductIdTextBox
        // 
        this.ProductIdTextBox.Location = new Point(113, 55);
        this.ProductIdTextBox.Name = "ProductIdTextBox";
        this.ProductIdTextBox.Size = new Size(125, 27);
        this.ProductIdTextBox.TabIndex = 22;
        // 
        // QuantityTextBox
        // 
        this.QuantityTextBox.Location = new Point(361, 19);
        this.QuantityTextBox.Name = "QuantityTextBox";
        this.QuantityTextBox.Size = new Size(125, 27);
        this.QuantityTextBox.TabIndex = 21;
        // 
        // IdTextBox
        // 
        this.IdTextBox.Location = new Point(113, 15);
        this.IdTextBox.Name = "IdTextBox";
        this.IdTextBox.Size = new Size(125, 27);
        this.IdTextBox.TabIndex = 20;
        this.IdTextBox.TextChanged += this.IdTextBox_TextChanged;
        // 
        // dateDeletedDTPicker
        // 
        this.dateDeletedDTPicker.Enabled = false;
        this.dateDeletedDTPicker.Location = new Point(226, 221);
        this.dateDeletedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedDTPicker.Name = "dateDeletedDTPicker";
        this.dateDeletedDTPicker.Size = new Size(221, 27);
        this.dateDeletedDTPicker.TabIndex = 19;
        // 
        // dateModifiedDTPicker
        // 
        this.dateModifiedDTPicker.Enabled = false;
        this.dateModifiedDTPicker.Location = new Point(226, 182);
        this.dateModifiedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedDTPicker.Name = "dateModifiedDTPicker";
        this.dateModifiedDTPicker.Size = new Size(221, 27);
        this.dateModifiedDTPicker.TabIndex = 18;
        // 
        // dateCreatedDTPicker
        // 
        this.dateCreatedDTPicker.Enabled = false;
        this.dateCreatedDTPicker.Location = new Point(226, 155);
        this.dateCreatedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedDTPicker.Name = "dateCreatedDTPicker";
        this.dateCreatedDTPicker.Size = new Size(221, 27);
        this.dateCreatedDTPicker.TabIndex = 17;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateDeletedLabel.Location = new Point(16, 220);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(161, 24);
        this.dateDeletedLabel.TabIndex = 16;
        this.dateDeletedLabel.Text = "Date de suppression: ";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateModifiedLabel.Location = new Point(16, 186);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(161, 23);
        this.dateModifiedLabel.TabIndex = 15;
        this.dateModifiedLabel.Text = "Date de modification: ";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateCreatedLabel.Location = new Point(17, 151);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(129, 24);
        this.dateCreatedLabel.TabIndex = 14;
        this.dateCreatedLabel.Text = "Date de création: ";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // StreetLabel
        // 
        this.StreetLabel.AutoSize = true;
        this.StreetLabel.Location = new Point(260, 55);
        this.StreetLabel.Name = "StreetLabel";
        this.StreetLabel.Size = new Size(48, 20);
        this.StreetLabel.TabIndex = 3;
        this.StreetLabel.Text = "Street";
        // 
        // AddresseeLabel
        // 
        this.AddresseeLabel.AutoSize = true;
        this.AddresseeLabel.Location = new Point(17, 55);
        this.AddresseeLabel.Name = "AddresseeLabel";
        this.AddresseeLabel.Size = new Size(78, 20);
        this.AddresseeLabel.TabIndex = 2;
        this.AddresseeLabel.Text = "Addressee";
        // 
        // CivicNumberLabel
        // 
        this.CivicNumberLabel.AutoSize = true;
        this.CivicNumberLabel.Location = new Point(260, 18);
        this.CivicNumberLabel.Name = "CivicNumberLabel";
        this.CivicNumberLabel.Size = new Size(98, 20);
        this.CivicNumberLabel.TabIndex = 1;
        this.CivicNumberLabel.Text = "Civic Number";
        // 
        // PrchaseOrderIdLabel
        // 
        this.PrchaseOrderIdLabel.AutoSize = true;
        this.PrchaseOrderIdLabel.Location = new Point(16, 22);
        this.PrchaseOrderIdLabel.Name = "PrchaseOrderIdLabel";
        this.PrchaseOrderIdLabel.Size = new Size(22, 20);
        this.PrchaseOrderIdLabel.TabIndex = 0;
        this.PrchaseOrderIdLabel.Text = "Id";
        // 
        // panel3
        // 
        this.panel3.Location = new Point(22, 17);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(104, 376);
        this.panel3.TabIndex = 1;
        // 
        // panel2
        // 
        this.panel2.Location = new Point(679, 17);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(81, 376);
        this.panel2.TabIndex = 0;
        // 
        // GetAddressButton
        // 
        this.GetAddressButton.Location = new Point(361, 302);
        this.GetAddressButton.Name = "GetAddressButton";
        this.GetAddressButton.Size = new Size(125, 29);
        this.GetAddressButton.TabIndex = 35;
        this.GetAddressButton.Text = "Get Address";
        this.GetAddressButton.UseVisualStyleBackColor = true;
        // 
        // UpdateAddressButton
        // 
        this.UpdateAddressButton.Location = new Point(245, 337);
        this.UpdateAddressButton.Name = "UpdateAddressButton";
        this.UpdateAddressButton.Size = new Size(132, 29);
        this.UpdateAddressButton.TabIndex = 36;
        this.UpdateAddressButton.Text = "Update Adrress";
        this.UpdateAddressButton.UseVisualStyleBackColor = true;
        // 
        // AddressView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.panel1);
        this.Name = "AddressView";
        this.Text = "Form1";
        this.panel1.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel4;
    private Button AddAddressButton;
    private DateTimePicker dateTimePicker1;
    private Label label1;
    private TextBox WarehouseIdTextBox;
    private TextBox ProductIdTextBox;
    private TextBox QuantityTextBox;
    private TextBox IdTextBox;
    private DateTimePicker dateDeletedDTPicker;
    private DateTimePicker dateModifiedDTPicker;
    private DateTimePicker dateCreatedDTPicker;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label StreetLabel;
    private Label AddresseeLabel;
    private Label CivicNumberLabel;
    private Label PrchaseOrderIdLabel;
    private Panel panel3;
    private Panel panel2;
    private TextBox textBox2;
    private Label StateLabel;
    private Label CityLabel;
    private TextBox CityTextBox;
    private TextBox PostalCodeTextBox;
    private Label PostalCodeLabel;
    private TextBox textBox1;
    private Label CountryLabel;
    private Button UpdateAddressButton;
    private Button GetAddressButton;
}