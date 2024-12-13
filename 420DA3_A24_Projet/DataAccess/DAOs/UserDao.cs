using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Daos {
    public class UserDAO {
        private readonly AppDbContext context;

        public UserDAO(AppDbContext context) {
            this.context = context;
        }

        // Create a new User
        public User Create(User user) {
            user.DateCreated = DateTime.Now;
            _ = this.context.Users.Add(user);
            _ = this.context.SaveChanges();
            return user;
        }

        // Get a User by ID
        public User GetById(int id) {
            return this.context.Users.FirstOrDefault(u => u.Id == id);
        }

        // Update an existing User
        public User Update(User user) {
            user.DateModified = DateTime.Now;
            _ = this.context.Users.Update(user);
            _ = this.context.SaveChanges();
            return user;
        }

        // Delete a User (supports soft delete)
        public void Delete(User user, bool softDeletes = true) {
            if (softDeletes) {
                user.DateDeleted = DateTime.Now;
                _ = this.context.Users.Update(user);
                _ = this.context.SaveChanges();
            } else {
                _ = this.context.Users.Remove(user);
                _ = this.context.SaveChanges();
            }
        }

        // Search Users based on a filter string (searches Username)
        public List<User> Search(string filter) {
            return this.context.Users
                .Where(u =>
                    (u.Username.Contains(filter) || u.PasswordHash.Contains(filter))
                    && u.DateDeleted == null)
                .ToList();
        }

        // Get Users by Warehouse
        public List<User> GetByWarehouse(Warehouse warehouse) {
            return this.context.Users
                .Where(u => u.EmployeeWarehouseId == warehouse.Id && u.DateDeleted == null)
                .ToList();
        }
    }
}
