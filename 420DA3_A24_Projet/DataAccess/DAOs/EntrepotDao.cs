﻿using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class EntrepotDao 
{
    private readonly EntrepotDbContext _context;

    public EntrepotDao(EntrepotDbContext context) {
        _context = context;
    }

    public List<Warehouse> GetAllEntrepots() {
        return _context.Entrepots.ToList();
    }

    public Warehouse GetEntrepotById(int id) {
        return _context.Entrepots.FirstOrDefault(e => e.entrepotID == id);
    }

    public void AddEntrepot(Warehouse newEntrepot) {
        _context.Entrepots.Add(newEntrepot);
        _context.SaveChanges();
    }

    public void UpdateEntrepot(Warehouse updatedEntrepot) {
        _context.Entrepots.Update(updatedEntrepot);
        _context.SaveChanges();
    }

    public void DeleteEntrepot(int id) {
        Warehouse entrepot = _context.Entrepots.FirstOrDefault(e => e.entrepotID == id);
        if (entrepot != null) {
            _context.Entrepots.Remove(entrepot);
            _context.SaveChanges();
        }
    }
}


