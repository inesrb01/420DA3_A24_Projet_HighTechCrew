
using _420DA3_A24_Projet.Presentation.Views.Forms.User;
using _420DA3_A24_Projet.Business.Services.Implementations;

namespace _420DA3_A24_Projet.Presentation.Views.Forms;
public partial class MenuForm : Form {
    private readonly UserService userService;
    private readonly WarehouseService warehouseService;
    private readonly RoleService roleService;

    public MenuForm(UserService userService, WarehouseService warehouseService, RoleService roleService) {
        this.InitializeComponent();
        this.userService = userService;
        this.warehouseService = warehouseService;
        this.roleService = roleService;
    }

    private void listUsersToolStripMenuItem_Click(object sender, EventArgs e) {
        ListUserForm listUserForm = new(userService, warehouseService, roleService);
        listUserForm.MdiParent = this;
        listUserForm.Show();
    }

    private void MenuForm_Load(object sender, EventArgs e) {

    }
}
