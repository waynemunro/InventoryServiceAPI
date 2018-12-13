using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;

namespace InventoryService.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItem> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItem>();
        }

        public InventoryItem AddInvetoryItems(InventoryItem item)
        {
            var itemToAdd = new InventoryItem { Id = item.Id, Name = item.Name, Price = item.Price };

            _inventoryItems.Add("ID:"+item.Id, itemToAdd);


            return item;
        }

        public Dictionary<string, InventoryItem> GetInventoryItems()
        {
            return _inventoryItems;
        }

      
    }
}
