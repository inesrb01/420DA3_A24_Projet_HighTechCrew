using _420DA3_A24_Projet.Business.Services;

namespace _420DA3_A24_Projet.Presentation.Views;

partial class SupplierView {
    private readonly SupplierService _supplierService;

   

    private void SupplierView_Load(object sender, EventArgs e) {
        LoadSuppliers();
    }

   
    private void LoadSuppliers() {
        var suppliers = _supplierService.GetAll();
        supplierDataGridView.DataSource = suppliers.Select(s => new
        {
            s.Id,
            s.SupplierName,
            s.ContactFirstName,
            s.ContactLastName,
            s.ContactEmail,
            s.ContactTelephone,
            ProductCount = s.Products.Count
        }).ToList();
    }

   

    private void btnEditSupplier_Click(object sender, EventArgs e) {
        if (supplierDataGridView.SelectedRows.Count > 0) {
            var id = (int) supplierDataGridView.SelectedRows[0].Cells["Id"].Value;
            var supplier = _supplierService.GetById(id);
        }
    }

    private void btnDeleteSupplier_Click(object sender, EventArgs e) {
        if (supplierDataGridView.SelectedRows.Count > 0) {
            var id = (int) supplierDataGridView.SelectedRows[0].Cells["Id"].Value;
            var confirm = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce fournisseur ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                _supplierService.Delete(id);
                LoadSuppliers();
            }
        } else {
            MessageBox.Show("Veuillez sélectionner un fournisseur.");
        }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
        var filter = txtSearch.Text;
        var suppliers = _supplierService.Search(filter);
        supplierDataGridView.DataSource = suppliers.Select(s => new
        {
            s.Id,
            s.SupplierName,
            s.ContactFirstName,
            s.ContactLastName,
            s.ContactEmail,
            s.ContactTelephone,
            ProductCount = s.Products.Count
        }).ToList();
    }

    private DataGridView supplierDataGridView;
    private Button btnAddSupplier;
    private Button btnEditSupplier;
    private Button btnDeleteSupplier;
    private Button btnSearch;
    private TextBox txtSearch;
    private Label lblSearch;
}