using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InventoryClientTests
{
    [TestClass]
    public class FunctionalTests
    {
        /// <summary>
        /// Functional test.
        /// Expecting and error: An item with the same key has already been added.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void AddInventoryItem400ErrorTest()
        {
            var httpClient = new System.Net.Http.HttpClient();
            var client = new InventoryClient.Client("https://localhost:44305/", httpClient);

            var inventoryItemToAdd = new InventoryClient.InventoryItem
            {
                Id = 101,
                Name = "Item 1" +  Guid.NewGuid().ToString(),
                Price = 99.99
            };

            var result1 = client.AddInventoryItemsAsync(inventoryItemToAdd).Result;

            var result2 = client.AddInventoryItemsAsync(inventoryItemToAdd).Result;
        }
    }
}
