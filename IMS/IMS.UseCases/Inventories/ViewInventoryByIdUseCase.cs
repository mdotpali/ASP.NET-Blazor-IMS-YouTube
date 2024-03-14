using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoryByIdUseCase
    {
        private readonly IInventoryRepository inventoryRepository;
        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository) 
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<Inventory> ExecuteAsync(int inventoryId)
        {
            this.inventoryRepository.GetInventoryById(inventoryId);
        }
    }
}
