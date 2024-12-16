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
public partial class ProductView : Form {
    public ProductView() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        this.productDataGridView = new DataGridView();
        this.btnAddProduct = new Button();
        this.btnEditProduct = new Button();
        this.button1 = new Button();
        this.btnSearch = new Button();
        this.txtSearch = new TextBox();
        this.lblSearch = new Label();
        ((ISupportInitialize) this.productDataGridView).BeginInit();
        this.SuspendLayout();
        // 
        // productDataGridView
        // 
        this.productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.productDataGridView.Location = new Point(194, 37);
        this.productDataGridView.Name = "productDataGridView";
        this.productDataGridView.RowHeadersWidth = 62;
        this.productDataGridView.RowTemplate.Height = 33;
        this.productDataGridView.Size = new Size(710, 225);
        this.productDataGridView.TabIndex = 0;
        this.productDataGridView.CellContentClick += this.productDataGridView_CellContentClick;
        // 
        // btnAddProduct
        // 
        this.btnAddProduct.Location = new Point(131, 306);
        this.btnAddProduct.Name = "btnAddProduct";
        this.btnAddProduct.Size = new Size(136, 34);
        this.btnAddProduct.TabIndex = 1;
        this.btnAddProduct.Text = "addProduct";
        this.btnAddProduct.UseVisualStyleBackColor = true;
        this.btnAddProduct.Click += this.btnAddProduct_Click;
        // 
        // btnEditProduct
        // 
        this.btnEditProduct.Location = new Point(330, 306);
        this.btnEditProduct.Name = "btnEditProduct";
        this.btnEditProduct.Size = new Size(136, 34);
        this.btnEditProduct.TabIndex = 2;
        this.btnEditProduct.Text = "EditProduct";
        this.btnEditProduct.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        this.button1.Location = new Point(514, 306);
        this.button1.Name = "button1";
        this.button1.Size = new Size(136, 34);
        this.button1.TabIndex = 3;
        this.button1.Text = "EditProduct";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new Point(712, 306);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new Size(136, 34);
        this.btnSearch.TabIndex = 4;
        this.btnSearch.Text = "SearchProduct";
        this.btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new Point(231, 472);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new Size(396, 31);
        this.txtSearch.TabIndex = 5;
        // 
        // lblSearch
        // 
        this.lblSearch.AutoSize = true;
        this.lblSearch.Location = new Point(170, 475);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new Size(64, 25);
        this.lblSearch.TabIndex = 6;
        this.lblSearch.Text = "Search";
        // 
        // ProductView
        // 
        this.ClientSize = new Size(1141, 600);
        this.Controls.Add(this.lblSearch);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.btnEditProduct);
        this.Controls.Add(this.btnAddProduct);
        this.Controls.Add(this.productDataGridView);
        this.Name = "ProductView";
        ((ISupportInitialize) this.productDataGridView).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void btnAddProduct_Click(object sender, EventArgs e) {

    }
}
