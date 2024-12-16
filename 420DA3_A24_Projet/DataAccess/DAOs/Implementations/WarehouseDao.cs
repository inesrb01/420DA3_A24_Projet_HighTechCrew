using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs.Implementations;
public class WarehouseDao {

    private readonly AppDbContexte context;

    public WarehouseDao(AppDbContexte context) {
        this.context = context;
    }

    public async Task<IList<Warehouse>> GetAllAsync() {
        return await context.Warehouse.ToListAsync();
    }
}