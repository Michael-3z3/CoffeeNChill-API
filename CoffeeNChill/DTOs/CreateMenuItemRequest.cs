using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNChill.DTOs
{
    public class CreateMenuItemRequest
    {
        //Category of the Menu item used as the PartitionKey in Azure Table Storage
        public string Category { get; set; } = string.Empty;

        //Unique Stock Keeping Unit (SKU) used as the RowKey in Azure Table Storage
        public string SKU { get; set; } = string.Empty;

        //Name of the menu item
        public string Name { get; set; } = string.Empty;

        //Description of the menu item
        public string Description { get; set; } = string.Empty;

        //Price of the menu item
        public double Price { get; set; }

        //Availability status of the menu item
        public bool IsAvailable { get; set; }
    }
}
