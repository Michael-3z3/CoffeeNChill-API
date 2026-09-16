using Azure;
using Azure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNChill.Models
{
    public class MenuItem : ITableEntity
    {
        // Azure Table Storage Partition Key
        public string PartitionKey { get; set; } = string.Empty;

        // Azure Table Storage Row Key
        public string RowKey { get; set; } = string.Empty;

        // Name of the menu item
        public string Name { get; set; } = string.Empty;

        // Description of the menu item
        public string Description { get; set; } = string.Empty;

        // Price of the menu item
        public double Price { get; set; }
        
        // Availability status of the menu item
        public bool IsAvailable { get; set; }

        //Automatically managed by Azure Table Storage
        public DateTimeOffset? Timestamp { get; set; }

        //Entity Tag for concurrency
        public ETag ETag { get; set; }
    }
}
