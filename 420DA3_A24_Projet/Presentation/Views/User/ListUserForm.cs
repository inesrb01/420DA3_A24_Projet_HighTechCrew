using _420DA3_A24_Projet.Business.Services.Implementations;
using M = _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation.Views.Forms.User;
public partial class ListUserForm : Form {

    private readonly UserService userService;
    private readonly WarehouseService warehouseService;
    private readonly RoleService roleService;

    public ListUserForm(UserService userService, WarehouseService warehouseService, RoleService roleService) {

        this.InitializeComponent();
        this.userService = userService;
        this.warehouseService = warehouseService;
        this.roleService = roleService;
    }

    private async void PopulateUsersDataGridView(string pattern) {
        IList<M.User> users = await userService.SearchAsync(pattern);

        this.dgvUsers.Columns.Clear();
        this.dgvUsers.Rows.Clear();

        this.dgvUsers.Columns.Add("Id", "ID");
        this.dgvUsers.Columns.Add("UserName", "UserName");
        this.dgvUsers.Columns.Add("CreatedAt", "CreatedAt");
        this.dgvUsers.Columns.Add("Roles", "Roles");

        foreach (M.User user in users) {
            string roles = string.Join(", ", user.Roles.Select(role => {
                return role.RoleName;
            }));
            dgvUsers.Rows.Add(user.Id, user.Username, user.DateCreated, roles);
        }
    }

    private void ButtonClose_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void ListUserForm_Load(object sender, EventArgs e) {
        this.PopulateUsersDataGridView(string.Empty);
    }

    private void ButtonNewUser_Click(object sender, EventArgs e) {
        CreateUserForm createUserForm = new(warehouseService, roleService, userService);
        createUserForm.ShowDialog();
        this.PopulateUsersDataGridView(string.Empty);
    }

    private void ButtonEditUser_Click(object sender, EventArgs e) {
        if (this.dgvUsers.CurrentRow != null) {
            int index = this.dgvUsers.CurrentRow!.Index;
            int userId = int.Parse(this.dgvUsers.Rows[index].Cells[0].Value!.ToString()!);
            UpdateUserForm updateUserForm = new UpdateUserForm(warehouseService, roleService, userService, userId);
            updateUserForm.ShowDialog();
            this.PopulateUsersDataGridView(string.Empty);
        }
    }

    private void ButtonSearch_Click(object sender, EventArgs e) {
        if (!string.IsNullOrEmpty(this.textBoxSearchUserName.Text)) {
            this.PopulateUsersDataGridView(this.textBoxSearchUserName.Text);
        }
        else {
            // Refresh
            this.PopulateUsersDataGridView(string.Empty);
        }
    }

    private async void ButtonDeleteUser_Click(object sender, EventArgs e) {

        DialogResult result = MessageBox.Show("Confirmation ? ", "Controle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes) {

            int index = this.dgvUsers.CurrentRow!.Index;
            int userId = int.Parse(this.dgvUsers.Rows[index].Cells[0].Value!.ToString()!);

            M.User? searchUser = await userService.GetByIdAsync(userId);
            if (searchUser == null) {

                _ = MessageBox.Show("User Not Found");
                return;
            }
            await userService.DeleteAsync(searchUser);
            this.PopulateUsersDataGridView(string.Empty);
            _ = MessageBox.Show("User Deleted");
        }
    }
}