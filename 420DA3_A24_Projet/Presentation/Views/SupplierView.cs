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
public partial class SupplierView : Form {
    public SupplierView() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        this.supplierDataGridView = new DataGridView();
        this.btnAddSupplier = new Button();
        this.btnEditSupplier = new Button();
        this.btnDeleteSupplier = new Button();
        this.btnSearch = new Button();
        this.txtSearch = new TextBox();
        this.lblSearch = new Label();
        ((ISupportInitialize) this.supplierDataGridView).BeginInit();
        this.SuspendLayout();
        // 
        // supplierDataGridView
        // 
        this.supplierDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.supplierDataGridView.Location = new Point(172, 29);
        this.supplierDataGridView.Name = "supplierDataGridView";
        this.supplierDataGridView.RowHeadersWidth = 62;
        this.supplierDataGridView.RowTemplate.Height = 33;
        this.supplierDataGridView.Size = new Size(840, 225);
        this.supplierDataGridView.TabIndex = 0;
        // 
        // btnAddSupplier
        // 
        this.btnAddSupplier.Location = new Point(172, 314);
        this.btnAddSupplier.Name = "btnAddSupplier";
        this.btnAddSupplier.Size = new Size(151, 34);
        this.btnAddSupplier.TabIndex = 1;
        this.btnAddSupplier.Text = "AddSupplier";
        this.btnAddSupplier.UseVisualStyleBackColor = true;
        // 
        // btnEditSupplier
        // 
        this.btnEditSupplier.Location = new Point(410, 314);
        this.btnEditSupplier.Name = "btnEditSupplier";
        this.btnEditSupplier.Size = new Size(151, 34);
        this.btnEditSupplier.TabIndex = 2;
        this.btnEditSupplier.Text = "EditSupplier";
        this.btnEditSupplier.UseVisualStyleBackColor = true;
        // 
        // btnDeleteSupplier
        // 
        this.btnDeleteSupplier.Location = new Point(626, 314);
        this.btnDeleteSupplier.Name = "btnDeleteSupplier";
        this.btnDeleteSupplier.Size = new Size(151, 34);
        this.btnDeleteSupplier.TabIndex = 3;
        this.btnDeleteSupplier.Text = "DeleteSupplier";
        this.btnDeleteSupplier.UseVisualStyleBackColor = true;
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new Point(845, 314);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new Size(151, 34);
        this.btnSearch.TabIndex = 4;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new Point(242, 467);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new Size(691, 31);
        this.txtSearch.TabIndex = 5;
        // 
        // lblSearch
        // 
        this.lblSearch.AutoSize = true;
        this.lblSearch.Location = new Point(172, 467);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new Size(64, 25);
        this.lblSearch.TabIndex = 6;
        this.lblSearch.Text = "Search";
        // 
        // SupplierView
        // 
        this.ClientSize = new Size(1214, 596);
        this.Controls.Add(this.lblSearch);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.btnDeleteSupplier);
        this.Controls.Add(this.btnEditSupplier);
        this.Controls.Add(this.btnAddSupplier);
        this.Controls.Add(this.supplierDataGridView);
        this.Name = "SupplierView";
        ((ISupportInitialize) this.supplierDataGridView).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
