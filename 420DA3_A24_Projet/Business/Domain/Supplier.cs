using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Product;

namespace _420DA3_A24_Projet.Business.Domain;

// TODO @AKRAM: rendre la classe public et non internal
public class Supplier {
   
    public const int SupplierNameMaxLength = 128;
    public const int ContactTelephoneMaxLength = 15;
    public const int ContactEmailMaxLength = 128;
    public const int ContactLastNameMaxLength = 32;
    public const int ContactFirstNameMaxLength = 32;

   
    public int Id { get; set; }
    public string SupplierName { get; set; } 
    public string ContactLastName { get; set; }
    public string ContactFirstName { get; set; }
    public string ContactEmail { get; set; }
    public string ContactTelephone { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    public virtual List<Product> Products { get; set; } = new();



    public byte[] RowVersion { get; set; }




    public Supplier() { } 

    public Supplier(string supplierName, string contactFirstName, string contactLastName, string contactEmail, string contactTelephone) {
        if (!ValidateSupplierName(supplierName))
            throw new ArgumentException("Invalid supplier name.");
        if (!ValidateContactFirstName(contactFirstName))
            throw new ArgumentException("Invalid contact first name.");
        if (!ValidateContactLastName(contactLastName))
            throw new ArgumentException("Invalid contact last name.");
        if (!ValidateContactEmail(contactEmail))
            throw new ArgumentException("Invalid contact email.");
        if (!ValidateContactTelephone(contactTelephone))
            throw new ArgumentException("Invalid contact telephone.");

        SupplierName = supplierName;
        ContactFirstName = contactFirstName;
        ContactLastName = contactLastName;
        ContactEmail = contactEmail;
        ContactTelephone = contactTelephone;
    }

 
    public bool ValidateSupplierName(string name) {
        return !string.IsNullOrWhiteSpace(name) && name.Length <= SupplierNameMaxLength;
    }

    public bool ValidateContactFirstName(string firstName) {
        return !string.IsNullOrWhiteSpace(firstName) && firstName.Length <= ContactFirstNameMaxLength;
    }

    public bool ValidateContactLastName(string lastName) {
        return !string.IsNullOrWhiteSpace(lastName) && lastName.Length <= ContactLastNameMaxLength;
    }

    public bool ValidateContactEmail(string email) {
        return !string.IsNullOrWhiteSpace(email) && email.Length <= ContactEmailMaxLength;
    }

    public bool ValidateContactTelephone(string telephone) {
        return !string.IsNullOrWhiteSpace(telephone) && telephone.Length <= ContactTelephoneMaxLength;
    }

    
    public void UpdateContactInfo(string email, string telephone) {
        if (!ValidateContactEmail(email))
            throw new ArgumentException("Invalid email.");
        if (!ValidateContactTelephone(telephone))
            throw new ArgumentException("Invalid telephone.");

        ContactEmail = email;
        ContactTelephone = telephone;
        DateModified = DateTime.Now;
    }

    public bool IsActive() {
        return DateDeleted == null;
    }

    public void Deactivate() {
        DateDeleted = DateTime.Now;
    }

    public void Reactivate() {
        DateDeleted = null;
    }

}

