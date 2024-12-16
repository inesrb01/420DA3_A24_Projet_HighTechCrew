using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs.Implementations {
    public class PurchaseOrderDAO {
        private readonly AppDbContext context;

        public PurchaseOrderDAO(AppDbContext context) {
            this.context = context;
        }

        // Create a new PurchaseOrder
        public async Task<PurchaseOrder> CreateAsync(PurchaseOrder purchaseOrder) {
            EntityEntry<PurchaseOrder> result = await context.PurchaseOrders.AddAsync(purchaseOrder);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        // Get a PurchaseOrder by its ID
        public async Task<PurchaseOrder?> GetByIdAsync(int id) {
            return await context.PurchaseOrders.FindAsync(id);
        }

        // Update an existing PurchaseOrder
        public async Task<PurchaseOrder> UpdateAsync(PurchaseOrder purchaseOrder) {
            purchaseOrder.DateModified = DateTime.UtcNow;
            EntityEntry<PurchaseOrder> updatedOrder = context.PurchaseOrders.Update(purchaseOrder);
            await context.SaveChangesAsync();
            return updatedOrder.Entity;
        }

        // Delete a PurchaseOrder (soft delete)
        public void Delete(PurchaseOrder purchaseOrder) {
            purchaseOrder.DateDeleted = DateTime.UtcNow;
            context.PurchaseOrders.Update(purchaseOrder);
            context.SaveChanges();
        }



        // Get PurchaseOrders by Warehouse with optional status filter
        public async Task<IList<PurchaseOrder>> GetByWHAsync(Warehouse warehouse, PurchaseOrderStatusEnum? status = null) {
            IQueryable<PurchaseOrder> query = context.PurchaseOrders.Where(po => po.WarehouseId == warehouse.Id);

            if (status.HasValue) {
                query = query.Where(po => po.Status == status.Value);
            }

            return await query.ToListAsync();
        }

        // Get PurchaseOrders by Product with optional status filter
        public async Task<IList<PurchaseOrder>> GetByProductAsync(Product product, PurchaseOrderStatusEnum? status = null) {
            IQueryable<PurchaseOrder> query = context.PurchaseOrders.Where(po => po.ProductId == product.Id);

            if (status.HasValue) {
                query = query.Where(po => po.Status == status.Value);
            }

            return await query.ToListAsync();
        }
    }
}
