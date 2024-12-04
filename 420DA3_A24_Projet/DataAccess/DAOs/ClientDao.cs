using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ClientDao 
{
    private readonly ClientDbContext _context;

    public ClientDao(ClientDbContext context) {
        _context = context;
    }

    public List<Client> GetAllClients() {
        return _context.Clients.ToList();
    }

    public Client GetClientById(int id) {
        return _context.Clients.FirstOrDefault(c => c.idClient == id);
    }

    public void AddClient(Client newClient) {
        _context.Clients.Add(newClient);
        _context.SaveChanges();
    }

    public void UpdateClient(Client updatedClient) {
        _context.Clients.Update(updatedClient);
        _context.SaveChanges();
    }

    public void DeleteClient(int id) {
        Client client = _context.Clients.FirstOrDefault(c => c.idClient == id);
        if (client != null) {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}


