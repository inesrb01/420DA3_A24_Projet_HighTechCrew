using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;


namespace _420DA3_A24_Projet.DataAccess.DAOs.Implementations;
public class RoleDao  {

    private readonly AppDbContexte context;

    public RoleDao(AppDbContexte context) {
        this.context = context;
    }

    public async Task<Role> CreateAsync(Role role) {
        EntityEntry<Role> result = await context.Roles.AddAsync(role);
        _ = await this.context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Role?> GetByIdAsync(int id) {
        return await context.Roles.FindAsync(id);
    }

    public async Task<Role> UpdateAsync(Role role) {
        _ = context.Roles.Update(role);
        _ = await this.context.SaveChangesAsync();
        return role;
    }

    public void Delete(Role role) {
        _ = context.Roles.Remove(role);
        _ = context.SaveChanges();
    }

    public async Task<IList<Role>> SearchAsync(string name) {
        return name == string.Empty
            ?  await context.Roles
            .ToListAsync()
            : (IList<Role>) await context.Roles
            .Where(r => r.RoleName.Contains(name))
            .ToListAsync();
    }
}