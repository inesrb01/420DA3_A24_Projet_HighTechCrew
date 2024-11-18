using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    internal class client

    {
        
        public int idClient { get; set; }
        public string Contactfirstname {  get; set; }
        public string Contactlastname { get; set; }
        public string Contactemail { get; set; }
        public string ContactTelephone { get; set; }
        public string address { get; set; }
        public List<string> Orders { get; set; }

        public client() 
        {
            Orders = new List<string>();
        }
        public client(int idclient, string Contactfirstname, string Contactlastname, string Contactemail, string ContactTelephone, string address) 
        {
            idClient = idclient;
            Contactfirstname = Contactfirstname;
            Contactlastname = Contactlastname;
            Contactemail = Contactemail;
            ContactTelephone = ContactTelephone;
            address = address;
            Orders = new List<string>();

        }
        public void AddOrder(string order) 
        {
            Orders.Add(order);

        }
        public void DisplayclientInfo() 
        {
            Console.WriteLine("client:{ Contactfirstname}{ Contactlastname }");
            Console.WriteLine("contact Email:{Email}, ContactTelephone:{ ContactTelephone }");
            Console.WriteLine("adresse:{ addresse.ToString}()}");

        }
    }
}
