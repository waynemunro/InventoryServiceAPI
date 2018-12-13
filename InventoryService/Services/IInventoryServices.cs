using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;

namespace InventoryService.Services
{
    public interface IInventoryServices
    {
        InventoryItem AddInvetoryItems(InventoryItem items);
        Dictionary<string, InventoryItem> GetInventoryItems();
    }
}
