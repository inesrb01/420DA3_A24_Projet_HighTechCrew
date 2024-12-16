namespace _420DA3_A24_Projet.Presentation.Views;

partial class PurchaseOrderView {
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
        this.panel1 = new Panel();
        this.panel4 = new Panel();
        this.panel3 = new Panel();
        this.panel2 = new Panel();
        this.PrchaseOrderIdLabel = new Label();
        this.PurchaseOrderQuantityLabel = new Label();
        this.ProductIdLabel = new Label();
        this.WarehouseIdLabel = new Label();
        this.dateDeletedDTPicker = new DateTimePicker();
        this.dateModifiedDTPicker = new DateTimePicker();
        this.dateCreatedDTPicker = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.IdTextBox = new TextBox();
        this.QuantityTextBox = new TextBox();
        this.ProductIdTextBox = new TextBox();
        this.WarehouseIdTextBox = new TextBox();
        this.label1 = new Label();
        this.dateTimePicker1 = new DateTimePicker();
        this.PurchaseOrderButton = new Button();
        this.panel1.SuspendLayout();
        this.panel4.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.panel4);
        this.panel1.Controls.Add(this.panel3);
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Location = new Point(12, 26);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(776, 396);
        this.panel1.TabIndex = 0;
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.PurchaseOrderButton);
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
        this.panel4.Controls.Add(this.WarehouseIdLabel);
        this.panel4.Controls.Add(this.ProductIdLabel);
        this.panel4.Controls.Add(this.PurchaseOrderQuantityLabel);
        this.panel4.Controls.Add(this.PrchaseOrderIdLabel);
        this.panel4.Location = new Point(144, 17);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(529, 376);
        this.panel4.TabIndex = 2;
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
        // PrchaseOrderIdLabel
        // 
        this.PrchaseOrderIdLabel.AutoSize = true;
        this.PrchaseOrderIdLabel.Location = new Point(16, 22);
        this.PrchaseOrderIdLabel.Name = "PrchaseOrderIdLabel";
        this.PrchaseOrderIdLabel.Size = new Size(22, 20);
        this.PrchaseOrderIdLabel.TabIndex = 0;
        this.PrchaseOrderIdLabel.Text = "Id";
        // 
        // PurchaseOrderQuantityLabel
        // 
        this.PurchaseOrderQuantityLabel.AutoSize = true;
        this.PurchaseOrderQuantityLabel.Location = new Point(260, 18);
        this.PurchaseOrderQuantityLabel.Name = "PurchaseOrderQuantityLabel";
        this.PurchaseOrderQuantityLabel.Size = new Size(65, 20);
        this.PurchaseOrderQuantityLabel.TabIndex = 1;
        this.PurchaseOrderQuantityLabel.Text = "Quantity";
        // 
        // ProductIdLabel
        // 
        this.ProductIdLabel.AutoSize = true;
        this.ProductIdLabel.Location = new Point(16, 65);
        this.ProductIdLabel.Name = "ProductIdLabel";
        this.ProductIdLabel.Size = new Size(81, 20);
        this.ProductIdLabel.TabIndex = 2;
        this.ProductIdLabel.Text = "Product Id ";
        // 
        // WarehouseIdLabel
        // 
        this.WarehouseIdLabel.AutoSize = true;
        this.WarehouseIdLabel.Location = new Point(244, 72);
        this.WarehouseIdLabel.Name = "WarehouseIdLabel";
        this.WarehouseIdLabel.Size = new Size(106, 20);
        this.WarehouseIdLabel.TabIndex = 3;
        this.WarehouseIdLabel.Text = "WareHouse Id ";
        // 
        // dateDeletedDTPicker
        // 
        this.dateDeletedDTPicker.Enabled = false;
        this.dateDeletedDTPicker.Location = new Point(226, 184);
        this.dateDeletedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedDTPicker.Name = "dateDeletedDTPicker";
        this.dateDeletedDTPicker.Size = new Size(221, 27);
        this.dateDeletedDTPicker.TabIndex = 19;
        // 
        // dateModifiedDTPicker
        // 
        this.dateModifiedDTPicker.Enabled = false;
        this.dateModifiedDTPicker.Location = new Point(226, 149);
        this.dateModifiedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedDTPicker.Name = "dateModifiedDTPicker";
        this.dateModifiedDTPicker.Size = new Size(221, 27);
        this.dateModifiedDTPicker.TabIndex = 18;
        // 
        // dateCreatedDTPicker
        // 
        this.dateCreatedDTPicker.Enabled = false;
        this.dateCreatedDTPicker.Location = new Point(226, 114);
        this.dateCreatedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedDTPicker.Name = "dateCreatedDTPicker";
        this.dateCreatedDTPicker.Size = new Size(221, 27);
        this.dateCreatedDTPicker.TabIndex = 17;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateDeletedLabel.Location = new Point(16, 184);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(161, 24);
        this.dateDeletedLabel.TabIndex = 16;
        this.dateDeletedLabel.Text = "Date de suppression: ";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateModifiedLabel.Location = new Point(16, 145);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(161, 23);
        this.dateModifiedLabel.TabIndex = 15;
        this.dateModifiedLabel.Text = "Date de modification: ";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateCreatedLabel.Location = new Point(16, 114);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(129, 24);
        this.dateCreatedLabel.TabIndex = 14;
        this.dateCreatedLabel.Text = "Date de création: ";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // IdTextBox
        // 
        this.IdTextBox.Location = new Point(113, 15);
        this.IdTextBox.Name = "IdTextBox";
        this.IdTextBox.Size = new Size(125, 27);
        this.IdTextBox.TabIndex = 20;
        // 
        // QuantityTextBox
        // 
        this.QuantityTextBox.Location = new Point(361, 19);
        this.QuantityTextBox.Name = "QuantityTextBox";
        this.QuantityTextBox.Size = new Size(125, 27);
        this.QuantityTextBox.TabIndex = 21;
        // 
        // ProductIdTextBox
        // 
        this.ProductIdTextBox.Location = new Point(113, 65);
        this.ProductIdTextBox.Name = "ProductIdTextBox";
        this.ProductIdTextBox.Size = new Size(125, 27);
        this.ProductIdTextBox.TabIndex = 22;
        // 
        // WarehouseIdTextBox
        // 
        this.WarehouseIdTextBox.Location = new Point(361, 65);
        this.WarehouseIdTextBox.Name = "WarehouseIdTextBox";
        this.WarehouseIdTextBox.Size = new Size(125, 27);
        this.WarehouseIdTextBox.TabIndex = 23;
        // 
        // label1
        // 
        this.label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.Location = new Point(17, 219);
        this.label1.Name = "label1";
        this.label1.Size = new Size(128, 21);
        this.label1.TabIndex = 24;
        this.label1.Text = "Completion Date";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateTimePicker1
        // 
        this.dateTimePicker1.Enabled = false;
        this.dateTimePicker1.Location = new Point(226, 231);
        this.dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
        this.dateTimePicker1.Name = "dateTimePicker1";
        this.dateTimePicker1.Size = new Size(221, 27);
        this.dateTimePicker1.TabIndex = 25;
        // 
        // PurchaseOrderButton
        // 
        this.PurchaseOrderButton.Location = new Point(66, 299);
        this.PurchaseOrderButton.Name = "PurchaseOrderButton";
        this.PurchaseOrderButton.Size = new Size(128, 29);
        this.PurchaseOrderButton.TabIndex = 26;
        this.PurchaseOrderButton.Text = "Purchase Order";
        this.PurchaseOrderButton.UseVisualStyleBackColor = true;
        // 
        // PurchaseOrderView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.panel1);
        this.Name = "PurchaseOrderView";
        this.Text = "PurchaseOrderView";
        this.panel1.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel4;
    private Panel panel3;
    private Panel panel2;
    private Label PurchaseOrderQuantityLabel;
    private Label PrchaseOrderIdLabel;
    private Label WarehouseIdLabel;
    private Label ProductIdLabel;
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
    private DateTimePicker dateTimePicker1;
    private Label label1;
    private Button PurchaseOrderButton;
}