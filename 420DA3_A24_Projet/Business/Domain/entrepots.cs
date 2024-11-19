﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public void AjouteProduit(Produit) 
    {
        Produits.Add(Produit);
        Console.WriteLine("Produit bien ajoute: {produit.Name}");

    }
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
    public void DisplayProduits() 
    {
        Console.WriteLine("Produits existent dans l'entrepot {Nom}:");
        foreach (var produit in Produits) 
        {
            Console.WriteLine("{Produit.Nom} (ID: {Produit.produitID})");
        }
    }
}

