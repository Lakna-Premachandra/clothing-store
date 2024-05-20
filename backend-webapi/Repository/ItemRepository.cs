using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_webapi.Interface;
using backend_webapi.models;
using backend_webapi.MyDb;

namespace backend_webapi.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly MyDbContext _context;

        public ItemRepository(MyDbContext context)
        {
            this._context = context;
        }

        public ICollection<Item> GetItems(){
            return _context.Items.OrderBy(i=> i.Id).ToList();
        }

        public Item GetItem(int id){
            return _context.Items.Where(i => i.Id == id).FirstOrDefault();
        }

        public bool IsExists (int id){
            return _context.Items.Any(p=> p.Id == id);
        }

    }
}