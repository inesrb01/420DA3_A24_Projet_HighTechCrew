namespace _420DA3_A24_Projet.Business.Domain;

// TODO @DRISS: rendre la classe public et non internal : ==> Done
public class Role {

    #region Fields
    // Constants for predefined role IDs and property constraints
    public const int AdminRoleId = 1;
    public const int OfficeEmployeeRoleId = 2;
    public const int WhEmployeeRoleId = 3;
    public const int RoleNameMaxLength = 64;
    public const int RoleDescriptionMaxLength = 255;


    private string roleName = null!;
    private string roleDescription = null!;

    #endregion

    #region Properties
    public int Id { get; set; }
    public string RoleName {
        get { return this.roleName; }
        set {
            if (!ValidateRoleName(value)) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {RoleNameMaxLength} caractères.");
            }
            this.roleName = value;
        }
    }
    public string RoleDescription {
        get { return this.roleDescription; }
        set {
            if (!ValidateRoleDescription(value)) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {RoleDescriptionMaxLength} caractères.");
            }
            this.roleDescription = value;
        }
    }


    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; } // Nullable for optional values
    public DateTime? DateModified { get; set; } // Nullable for optional values
    public byte[]? RowVersion { get; set; }

    // TODO @DRISS: Attention d'ajouter le modificateur 'virtual' aux propriétés de navigation :  ==> Done
    public virtual List<User> Users { get; set; } = new List<User>(); // Association with User class

    #endregion

    #region Constructors
    public Role(int id, string roleName, string roleDescription) {
        // TODO @DRISS: Utiliser les méthodes de validation directement dans le 'set' des propriétés. : ==> Done
        this.Id = id;
        this.RoleName = roleName;
        this.RoleDescription = roleDescription;
        /*  this.DateCreated = DateTime.Now;*/ // TODO @DRISS: supprimer. Devrait être géré automatiquement par la BdD : ==> Done
    }


    protected Role(
    int id,
    string roleName,
    string roleDescription,
    DateTime dateCreated,
    DateTime? dateModified,
    DateTime? dateDeleted,
    byte[] rowVersion
    ) : this(roleName, roleDescription)  // Chaining to another constructor
    {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    public Role(string roleName, string roleDescription) {
        this.roleName = roleName;
        this.roleDescription = roleDescription;
    }
    #endregion

    #region Methods
    public static bool ValidateRoleName(string roleName) {
        return !string.IsNullOrEmpty(roleName) && roleName.Length <= RoleNameMaxLength;
    }

    public static bool ValidateRoleDescription(string roleDescription) {
        return !string.IsNullOrEmpty(roleDescription) && roleDescription.Length <= RoleDescriptionMaxLength;
    }
    #endregion
}