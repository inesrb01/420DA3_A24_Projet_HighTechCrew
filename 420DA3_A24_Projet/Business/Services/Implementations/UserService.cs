using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;


namespace _420DA3_A24_Projet.Business.Services.Implementations;
public class UserService  {

    private readonly UserDao userDao;

    public UserService(UserDao userDao) {
        this.userDao = userDao;
    }
    public UserService() {
        
    }
    public async Task<User> CreateAsync(User user, string password) {
        user.PasswordHash = HashPassword(password);
        return await userDao.CreateAsync(user);
    }

    public async Task<User?> GetByIdAsync(int id) {
        return await userDao.GetByIdAsync(id);
    }

    public async Task DeleteAsync(User user) {
        userDao.Delete(user);
        await Task.CompletedTask;
    }

    public async Task<IList<User>> SearchAsync(string pattern) {
        return await userDao.SearchAsync(pattern);
    }

    public async Task<IList<User>> GetByWarehouseAsync(int warehouseId) {
        return await userDao.GetByWarehouseAsync(warehouseId);
    }

    public async Task SetRoleAsync(int roleId, User user) {
        await userDao.SetRoleAsync(roleId, user);
    }

    public async Task RemoveRoleAsync(int roleId, User user) {
        await userDao.RemoveRoleAsync(roleId, user);
    }

    private static string HashPassword(string password) {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public async Task<User> UpdateAsync(User user, string? newPassword) {
        if (newPassword != null) {
            newPassword = HashPassword(newPassword);
        }
        return await userDao.UpdateAsync(user, newPassword);
    }

    public async Task RemoveAllRoleAsync(User user) {
        await userDao.RemoveAllRoleAsync(user);
    }
}