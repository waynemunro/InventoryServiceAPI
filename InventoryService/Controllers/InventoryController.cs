using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;
using InventoryService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    //[Route("api/[controller]")]
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        private readonly IInventoryServices _services;

        public InventoryController(IInventoryServices services)
        {
            _services = services;

        }


        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItem> AddInventoryItems(InventoryItem items)
        {
            var inventoryItems = _services.AddInvetoryItems(items);

            if (inventoryItems == null)
            {
                return NotFound();
            }

            return Ok(inventoryItems);

        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, InventoryItem>> GetInventoryItems()
        {
            Dictionary<string, InventoryItem> inventoryItems = _services.GetInventoryItems();

            if (inventoryItems.Count() == 0)
            {
                NotFound();
            }

            return inventoryItems;
        }

    }
}