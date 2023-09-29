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
    public class Order_DetailsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Order_DetailsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Order_Details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order_Details>>> Getorder_detailss()
        {
          if (_context.order_detailss == null)
          {
              return NotFound();
          }
            return await _context.order_detailss.ToListAsync();
        }

        // GET: api/Order_Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order_Details>> GetOrder_Details(Guid id)
        {
          if (_context.order_detailss == null)
          {
              return NotFound();
          }
            var order_Details = await _context.order_detailss.FindAsync(id);

            if (order_Details == null)
            {
                return NotFound();
            }

            return order_Details;
        }

        // PUT: api/Order_Details/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder_Details(Guid id, Order_Details order_Details)
        {
            if (id != order_Details.Id)
            {
                return BadRequest();
            }

            _context.Entry(order_Details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_DetailsExists(id))
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

        // POST: api/Order_Details
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order_Details>> PostOrder_Details(Order_Details order_Details)
        {
          if (_context.order_detailss == null)
          {
              return Problem("Entity set 'AppDBContext.order_detailss'  is null.");
          }
            _context.order_detailss.Add(order_Details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder_Details", new { id = order_Details.Id }, order_Details);
        }

        // DELETE: api/Order_Details/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder_Details(Guid id)
        {
            if (_context.order_detailss == null)
            {
                return NotFound();
            }
            var order_Details = await _context.order_detailss.FindAsync(id);
            if (order_Details == null)
            {
                return NotFound();
            }

            _context.order_detailss.Remove(order_Details);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Order_DetailsExists(Guid id)
        {
            return (_context.order_detailss?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
