using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restore.Data;
using Restore.Entities;

namespace Restore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(StoreContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return context.Products.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            Product? product = await context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
