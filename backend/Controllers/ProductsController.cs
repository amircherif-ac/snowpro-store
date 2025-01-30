using backend.Data;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnowproStore.Controllers;

namespace backend.Controllers
{
    public class ProductsController(StoreContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();
        }

        [HttpGet("{id}")] // ../api/products/{id}
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            return product;
        }
    }
}
