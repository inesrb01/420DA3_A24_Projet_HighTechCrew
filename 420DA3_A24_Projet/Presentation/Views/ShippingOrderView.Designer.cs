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
        this.lastPanel = new Panel();
        this.centre = new TableLayoutPanel();
        this.btnAction = new Button();
        this.btnAnnuler = new Button();
        this.lblId = new Label();
        this.lastPanel.SuspendLayout();
        this.centre.SuspendLayout();
        this.SuspendLayout();
        // 
        // TopPanel
        // 
        this.TopPanel.Dock = DockStyle.Top;
        this.TopPanel.Location = new Point(0, 0);
        this.TopPanel.Name = "TopPanel";
        this.TopPanel.Size = new Size(800, 50);
        this.TopPanel.TabIndex = 0;
        // 
        // lastPanel
        // 
        this.lastPanel.Controls.Add(this.btnAnnuler);
        this.lastPanel.Controls.Add(this.btnAction);
        this.lastPanel.Dock = DockStyle.Bottom;
        this.lastPanel.Location = new Point(0, 400);
        this.lastPanel.Name = "lastPanel";
        this.lastPanel.Size = new Size(800, 50);
        this.lastPanel.TabIndex = 1;
        // 
        // centre
        // 
        this.centre.ColumnCount = 3;
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centre.Controls.Add(this.lblId, 1, 0);
        this.centre.Dock = DockStyle.Fill;
        this.centre.Location = new Point(0, 50);
        this.centre.Name = "centre";
        this.centre.RowCount = 1;
        this.centre.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centre.Size = new Size(800, 350);
        this.centre.TabIndex = 2;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Location = new Point(540, 13);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(112, 34);
        this.btnAction.TabIndex = 0;
        this.btnAction.Text = "Action";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnAnnuler
        // 
        this.btnAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAnnuler.Location = new Point(676, 13);
        this.btnAnnuler.Name = "btnAnnuler";
        this.btnAnnuler.Size = new Size(112, 34);
        this.btnAnnuler.TabIndex = 1;
        this.btnAnnuler.Text = "Annuler";
        this.btnAnnuler.UseVisualStyleBackColor = true;
        // 
        // lblId
        // 
        this.lblId.AutoSize = true;
        this.lblId.Location = new Point(203, 0);
        this.lblId.Name = "lblId";
        this.lblId.Size = new Size(32, 25);
        this.lblId.TabIndex = 0;
        this.lblId.Text = "Id:";
        this.lblId.Click += this.label1_Click;
        // 
        // ShippingOrderView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.centre);
        this.Controls.Add(this.lastPanel);
        this.Controls.Add(this.TopPanel);
        this.MinimumSize = new Size(450, 500);
        this.Name = "ShippingOrderView";
        this.Text = "ShippingOrderView";
        this.lastPanel.ResumeLayout(false);
        this.centre.ResumeLayout(false);
        this.centre.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel TopPanel;
    private Panel lastPanel;
    private TableLayoutPanel centre;
    private Button btnAction;
    private Button btnAnnuler;
    private Label lblId;
}