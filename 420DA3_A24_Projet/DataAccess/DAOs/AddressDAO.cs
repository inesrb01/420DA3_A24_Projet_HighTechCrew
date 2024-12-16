using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs.Implementations {
    public class AddressDAO {
        private readonly AppDbContext context;

        public AddressDAO(AppDbContext context) {
            this.context = context;
        }

        // Create a new Address
        public async Task<Address> CreateAsync(Address address) {
            EntityEntry<Address> result = await context.Addresses.AddAsync(address);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        // Get an Address by its ID
        public async Task<Address?> GetByIdAsync(int id) {
            return await context.Addresses.FindAsync(id);
        }

        // Update an existing Address
        public async Task<Address> UpdateAsync(Address address) {
            address.DateModified = DateTime.UtcNow;
            EntityEntry<Address> updatedAddress = context.Addresses.Update(address);
            await context.SaveChangesAsync();
            return updatedAddress.Entity;
        }

        // Delete an Address (soft delete)
        public void Delete(Address address) {
            address.DateDeleted = DateTime.UtcNow;
            context.Addresses.Update(address);
            context.SaveChanges();
        }

        // Search for Addresses by a search string
        public async Task<IList<Address>> SearchAsync(string pattern) {
            return await context.Addresses
                .Where(a => a.Addressee.Contains(pattern) ||
                            a.Street.Contains(pattern) ||
                            a.City.Contains(pattern))
                .ToListAsync();
        }

        // Get Addresses by Warehouse
        public async Task<IList<Address>> GetByWarehouseAsync(Warehouse warehouse) {
            return await context.Addresses
                .Where(a => a.OwnerWareHouse != null && a.OwnerWareHouse.Id == warehouse.Id)
                .ToListAsync();
        }

        // Get Addresses by Client
        public async Task<IList<Address>> GetByClientAsync(Client client) {
            return await context.Addresses
                .Where(a => a.OwnerShipOrder != null && a.OwnerShipOrder.clientId == client.Id)
                .ToListAsync();
        }

        // Get Addresses by Shipping Order
        public async Task<IList<Address>> GetByShipOrderAsync(ShippingOrder shippingOrder) {
            return await context.Addresses
                .Where(a => a.OwnerShipOrder != null && a.OwnerShipOrder.Id == shippingOrder.Id)
                .ToListAsync();
        }
    }
}
