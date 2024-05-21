using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_webapi.Interface;
using backend_webapi.models;
using backend_webapi.MyDb;

namespace backend_webapi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyDbContext _context;

        public CategoryRepository(MyDbContext context)
        {
            this._context = context;
        }
        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Item> GetItemByCategory(int Id)
        {
            return _context.Items
                           .Where(item => item.CategoryId == Id)
                           .ToList();
        }

        public bool IsExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }
    }
}