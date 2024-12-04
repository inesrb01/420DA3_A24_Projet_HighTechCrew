using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class WarehouseDAO {

    private readonly AppDbContext _context;

    public WarehouseDAO(AppDbContext context) {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Warehouse Create(Warehouse warehouse) {
        if (warehouse == null)
            throw new ArgumentNullException(nameof(warehouse), "L'entrepôt ne peut pas être nul.");
        _context.Warehouses.Add(warehouse);
        _context.SaveChanges();
        return warehouse;
    }

    public List<Warehouse> Search(string keyword) {
        return _context.Warehouses
            .Include(w => w.Clients)
            .Where(w =>
                w.Id.ToString().Contains(keyword) ||
                w.WarehouseName.ToLower().Contains(keyword.ToLower()) &&
                w.DateDeleted == null)
            .ToList();
    }

    public Warehouse Update(Warehouse warehouse) {
        if (warehouse == null)
            throw new ArgumentNullException(nameof(warehouse));
        _context.Warehouses.Update(warehouse);
        _context.SaveChanges();
        return warehouse;
    }

    public Warehouse Delete(Warehouse warehouse, bool hardDelete = true) {
        if (warehouse == null)
            throw new ArgumentNullException(nameof(warehouse));

        if (hardDelete) {
            _context.Warehouses.Remove(warehouse);
        } else {
            warehouse.DateDeleted = DateTime.Now;
            _context.Warehouses.Update(warehouse);
        }
        _context.SaveChanges();
        return warehouse;
    }

    public Warehouse? GetById(int id) {
        if (id <= 0)
            throw new ArgumentException("L'ID doit être supérieur à zéro.", nameof(id));

        return _context.Warehouses
            .Include(w => w.Clients)
            .FirstOrDefault(w => w.Id == id && w.DateDeleted == null);
    }

    public List<Warehouse> GetAll() {
        return _context.Warehouses
            .Where(w => w.DateDeleted == null)
            .Include(w => w.Clients)
            .ToList();
    }
}
