using _420DA3_A24_Exemple_Enseignant.Presentation.Views;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using Project_Utilities.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services {
    public class RoleService {
        private readonly RoleView view;
        private readonly App application;
        private readonly RoleDAO dao;

        public RoleService(App application, AppDbContext context) {
            this.application = application;
            this.dao = new RoleDAO(context);
            this.view = new RoleView(application);
        }

        // Open the view for different actions like Creation, Edition, or Visualization
        public Role? OpenViewFor(ViewActionsEnum viewAction, Role? role = null) {
            try {
                DialogResult result = this.view.OpenFor(viewAction, role);
                if (result == DialogResult.OK) {
                    switch (viewAction) {
                        case ViewActionsEnum.Creation:
                        case ViewActionsEnum.Edition:
                            // Open the view in visualization mode after creation or edition
                            _ = this.OpenViewFor(ViewActionsEnum.Visualization, this.view.GetCurrentInstance());
                            break;
                        default:
                            break;
                    }
                }
                // Return the current instance of the form (created, viewed, modified, or deleted)
                return this.view.GetCurrentInstance();
            } catch (Exception ex) {
                this.application.HandleException(ex);
                return null;
            }
        }

        // Create a new Role
        public Role Create(Role role) {
            try {
                return this.dao.Create(role);
            } catch (Exception ex) {
                throw new Exception("Failed to create new [Role].", ex);
            }
        }

        // Get a Role by ID
        public Role? GetById(int id) {
            try {
                return this.dao.GetById(id);
            } catch (Exception ex) {
                throw new Exception($"Failed to obtain [Role] instance with id# {id}.", ex);
            }
        }

        // Search Roles based on a filter string
        public List<Role> Search(string filter) {
            try {
                return this.dao.Search(filter);
            } catch (Exception ex) {
                throw new Exception("Failed to search for [Role] instances.", ex);
            }
        }

        // Update an existing Role
        public Role Update(Role role) {
            try {
                return this.dao.Update(role);
            } catch (Exception ex) {
                throw new Exception($"Failed to update [Role] instance with id# {role.Id}.", ex);
            }
        }

        // Delete a Role (supports soft delete)
        public void Delete(Role role, bool softDeletes = true) {
            try {
                this.dao.Delete(role, softDeletes);
            } catch (Exception ex) {
                throw new Exception($"Failed to delete [Role] instance with id# {role.Id}.", ex);
            }
        }
    }
}
