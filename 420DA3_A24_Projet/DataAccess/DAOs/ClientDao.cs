using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ClientDAO {
    private readonly AppDbContext _context;

    public ClientDAO(AppDbContext context) {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Client Create(Client client) {
        if (client == null)
            throw new ArgumentNullException(nameof(client), "Le client ne peut pas être nul.");
        _context.Clients.Add(client);
        _context.SaveChanges();
        return client;
    }

    public List<Client> Search(string keyword) {
        return _context.Clients
            .Include(c => c.Warehouse)
            .Where(c =>
                c.Id.ToString().Contains(keyword) ||
                c.ClientName.ToLower().Contains(keyword.ToLower()) ||
                c.Warehouse.WarehouseName.ToLower().Contains(keyword.ToLower()) &&
                c.DateDeleted == null)
            .ToList();
    }

    public Client Update(Client client) {
        if (client == null)
            throw new ArgumentNullException(nameof(client));
        _context.Clients.Update(client);
        _context.SaveChanges();
        return client;
    }

    public Client Delete(Client client, bool hardDelete = true) {
        if (client == null)
            throw new ArgumentNullException(nameof(client));

        if (hardDelete) {
            _context.Clients.Remove(client);
        } else {
            client.DateDeleted = DateTime.Now;
            _context.Clients.Update(client);
        }
        _context.SaveChanges();
        return client;
    }

    public Client? GetById(int id) {
        if (id <= 0)
            throw new ArgumentException("the ID doit être supérieur à zéro.", nameof(id));

        return _context.Clients
            .Include(c => c.Warehouse)
            .FirstOrDefault(c => c.Id == id && c.DateDeleted == null);
    }

    public List<Client> GetAll() {
        return _context.Clients
            .Where(c => c.DateDeleted == null)
            .Include(c => c.Warehouse)
            .ToList();
    }
}

