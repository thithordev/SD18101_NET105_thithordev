using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppData_Model.Models;

namespace SD18101_AppAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_ProductController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Category_ProductController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Category_Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category_Product>>> Getcategory_detailss()
        {
          if (_context.category_detailss == null)
          {
              return NotFound();
          }
            return await _context.category_detailss.ToListAsync();
        }

        // GET: api/Category_Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category_Product>> GetCategory_Product(Guid id)
        {
          if (_context.category_detailss == null)
          {
              return NotFound();
          }
            var category_Product = await _context.category_detailss.FindAsync(id);

            if (category_Product == null)
            {
                return NotFound();
            }

            return category_Product;
        }

        // PUT: api/Category_Product/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory_Product(Guid id, Category_Product category_Product)
        {
            if (id != category_Product.Id)
            {
                return BadRequest();
            }

            _context.Entry(category_Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Category_ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Category_Product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category_Product>> PostCategory_Product(Category_Product category_Product)
        {
          if (_context.category_detailss == null)
          {
              return Problem("Entity set 'AppDBContext.category_detailss'  is null.");
          }
            _context.category_detailss.Add(category_Product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory_Product", new { id = category_Product.Id }, category_Product);
        }

        // DELETE: api/Category_Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory_Product(Guid id)
        {
            if (_context.category_detailss == null)
            {
                return NotFound();
            }
            var category_Product = await _context.category_detailss.FindAsync(id);
            if (category_Product == null)
            {
                return NotFound();
            }

            _context.category_detailss.Remove(category_Product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Category_ProductExists(Guid id)
        {
            return (_context.category_detailss?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
