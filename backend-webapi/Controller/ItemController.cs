using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_webapi.Interface;
using backend_webapi.models;
using backend_webapi.MyDb;
using Microsoft.AspNetCore.Mvc;

namespace backend_webapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        private readonly MyDbContext _context;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            // _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof (IEnumerable<Item>))]

        public IActionResult GetItems(){
            var items = _itemRepository.GetItems();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof (Item))]
        [ProducesResponseType(400)]

        public IActionResult GetItem(int id){
            if (!_itemRepository.IsExists(id))
            return NotFound();

            var item = _itemRepository.GetItem(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(item);
        }


        // public bool IsExists (int Id){

        // }
    }
}