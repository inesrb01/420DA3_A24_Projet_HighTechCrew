using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Address {

    public const int ADDRESSEE_MAX_LENGTH = 64;
    public const int CIVICNUMBER_MAX_LENGTH = 6;
    public const int STREET_MAX_LENGTH = 128;
    public const int CITY_MAX_LENGTH = 64;
    public const int STATE_MAX_LENGTH = 64;
    public const int COUNTRY_MAX_LENGTH = 64;
    public const int POSTALCODE_MAX_LENGTH = 12;

    private string addressee = null!;
    private string civicNumber = null;
    private string street = null!;
    private string city = null!;
    private string state = null!;
    private string country = null!;
    private string postalCode = null!;

    public int Id { get; set; }

    public string Addressee {
        get { return this.addressee; }
        set {
            if (value.Length > ADDRESSEE_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du destinataire ne peut pas dépasser {ADDRESSEE_MAX_LENGTH} caractères.");
            }
            this.addressee = value;
        }
    }

    public string CivicNumber {
        get { return this.civicNumber; }
        set {
            if (value.Length > CIVICNUMBER_MAX_LENGTH) {
                throw new ArgumentException($"Le numéro civique ne peut pas dépasser {CIVICNUMBER_MAX_LENGTH} caractères.");
            }
            this.civicNumber = value;
        }
    }

    public string Street {
        get { return this.street; }
        set {
            if (value.Length > STREET_MAX_LENGTH) {
                throw new ArgumentException($"Le nom de la rue ne peut pas dépasser {STREET_MAX_LENGTH} caractères.");
            }
            this.street = value;
        }
    }

    public string City {
        get { return this.city; }
        set {
            if (value.Length > CITY_MAX_LENGTH) {
                throw new ArgumentException($"Le nom de la ville ne peut pas dépasser {CITY_MAX_LENGTH} caractères.");
            }
            this.city = value;
        }
    }

    public string State {
        get { return this.state; }
        set {
            if (value.Length > STATE_MAX_LENGTH) {
                throw new ArgumentException($"Le nom de l'état ne peut pas dépasser {STATE_MAX_LENGTH} caractères.");
            }
            this.state = value;
        }
    }

    public string Country {
        get { return this.country; }
        set {
            if (value.Length > COUNTRY_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du pays ne peut pas dépasser {COUNTRY_MAX_LENGTH} caractères.");
            }
            this.country = value;
        }
    }

    public string PostalCode {
        get { return this.postalCode; }
        set {
            if (value.Length > POSTALCODE_MAX_LENGTH) {
                throw new ArgumentException($"Le code postal ne doit pas depacer {POSTALCODE_MAX_LENGTH} caracteres");
            }
            this.postalCode = value;
        }
    }


    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }


    public Address(string addressee, string civicNumber, string street, string city, string state, string country, string postalCode) {
        this.Addressee = addressee;
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.State = state;
        this.Country = country;
        this.PostalCode = postalCode;
    }


    // Constructeur utilisé par Entity Framework
    protected Address(int id, string addressee, string civicNumber, string street, string city, string state, string country, string postalCode, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted)
        : this(addressee, civicNumber, street, city, state, country, postalCode) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
    }

    // Méthodes de validation
    public static bool ValidateCivicNumber(string civicNumber) => (civicNumber.Length <= CIVICNUMBER_MAX_LENGTH);
    public static bool ValidateStreet(string street) => street.Length <= STREET_MAX_LENGTH;
    public static bool ValidateCity(string city) => city.Length <= CITY_MAX_LENGTH;
    public static bool ValidateState(string state) => state.Length <= STATE_MAX_LENGTH;
    public static bool ValidateCountry(string country) => country.Length <= COUNTRY_MAX_LENGTH;
    public static bool ValidatePostalCode(string postalCode) => postalCode.Length <= POSTALCODE_MAX_LENGTH;

    // Override de ToString
    public override string ToString() {
        return $"#{this.Id} - {this.Addressee}, {this.CivicNumber} {this.Street}, {this.City}, {this.State}, {this.Country}, {this.PostalCode}";
    }

}
