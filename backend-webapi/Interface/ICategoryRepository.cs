using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_webapi.models;

namespace backend_webapi.Interface
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        Category GetCategory(int Id);

        bool IsExists (int Id);

        ICollection<Item> GetItemByCategory(int Id);
    }
}