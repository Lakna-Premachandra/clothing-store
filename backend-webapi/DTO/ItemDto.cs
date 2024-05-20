using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_webapi.DTO
{
    public class ItemDto
    {
        public int Id { get; set; }
        public required string ItemName { get; set; }
        public required string ItemDescription { get; set; }
        public int Quantity  { get; set; }
        public decimal Price { get; set; }
    }
}