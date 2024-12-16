using _420DA3_A24_Exemple_Enseignant.Business.Services;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services.Implementations {
    public class AddressService {
        private readonly AddressDAO dao;
        private readonly AddressView view;
        private readonly App application;

        public AddressService(AddressDAO dao, AddressView view, App application) {
            this.dao = dao;
            this.view = view;
            this.application = application;
        }

        public AddressService() {
        }

        // Open view for a specific action
        public async Task<Address?> OpenViewForAsync(ViewActionsEnum action, Address? address = null) {
            // Implementation can vary based on application logic
            return await Task.FromResult(view.Render(action, address));
        }

        // Create a new Address
        public async Task<Address> CreateAsync(Address address) {
            return await dao.CreateAsync(address);
        }

        // Get an Address by its ID
        public async Task<Address?> GetByIdAsync(int id) {
            return await dao.GetByIdAsync(id);
        }

        // Search for Addresses by a search string
        public async Task<IList<Address>> SearchAsync(string pattern) {
            return await dao.SearchAsync(pattern);
        }

        // Update an existing Address
        public async Task<Address> UpdateAsync(Address address) {
            return await dao.UpdateAsync(address);
        }

        // Delete an Address (soft delete, by default)
        public async Task DeleteAsync(Address address, bool softDelete = true) {
            if (softDelete) {
                dao.Delete(address);
            } else {
                // Implement hard delete logic if needed
            }
            await Task.CompletedTask;
        }
    }
}
