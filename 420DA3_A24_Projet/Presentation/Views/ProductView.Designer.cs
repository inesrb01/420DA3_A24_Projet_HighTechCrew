using _420DA3_A24_Projet.Business.Services;

namespace _420DA3_A24_Projet.Presentation.Views;

partial class ProductView {
    private readonly ProductService _productService;

   

    private void ProductView_Load(object sender, EventArgs e) {
        LoadProducts();
    }

   
    private void LoadProducts() {
        var products = _productService.GetAll();
        productDataGridView.DataSource = products.Select(p => new
        {
            p.Id,
            p.ProductName,
            p.UpcCode,
            p.InStockQty,
            p.DesiredQty,
            SupplierName = p.Supplier?.SupplierName
        }).ToList();
    }

   

    private void btnEditProduct_Click(object sender, EventArgs e) {
        if (productDataGridView.SelectedRows.Count > 0) {
            var id = (int) productDataGridView.SelectedRows[0].Cells["Id"].Value;
            var product = _productService.GetById(id);
        }
    }

    private void btnDeleteProduct_Click(object sender, EventArgs e) {
        if (productDataGridView.SelectedRows.Count > 0) {
            var id = (int) productDataGridView.SelectedRows[0].Cells["Id"].Value;
            var confirm = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                _productService.Delete(id);
                LoadProducts();
            }
        } else {
            MessageBox.Show("Veuillez sélectionner un produit.");
        }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
        var filter = txtSearch.Text;
        var products = _productService.Search(filter);
        productDataGridView.DataSource = products.Select(p => new
        {
            p.Id,
            p.ProductName,
            p.UpcCode,
            p.InStockQty,
            p.DesiredQty,
            SupplierName = p.Supplier?.SupplierName
        }).ToList(); 
    }

    private DataGridView productDataGridView;
    private Button btnAddProduct;
    private Button btnEditProduct;
    private Button button1;
    private Button btnSearch;
    private TextBox txtSearch;
    private Label lblSearch;
}