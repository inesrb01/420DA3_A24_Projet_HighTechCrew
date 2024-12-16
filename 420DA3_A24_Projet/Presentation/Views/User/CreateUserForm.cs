using _420DA3_A24_Projet.Business.Domain;
using M = _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services.Implementations;


namespace _420DA3_A24_Projet.Presentation.Views.Forms.User;
public partial class CreateUserForm : Form {

    private readonly WarehouseService warehouseService;
    private readonly RoleService roleService;
    private readonly UserService userService;

    public CreateUserForm(WarehouseService warehouseService, RoleService roleService, UserService userService) {
        this.InitializeComponent();
        this.warehouseService = warehouseService;
        this.roleService = roleService;
        this.userService = userService;
    }

    private async void CreateUserForm_Load(object sender, EventArgs e) {

        IList<Warehouse> listeWarehouse = await warehouseService.GetAllAsync();
        foreach (Warehouse warehouse in listeWarehouse) {
            _ = this.cmbWarehouseList.Items.Add(warehouse.entrepotID + "-" + warehouse.Nom);
        }

        IList<Role> listeRole = await roleService.SearchAsync(string.Empty);
        foreach (Role role in listeRole) {
            _ = this.listViewRole.Items.Add(role.Id + "-" + role.RoleName);
        }
    }

    private void ResetForm() {
        textBoxUserName.Clear();
        textBoxPassword.Clear();
        textBoxConfirmPassword.Clear();
        cmbWarehouseList.SelectedIndex = -1;
        textBoxUserName.Focus();
    }

    private async void ButtonCreateUser_Click(object sender, EventArgs e) {
        // Validation des champs
        if (string.IsNullOrWhiteSpace(textBoxUserName.Text)) {
            MessageBox.Show("Le nom d'utilisateur est requis.");
            return;
        }

        if (string.IsNullOrWhiteSpace(textBoxPassword.Text)) {
            MessageBox.Show("Le mot de passe est requis.");
            return;
        }

        if (textBoxPassword.Text != textBoxConfirmPassword.Text) {
            MessageBox.Show("Les mots de passe ne correspondent pas.");
            return;
        }

        // Vérification que l'utilisateur a sélectionné au moins un rôle
        if (listViewRole.SelectedItems.Count == 0) {
            MessageBox.Show("Vous devez sélectionner au moins un rôle.");
            return;
        }

        // Vérification que l'utilisateur a sélectionné un entrepôt
        if (cmbWarehouseList.SelectedItem == null) {
            MessageBox.Show("Vous devez sélectionner un entrepôt.");
            return;
        }

        // Récupération des rôles sélectionnés
        List<int> selectedRoles = new List<int>();
        foreach (ListViewItem item in listViewRole.SelectedItems) {
            selectedRoles.Add(int.Parse(item.Text.Split('-')[0].Trim()));
        }

        // Récupération de l'ID de l'entrepôt sélectionné
        string selectedWarehouse = cmbWarehouseList.SelectedItem.ToString()!;
        string warehouseId = selectedWarehouse.Split('-')[0].Trim();

        // Création du modèle d'utilisateur
        M.User newUser = new M.User();
        newUser.Username = textBoxUserName.Text;
        newUser.EmployeeWarehouseId = int.Parse(warehouseId);

        try {
            // Appel à un service pour créer l'utilisateur
            M.User result = await userService.CreateAsync(newUser, textBoxPassword.Text);
            foreach (int roleId in selectedRoles) {
                await userService.SetRoleAsync(roleId, newUser);
            }
            MessageBox.Show("L'utilisateur a été créé avec succès.");
            this.ResetForm();

        } catch (Exception ex) {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }
}
