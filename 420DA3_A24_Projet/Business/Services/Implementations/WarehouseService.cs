using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;


namespace _420DA3_A24_Projet.Business.Services.Implementations;
public class WarehouseService  {

    private readonly WarehouseDao warehouseDao;

    public WarehouseService(WarehouseDao warehouseDao) {
        this.warehouseDao = warehouseDao;
    }

    public async Task<IList<Warehouse>> GetAllAsync() {
        return await warehouseDao.GetAllAsync();
    }
}