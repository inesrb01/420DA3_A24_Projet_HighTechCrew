using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.DataAccess.DAOs.Contracts;
public interface IUserDao {

    // +Create(User,password) : User
    Task<User> CreateAsync(User user);

    //+GetById(int) : User
    Task<User?> GetByIdAsync(int id);

    //+Update(User) : User
    Task<User> UpdateAsync(User user);

    // +Delete(User) : void
    void Delete(User user);

    // +Search(string) : List<User>
    Task<IList<User>> SearchAsync(string pattern);

    //+GetByWarehouse(Warehouse) : List<User>
    Task<IList<User>> GetByWarehouseAsync(int warehouseId);
    Task SetRoleAsync(int roleId, User user);
    Task RemoveRoleAsync(int roleId, User user);
}