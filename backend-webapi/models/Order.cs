using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_webapi.models
{
    public class Order
    {
        public int Id {get; set;}
        public DateTime OrderDate {get; set;}
        public decimal ToatalPrice {get; set;}
        public ICollection<Item> Items {get; set;} = new List<Item>();
        public int UserId {get; set;}
        public User User;
    }
}