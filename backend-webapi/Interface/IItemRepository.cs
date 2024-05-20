using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using backend_webapi.models;

namespace backend_webapi.Interface
{
    public interface IItemRepository 
    {
        ICollection<Item> GetItems();

        Item GetItem(int Id);

        bool IsExists (int Id);
    }
}