using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_webapi.DTO;
using backend_webapi.Interface;
using backend_webapi.models;
using backend_webapi.MyDb;
using Microsoft.AspNetCore.Mvc;

namespace backend_webapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository, MyDbContext context)
        {
            _categoryRepository = categoryRepository;

        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof (IEnumerable<Item>))]
        public IActionResult GetCategories()
        {
            var Categories =  _categoryRepository.GetCategories();

            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            return Ok (Categories);
        }

        [HttpGet("{id}")]
        [ProducesResponseType (200, Type = typeof(Category))]
        [ProducesResponseType (400)]
        public IActionResult GetCategory(int id)
        {
            if (!_categoryRepository.IsExists(id))
            return NotFound();

            var Category = _categoryRepository.GetCategory(id);
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            return Ok (Category);
        }

        [HttpGet("/category/{categoryid}")]
        [ProducesResponseType (200, Type = typeof(ItemDto))]
        [ProducesResponseType (400)]

        public IActionResult GetItemByCategory(int categoryid){
            var item = _categoryRepository.GetItemByCategory(categoryid);
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            return Ok (item);
        }
    }
}