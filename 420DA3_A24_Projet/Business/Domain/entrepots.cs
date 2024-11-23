using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _420DA3_A24_Projet.Business.Domain.Produits;

namespace _420DA3_A24_Projet.Business.Domain;
internal class entrepots {
    public int entrepotID { get; set; }
    public string Nom { get; set; }
    public string entrepotAddresse  {get;set;}
    public string entrepotlieu { get; set; }
    public List<Produit> Produits { get; set; }

    public entrepots() 
    {
        Produits= new List<Produit> ();
    }
    public entrepots(int entrepotID, string Nom, string Lieu, string Adresse) 
    {
        entrepotID = entrepotID;
        Nom = Nom;
        Lieu = Lieu;
        entrepotAddresse = entrepotAddresse;
        Produits = new List<Produit>(); 
    }
    public void AjouterProduit(Produit produit) 
    {
        Produits.Add(produit);
        Console.WriteLine("Produit bien ajoute: {produit.Name}");

    }
    public void SupprimerProduit(int Produitid) 
    {
         Produit produit = Produits.FirstOrDefault(p => p.Id == Produitid);
        if (produit ! == null) {
            Produits.Remove(produit);
            Console.WriteLine("Produit retire: {produit.Nom}");
        } 
        else 
        {
            Console.WriteLine("Produit n'existe pas.");
        }

    }
    public void DisplayProduits() 
    {
        Console.WriteLine("Produits existent dans l'entrepot {Nom}:");
        foreach (Produit produit in Produits) {
            Console.WriteLine($"Produit: {produit.Nom} (ID: {produit.Id})");
        }

    }
}


