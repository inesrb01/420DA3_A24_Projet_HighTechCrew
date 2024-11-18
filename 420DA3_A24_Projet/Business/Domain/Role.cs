using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
 internal class Role {
    // Constants for predefined role IDs and property constraints
    public const int AdminRoleId = 1;
    public const int OfficeEmployeeRoleId = 2;
    public const int WhEmployeeRoleId = 3;
    public const int RoleNameMaxLength = 64;
    public const int RoleDescriptionMaxLength = 255;


    private string roleName = null!;
    private string roleDescription = null!;


    // Properties
    public int Id { get; set; }
    public string RoleName 
        {
        get { return this.roleName; }
        set {
            if (value.Length > RoleNameMaxLength) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {RoleNameMaxLength} caractères.");
            }
            this.roleName = value;
        }
    }
    public string RoleDescription {
        get { return this.roleDescription; }
        set {
            if (value.Length > RoleDescriptionMaxLength) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {RoleDescriptionMaxLength} caractères.");
            }
            this.roleDescription = value;
        }
    }

    
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; } // Nullable for optional values
    public DateTime? DateModified { get; set; } // Nullable for optional values
    public byte[] RowVersion { get; set; } = null!;
    public List<User> Users { get; set; } = new List<User>(); // Association with User class


    // Constructors
    public Role(int id, string roleName, string roleDescription) {
        if (!ValidateRoleName(roleName))
            throw new ArgumentException("Role name exceeds the maximum length.");
        if (!ValidateRoleDescription(roleDescription))
            throw new ArgumentException("Role description exceeds the maximum length.");

        Id = id;
        RoleName = roleName;
        RoleDescription = roleDescription;
        DateCreated = DateTime.Now; // Set creation date to current time
    }


    protected Role(
    int id,
    string roleName,
    string roleDescription,
    int? employeeWarehouseId,
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

    // Methods
    public static bool ValidateRoleName(string roleName) {
        return !string.IsNullOrEmpty(roleName) && roleName.Length <= RoleNameMaxLength;
    }

    public static bool ValidateRoleDescription(string roleDescription) {
        return !string.IsNullOrEmpty(roleDescription) && roleDescription.Length <= RoleDescriptionMaxLength;
    }


   
}
