using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend_webapi.models
{
    public class Item
    {
        public int Id { get; set; }
        public required string ItemName { get; set; }
        public required string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category;
        public int OrderId {get; set;}
        public Order Order;
    }
}