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
    public class Cart_DetailsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Cart_DetailsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Cart_Details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart_Details>>> Getcart_detailss()
        {
          if (_context.cart_detailss == null)
          {
              return NotFound();
          }
            return await _context.cart_detailss.ToListAsync();
        }

        // GET: api/Cart_Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cart_Details>> GetCart_Details(Guid id)
        {
          if (_context.cart_detailss == null)
          {
              return NotFound();
          }
            var cart_Details = await _context.cart_detailss.FindAsync(id);

            if (cart_Details == null)
            {
                return NotFound();
            }

            return cart_Details;
        }

        // PUT: api/Cart_Details/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart_Details(Guid id, Cart_Details cart_Details)
        {
            if (id != cart_Details.Id)
            {
                return BadRequest();
            }

            _context.Entry(cart_Details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Cart_DetailsExists(id))
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

        // POST: api/Cart_Details
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cart_Details>> PostCart_Details(Cart_Details cart_Details)
        {
          if (_context.cart_detailss == null)
          {
              return Problem("Entity set 'AppDBContext.cart_detailss'  is null.");
          }
            _context.cart_detailss.Add(cart_Details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCart_Details", new { id = cart_Details.Id }, cart_Details);
        }

        // DELETE: api/Cart_Details/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart_Details(Guid id)
        {
            if (_context.cart_detailss == null)
            {
                return NotFound();
            }
            var cart_Details = await _context.cart_detailss.FindAsync(id);
            if (cart_Details == null)
            {
                return NotFound();
            }

            _context.cart_detailss.Remove(cart_Details);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Cart_DetailsExists(Guid id)
        {
            return (_context.cart_detailss?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
