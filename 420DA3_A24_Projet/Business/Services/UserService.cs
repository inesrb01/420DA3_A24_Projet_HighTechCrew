using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using Project_Utilities.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services {
    public class UserService {
        private readonly UserView view;
        private readonly App application;
        private readonly UserDAO dao;

        public UserService(App application, AppDbContext context) {
            this.application = application;
            this.dao = new UserDAO(context);
            this.view = new UserView(application);
        }

        // Open the view for different actions like Creation, Edition, or Visualization
        public User? OpenViewFor(ViewActionsEnum viewAction, User? user = null) {
            try {
                DialogResult result = this.view.OpenFor(viewAction, user);
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

        // Create a new User
        public User Create(User user) {
            try {
                return this.dao.Create(user);
            } catch (Exception ex) {
                throw new Exception("Failed to create new [User].", ex);
            }
        }

        // Get a User by ID
        public User? GetById(int id) {
            try {
                return this.dao.GetById(id);
            } catch (Exception ex) {
                throw new Exception($"Failed to obtain [User] instance with id# {id}.", ex);
            }
        }

        // Get a User by Username
        public User? GetByUsername(string username) {
            try {
                return this.dao.Search(username).FirstOrDefault(u => u.Username == username);
            } catch (Exception ex) {
                throw new Exception($"Failed to obtain [User] instance with username '{username}'.", ex);
            }
        }

        // Search Users based on a filter string
        public List<User> Search(string filter) {
            try {
                return this.dao.Search(filter);
            } catch (Exception ex) {
                throw new Exception("Failed to search for [User] instances.", ex);
            }
        }

        // Update an existing User
        public User Update(User user) {
            try {
                return this.dao.Update(user);
            } catch (Exception ex) {
                throw new Exception($"Failed to update [User] instance with id# {user.Id}.", ex);
            }
        }

        // Delete a User (supports soft delete)
        public void Delete(User user, bool softDeletes = true) {
            try {
                this.dao.Delete(user, softDeletes);
            } catch (Exception ex) {
                throw new Exception($"Failed to delete [User] instance with id# {user.Id}.", ex);
            }
        }
    }

    public class App {
        public object RoleService { get; internal set; }

        public void HandleException(Exception ex) {
            throw new NotImplementedException();
        }
    }
}
