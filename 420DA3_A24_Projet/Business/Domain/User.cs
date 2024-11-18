using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class User {
    // Constants for maximum lengths
    public const int UsernameMaxLength = 64;
    public const int PasswordHashMaxLength = 128;



    private string username = null!;
    public string passwordHash = null;


    // Properties
    public int Id { get; set; }
    public string Username {
        get { return this.username; }
        set {
            if (value.Length > UsernameMaxLength) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {UsernameMaxLength} caractères.");
            }
            this.username = value;
        }
    }
    public string PasswordHash {
        get { return this.passwordHash; }
        set {
            if (value.Length > PasswordHashMaxLength) {
                throw new ArgumentException($"Le nom d'utlisateur ne peut pas dépasser {PasswordHashMaxLength} caractères.");
            }
            this.passwordHash = value;
        }
    }
    public int? EmployeeWarehouseId { get; set; } // Nullable for optional warehouse assignment
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; } // Nullable for optional values
    public DateTime? DateModified { get; set; } // Nullable for optional values
    public byte[] RowVersion { get; set; } = null!;

    public List<Role> Roles { get; set; } = new List<Role>(); // Association with Role class
    public List<ShippingOrder> CreatedShipOrders { get; set; } = new List<ShippingOrder>(); // Association with ShippingOrder class
    public List<ShippingOrder> FulfilledShipOrders { get; set; } = new List<ShippingOrder>(); // Association with ShippingOrder class
    public Warehouse EmployeeWarehouse { get; set; } // Association with Warehouse class

    
    
    // Constructors
    public User(int id, string username, string passwordHash) {


        this.Id = id;
        this.Username = username;
        this.PasswordHash = passwordHash;
        this.DateCreated = DateTime.Now; // Set creation date to current time
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



    // Methods
    public static bool ValidateUsername(string username) {
        return !string.IsNullOrEmpty(username) && username.Length <= UsernameMaxLength;
    }

    public static bool ValidatePasswordHash(string passwordHash) {
        return !string.IsNullOrEmpty(passwordHash) && passwordHash.Length <= PasswordHashMaxLength;
    }

    public bool IsAdministrator() {
        return Roles.Exists(role => role.Id == Role.AdminRoleId);
    }

    public bool IsOfficeEmployee() {
        return Roles.Exists(role => role.Id == Role.OfficeEmployeeRoleId);
    }

    public bool IsWarehouseEmployee() {
        return Roles.Exists(role => role.Id == Role.WhEmployeeRoleId);
    }

    public void AssignWarehouse(Warehouse warehouse) {
        EmployeeWarehouse = warehouse;
        EmployeeWarehouseId = warehouse?.Id;
        DateModified = DateTime.Now; // Track changes
    }

    public void UpdateUser(string newUsername = null, string newPasswordHash = null) {
        if (!string.IsNullOrEmpty(newUsername)) {
            if (!ValidateUsername(newUsername))
                throw new ArgumentException("Invalid username. It must not exceed the maximum length.");
            Username = newUsername;
        }

        if (!string.IsNullOrEmpty(newPasswordHash)) {
            if (!ValidatePasswordHash(newPasswordHash))
                throw new ArgumentException("Invalid password hash. It must not exceed the maximum length.");
            PasswordHash = newPasswordHash;
        }

        if (newUsername != null || newPasswordHash != null) {
            DateModified = DateTime.Now; // Update the modification timestamp
        }
    }

    public void MarkAsDeleted() {
        DateDeleted = DateTime.Now; // Set deletion date to current time
    }

    public class Warehouse {
        public int Id { get; set; }
        public string Location { get; set; }
    }
}
