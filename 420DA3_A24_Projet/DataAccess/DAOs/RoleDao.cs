using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.DataAccess.DAOs {
    public class RoleDAO {
        private readonly AppDbContext context;

        public RoleDAO(AppDbContext context) {
            this.context = context;
        }

        // Create a new Role
        public Role Create(Role role) {
            role.DateCreated = DateTime.Now;
            _ = this.context.Roles.Add(role);
            _ = this.context.SaveChanges();
            return role;
        }

        // Get a Role by ID
        public Role GetById(int id) {
            return this.context.Roles.FirstOrDefault(r => r.Id == id);
        }

        // Update an existing Role
        public Role Update(Role role) {
            role.DateModified = DateTime.Now;
            _ = this.context.Roles.Update(role);
            _ = this.context.SaveChanges();
            return role;
        }

        // Delete a Role (supports soft delete)
        public void Delete(Role role, bool softDeletes = true) {
            if (softDeletes) {
                role.DateDeleted = DateTime.Now;
                _ = this.context.Roles.Update(role);
                _ = this.context.SaveChanges();
            } else {
                _ = this.context.Roles.Remove(role);
                _ = this.context.SaveChanges();
            }
        }

        // Search Roles based on a filter string (searches RoleName and RoleDescription)
        public List<Role> Search(string filter) {
            return this.context.Roles
                .Where(r =>
                    (r.RoleName.Contains(filter) || r.RoleDescription.Contains(filter))
                    && r.DateDeleted == null)
                .ToList();
        }
    }
}
