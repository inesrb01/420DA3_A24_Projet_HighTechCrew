using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;

namespace _420DA3_A24_Projet.Business.Services.Implementations;
public class RoleService {

    private readonly RoleDao roleDao;

    public RoleService(RoleDao roleDao) {
        this.roleDao = roleDao;
    }

    public async Task<Role> CreateAsync(Role role) {
        return await roleDao.CreateAsync(role);
    }

    public async Task<Role?> GetByIdAsync(int id) {
        return await roleDao.GetByIdAsync(id);
    }

    public async Task<Role> UpdateAsync(Role role) {
        return await roleDao.UpdateAsync(role);
    }

    public async Task DeleteAsync(Role role) {
        roleDao.Delete(role);
        await Task.CompletedTask;
    }

    public async Task<IList<Role>> SearchAsync(string name) {
        return await roleDao.SearchAsync(name);
    }
}