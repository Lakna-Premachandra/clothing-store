using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend_webapi.models
{
    public class User
    {
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNo { get; set; }
        public string UserType { get; set; } = "customer";
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}