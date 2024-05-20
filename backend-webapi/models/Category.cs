using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend_webapi.models
{
    public class Category
    {
        public int Id {get; set;}
        public required string categoryName {get; set;}
        public required string categoryDescription {get; set;}
        public ICollection<Item> Items {get; set;} = new List<Item>();
    }
}