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

    public List<client> GetAllClients() {
        return _context.Clients.ToList();
    }

    public client GetClientById(int id) {
        return _context.Clients.FirstOrDefault(c => c.idClient == id);
    }

    public void AddClient(client newClient) {
        _context.Clients.Add(newClient);
        _context.SaveChanges();
    }

    public void UpdateClient(client updatedClient) {
        _context.Clients.Update(updatedClient);
        _context.SaveChanges();
    }

    public void DeleteClient(int id) {
        client client = _context.Clients.FirstOrDefault(c => c.idClient == id);
        if (client != null) {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}


