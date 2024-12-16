using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;

namespace _420DA3_A24_Projet.DataAccess.DAOs.Implementations;
public class UserDao  {
    private readonly AppDbContexte dbContexte;

    public UserDao(AppDbContexte dbContexte) {
        this.dbContexte = dbContexte;
    }

    public async Task<User> CreateAsync(User user) {
        EntityEntry<User> result = await dbContexte.Users.AddAsync(user);
        _ = await this.dbContexte.SaveChangesAsync();
        return result.Entity;
    }

    public void Delete(User user) {
        user.DateDeleted = DateTime.UtcNow;
        _ = dbContexte.Users.Update(user);
        _ = dbContexte.SaveChanges();
    }

    public async Task<User?> GetByIdAsync(int id) {

        return await dbContexte.Users.FindAsync(id);
    }

    public async Task<IList<User>> GetByWarehouseAsync(int warehouseId) {

        return await dbContexte.Users.Where(o => o.EmployeeWarehouseId == warehouseId).ToListAsync();
    }

    public async Task RemoveAllRoleAsync(User user) {
        user.Roles.Clear();
        _ = await this.dbContexte.SaveChangesAsync();
    }

    public async Task RemoveRoleAsync(int roleId, User user) {

        Role? role = await dbContexte.Roles.FindAsync(roleId);
        if (role is null) {
            throw new ArgumentNullException($"The Role with Id :{roleId} is not found");
        } else {
            User? existUser = await this.GetByIdAsync(user.Id);
            if (existUser is null) {
                throw new ArgumentNullException($"The User with Id :{user.Id} is not found");
            } else {
                bool isDeleted = user.Roles.Remove(role);
                _ = await this.dbContexte.SaveChangesAsync();

                if (!isDeleted) {
                    throw new ArgumentNullException($"The Role with Id :  {roleId} is not deleted , please retry");
                }
            }
        }
    }

    public async Task<IList<User>> SearchAsync(string pattern) {

        return await dbContexte.Users.Where(e => e.Username.Contains(pattern)).ToListAsync();
    }

    public async Task SetRoleAsync(int roleId, User user) {

        Role? role = await dbContexte.Roles.FindAsync(roleId);
        if (role is null) {
            throw new ArgumentNullException($"The Role with Id :{roleId} is not found");
        } else {
            User? existUser = await this.GetByIdAsync(user.Id);
            if (existUser is null) {
                throw new ArgumentNullException($"The User with Id :{user.Id} is not found");
            } else {
                user.Roles.Add(role);
                _ = await this.dbContexte.SaveChangesAsync();
            }
        }
    }

    public async Task<User> UpdateAsync(User user, string? newPassword) {
        if (newPassword != null) {
            user.PasswordHash = newPassword;
        }
        user.DateModified = DateTime.UtcNow;
        EntityEntry<User> userUpdated = dbContexte.Users.Update(user);
        _ = await dbContexte.SaveChangesAsync();
        return userUpdated.Entity;
    }
}