using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.DataAccess.DAOs.Contracts;
public interface IRoleDao {
    // +Create(Role) : Role
    Task<Role> CreateAsync(Role role);

    // +GetById(int) : Role
    Task<Role?> GetByIdAsync(int id);

    // +Update(Role) : Role
    Task<Role> UpdateAsync(Role role);

    //+Delete(Role) : void
    void Delete(Role role);

    // +Search(string) : List<Role>
    Task<IList<Role>> SearchAsync(string name);

}
