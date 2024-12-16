using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs.Implementations;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Services.Implementations {
    public class PurchaseOrderService {
        private readonly PurchaseOrderDAO purchaseOrderDao;

        public PurchaseOrderService(PurchaseOrderDAO purchaseOrderDao) {
            this.purchaseOrderDao = purchaseOrderDao;
        }

        public PurchaseOrderService() {
        }

        // Open View for PurchaseOrder (Stubbed)
        public PurchaseOrder? OpenViewFor(ViewActionsEnum action, PurchaseOrder? purchaseOrder = null) {
            // Implement logic to interact with PurchaseOrderView based on the action
            // This could involve fetching or displaying the purchase order
            return purchaseOrder;
        }

        // Create a new PurchaseOrder
        public async Task<PurchaseOrder> CreateAsync(PurchaseOrder purchaseOrder) {
            return await purchaseOrderDao.CreateAsync(purchaseOrder);
        }

        // Get a PurchaseOrder by ID
        public async Task<PurchaseOrder?> GetByIdAsync(int id) {
            return await purchaseOrderDao.GetByIdAsync(id);
        }

        // Get new PurchaseOrders by Warehouse
        public async Task<IList<PurchaseOrder>> GetNewByWarehouseAsync(Warehouse warehouse) {
            return await purchaseOrderDao.GetByWHAsync(warehouse, PurchaseOrderStatusEnum.Pending);
        }

        // Update an existing PurchaseOrder
        public async Task<PurchaseOrder> UpdateAsync(PurchaseOrder purchaseOrder) {
            return await purchaseOrderDao.UpdateAsync(purchaseOrder);
        }

        // Delete a PurchaseOrder (soft delete by default)
        public async Task DeleteAsync(PurchaseOrder purchaseOrder, bool softDelete = true) {
            if (softDelete) {
                purchaseOrder.DateDeleted = DateTime.UtcNow;
                await UpdateAsync(purchaseOrder);
            } else {
                purchaseOrderDao.Delete(purchaseOrder);
            }
        }
    }
}
