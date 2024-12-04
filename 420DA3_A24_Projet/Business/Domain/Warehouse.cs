using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Product;

namespace _420DA3_A24_Projet.Business.Domain;

// TODO @INES: renommer les classes et propriétés pour respecter les conventions de casse C# (PascalCase)
// TODO @INES: Les noms de classes ne devraient pas être au pluriel
// TODO @INES: rendre la classe public et non internal
public class Warehouse { // Entrepot
    public int Id { get; set; } // EntrepotID ou juste Id
    public string WarehouseName { get; set; }
    public int AddressId  {get;set; } // TODO @INES: Devrait être nommé AddressId (pour respecter requis EF Core) et être de type int

    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; } 
    public DateTime? DateDeleted { get; set; } 
    public byte[] RowVersion { get; set; }

    public DateTime DateDeleted { get; set; }

    public DateTime DateModified { get; set; }





    // UNDONE @INES: Il manque des propriétés de données:
    // DateCreated, type DateTime
    // DateModified, type DateTime?
    // DateDeleted, type DateTime?
    // RowVersion, type byte[]




    // TODO @INES: toutes les propriétés de navigation devraient avoir le modificateur 'virtual'



    // UNDONE @INES: Il manque des propriétés de navigation:
    // Clients, type List<Client>
    // Address, type Address
    // PurchaseOrders, type List<PurchaseOrder>
    // WarehouseEmployuees, type List<User>

    public List<Client> Clients { get; set; } = new List<Client>();






    public Warehouse() 
    {

    }


    // TODO @INES: un second constructeur orienté création à partir de données entrées par les utilisateurs


    // TODO @INES: le constructeur orienté EF Core devrait prendre en paramètre toutes les propriétés de données.
    // aussi, vérifier que leurs noms respectent les requis de EF Core
    // (même nom que la propriété, sauf la première lettre qui peut être en minuscule)
    public Warehouse(int entrepotID, string Nom, string Lieu, string Adresse) 
    {

        // TODO @INES: il faut utiliser this pour distinguer les propriétés des paramètres: assignation circulaires ici
        entrepotID = entrepotID;
        Nom = Nom;
        Lieu = Lieu;
        entrepotAddresse = entrepotAddresse;
        Produits = new List<Produit>(); 
    }

    // TODO @INES: méthode inutile, l'entrepôt n'a pas de produits
    public void AjouteProduit(Produit) 
    {
        Produits.Add(Produit);
        Console.WriteLine("Produit bien ajoute: {produit.Name}");

    }

    // TODO @INES: méthode inutile, l'entrepôt n'a pas de produits
    public void SupprimerProduit(int Produitid) 
    {
        var produit = Produits.Find(p => p.ID == Produitid);
        if (produit == null) {
            Produits.Remove(produit);
            Console.WriteLine("Produit retire: {produit.Nom}");
        } else {
            Console.WriteLine("Produit n'existe pas.");
        }

    }

    // TODO @INES: méthode inutile, l'entrepôt n'a pas de produits
    public void DisplayProduits() 
    {
        Console.WriteLine("Produits existent dans l'entrepot {Nom}:");
        foreach (var produit in Produits) 
        {
            Console.WriteLine("{Produit.Nom} (ID: {Produit.produitID})");
        }
    }

    // UNDONE @INES: override de la méthode ToString() pour afficher les informations du client

}


