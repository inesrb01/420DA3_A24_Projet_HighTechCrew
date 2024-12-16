namespace _420DA3_A24_Projet.Business.Domain;

// TODO @DRISS: rendre la classe public et non internal : ==> Done
public class User {

    #region Fields
    // Constants for maximum lengths
    public const int UsernameMaxLength = 64;
    public const int PasswordHashMaxLength = 128;

    private string username = null!;
    private string? passwordHash = null;
    #endregion

    #region Properties
    public int Id { get; set; }
    public string Username {
        get { return this.username; }
        set {
            // TODO @DRISS: utiliser les méthodes de validation dans le if ici au lieu de refaire une check identique : ==> Done
            if (!ValidateUsername(value)) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {UsernameMaxLength} caractères.");
            }
            this.username = value;
        }
    }
    public string? PasswordHash {
        get { return this.passwordHash; }
        set {
            if (!ValidatePasswordHash(value!)) { // ==> Done
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {PasswordHashMaxLength} caractères.");
            }
            this.passwordHash = value;
        }
    }
    public int? EmployeeWarehouseId { get; set; } // Nullable for optional warehouse assignment
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateDeleted { get; set; } // Nullable for optional values
    public DateTime? DateModified { get; set; } // Nullable for optional values
    public byte[]? RowVersion { get; set; } = null!;

    // TODO @DRISS: Ajouter le modificateur 'virtual' aux propriétés de navigation : ==>  Done
    public virtual List<Role> Roles { get; set; } = new List<Role>(); // Association with Role class
    public virtual List<ShippingOrder> CreatedShipOrders { get; set; } = new List<ShippingOrder>(); // Association with ShippingOrder class
    public virtual List<ShippingOrder> FulfilledShipOrders { get; set; } = new List<ShippingOrder>(); // Association with ShippingOrder class
    public virtual Warehouse EmployeeWarehouse { get; set; } // Association with Warehouse class 
    #endregion

    #region Constructors
    public User(int id, string username, string passwordHash) {


        this.Id = id;
        this.Username = username;
        this.PasswordHash = passwordHash;
        this.DateCreated = DateTime.Now; // TODO @DRISS: supprimer. Devrait être géré automatiquement par la BdD :  ==> Done ( check DbContext )
    }
    public User() {

    }


    protected User(
    int id,
    string username,
    string passwordHash,
    int? employeeWarehouseId,
    DateTime dateCreated,
    DateTime? dateModified,
    DateTime? dateDeleted,
    byte[] rowVersion
    ) : this(username, passwordHash)  // Chaining to another constructor
    {
        this.Id = id;
        this.EmployeeWarehouseId = employeeWarehouseId;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    public User(string username, string passwordHash) {
        this.username = username;
        this.passwordHash = passwordHash;
    }


    #endregion

    #region Methods
    public static bool ValidateUsername(string username) {
        return !string.IsNullOrEmpty(username) && username.Length <= UsernameMaxLength;
    }

    public static bool ValidatePasswordHash(string passwordHash) {
        return !string.IsNullOrEmpty(passwordHash) && passwordHash.Length <= PasswordHashMaxLength;
    }

    public bool IsAdministrator() {
        return this.Roles.Exists(role => {
            return role.Id == Role.AdminRoleId;
        });
    }

    public bool IsOfficeEmployee() {
        return this.Roles.Exists(role => {
            return role.Id == Role.OfficeEmployeeRoleId;
        });
    }

    public bool IsWarehouseEmployee() {
        return this.Roles.Exists(role => {
            return role.Id == Role.WhEmployeeRoleId;
        });
    }

    // Done
    // TODO @DRISS: Suggestion: supprimer, inutile. vous pouvez déja juste assigner un objet warehouse à la propriété
    // publique. Pas besoin de setter son id dans la propriété EmployeeWarehouseId, EF Core va gérer tout ça.
    public void AssignWarehouse(Warehouse warehouse) {
        this.EmployeeWarehouse = warehouse;
        this.EmployeeWarehouseId = warehouse?.Id;
        this.DateModified = DateTime.Now; // TODO @DRISS: supprimer. Le set de date de modification devrait se faire dans le DAO
    }
    #endregion
}