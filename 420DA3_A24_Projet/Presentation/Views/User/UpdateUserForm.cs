using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services.Implementations;
using M = _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation.Views.Forms.User;

public partial class UpdateUserForm : Form {
    private readonly WarehouseService warehouseService;
    private readonly RoleService roleService;
    private readonly UserService userService;
    int userId;

    public UpdateUserForm(WarehouseService warehouseService, RoleService roleService, UserService userService, int userId) {
        this.InitializeComponent();
        this.warehouseService = warehouseService;
        this.roleService = roleService;
        this.userService = userService;
        this.userId = userId;
    }

    private async void UpdateUserForm_Load(object sender, EventArgs e) {
        M.User? searchUser = await userService.GetByIdAsync(userId);
        if (searchUser == null) {

            _ = MessageBox.Show("User Not Found");
            return;
        }

        int selctedIndexWarehouseId = 0;

        IList<Warehouse> listeWarehouse = await warehouseService.GetAllAsync();
        foreach (Warehouse warehouse in listeWarehouse) {
            if (warehouse.entrepotID == searchUser.EmployeeWarehouseId) {
                selctedIndexWarehouseId = listeWarehouse.IndexOf(warehouse);
            }
            _ = this.cmbWarehouseList.Items.Add(warehouse.entrepotID + "-" + warehouse.Nom);
        }

        IList<Role> listeRole = await roleService.SearchAsync(string.Empty);
        foreach (Role role in listeRole) {
            _ = this.listViewRole.Items.Add(role.Id + "-" + role.RoleName);
        }

        this.textBoxUserId.Text = this.userId.ToString();
        this.textBoxOldRoles.Text = string.Join(", ", searchUser.Roles.Select(role => {
            return role.RoleName;
        }));
        this.textBoxUserName.Text = searchUser.Username;

        cmbWarehouseList.SelectedIndex = selctedIndexWarehouseId;
    }

    private async void ButtonUpdateUser_Click(object sender, EventArgs e) {
        // Validation des champs
        if (string.IsNullOrWhiteSpace(textBoxUserName.Text)) {
            MessageBox.Show("Le nom d'utilisateur est requis.");
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

        M.User? searchUser = await userService.GetByIdAsync(userId);
        if (searchUser == null) {

            _ = MessageBox.Show("User Not Found");
            return;
        }

        searchUser.Username = textBoxUserName.Text;
        searchUser.EmployeeWarehouseId = int.Parse(warehouseId);

        try {
            // Appel à un service pour créer l'utilisateur
            M.User result = await userService.UpdateAsync(searchUser, textBoxPassword.Text);
            await userService.RemoveAllRoleAsync(result);
            foreach (int role in selectedRoles) {
                await userService.SetRoleAsync(role, searchUser);
            }
            MessageBox.Show("L'utilisateur a été modifié avec succès.");

        } catch (Exception ex) {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }
}
