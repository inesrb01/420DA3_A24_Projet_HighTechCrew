using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    // TODO @INES: renommer les classes et propriétés pour respecter les conventions de casse C# (PascalCase)
    // TODO @INES: rendre la classe public et non internal
    internal class client // Client
    {
        
        public int idClient { get; set; } // IdClient, ou juste Id serait mieux
        public string Contactfirstname {  get; set; } // ContactFirstName
        public string Contactlastname { get; set; } // ContactLastName
        public string Contactemail { get; set; } // ContactEmail
        public string ContactTelephone { get; set; }
        public string address { get; set; } // TODO @INES: le client n'a pas d'adresse selon le plan prévu
        // UNDONE @INES: Il manque des propriétés de données:
        // ClientName, type string
        // WarehouseID, type int
        // DateCreated, type DateTime
        // DateModified, type DateTime?
        // DateDeleted, type DateTime?
        // RowVersion, type byte[]
        
        // TODO @INES: toutes les propriétés de navigation devraient avoir le modificateur 'virtual'

        // UNDONE @INES: Il manque des propriétés de navigation:
        // AssignedWarehouse, type entrepot
        // Products, type List<Produit>

        // TODO @INES: la liste des orders du client n'est pas une list de strings, mais d'objets ShippingOrder
        public List<string> Orders { get; set; } // aussi, on peut initialiser la liste ici plutôt que dans le constructeur: = new List<ShippingOrder>();

        public client() 
        {
            Orders = new List<string>(); // voir ci-dessus
        }


        // TODO @INES: un second constructeur orienté création à partir de données entrées par les utilisateurs


        // TODO @INES: le constructeur orienté EF Core devrait prendre en paramètre toutes les propriétés de données.
        // aussi, vérifier que leurs noms respectent les requis de EF Core
        // (même nom que la propriété, sauf la première lettre qui peut être en minuscule)
        public client(int idclient, string Contactfirstname, string Contactlastname, string Contactemail, string ContactTelephone, string address) 
        {
            idClient = idclient;
            // TODO @INES: il faut utiliser this pour distinguer les propriétés des paramètres: assignation circulaires ici
            Contactfirstname = Contactfirstname;
            Contactlastname = Contactlastname;
            Contactemail = Contactemail;
            ContactTelephone = ContactTelephone;
            address = address;
            Orders = new List<string>(); // voir plus haut

        }

        // TODO @INES: Méthode inutile, à supprimer: la liste est publique et on peut déja utiliser sa méthode Add()
        public void AddOrder(string order) 
        {
            Orders.Add(order);

        }

        // TODO @INES: Méthode inutile, à supprimer: Console.WriteLine ne marchera pas bien dans une application Windows Forms
        public void DisplayclientInfo() 
        {
            Console.WriteLine("client:{ Contactfirstname}{ Contactlastname }");
            Console.WriteLine("contact Email:{Email}, ContactTelephone:{ ContactTelephone }");
            Console.WriteLine("adresse:{ addresse.ToString}()}");

        }

        // UNDONE @INES: override de la méthode ToString() pour afficher les informations du client

    }
}