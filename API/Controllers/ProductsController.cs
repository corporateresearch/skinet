using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController] //API Controller attribute
    [Route("api/[controller]")] //we also need to do a route
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet] //adding the first HttpGet method
        public async Task<ActionResult<List<Product>>>  GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }
        [HttpGet("{id}")] //adding the second HttpGet method.
        public async Task<ActionResult<Product>> GetProduct(int id) //if we need a single product or id to the URL, we'll get a single product
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
