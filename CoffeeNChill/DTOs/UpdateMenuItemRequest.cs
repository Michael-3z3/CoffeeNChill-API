using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace CoffeeNChill.DTOs
{
    public class UpdateMenuItemRequest
    {
        //Updated name of the menu item
        public string Name { get; set; } = string.Empty;

        //Updated description of the menu item
        public string Description { get; set; } = string.Empty;

        //Updated Price of the menu item
        public double Price { get; set; }

        //Updated Availability status of the menu item
        public bool IsAvailable { get; set; }
    }
}
