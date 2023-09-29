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
    public class Order_CouponController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Order_CouponController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Order_Coupon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order_Coupon>>> Getorder_coupons()
        {
          if (_context.order_coupons == null)
          {
              return NotFound();
          }
            return await _context.order_coupons.ToListAsync();
        }

        // GET: api/Order_Coupon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order_Coupon>> GetOrder_Coupon(Guid id)
        {
          if (_context.order_coupons == null)
          {
              return NotFound();
          }
            var order_Coupon = await _context.order_coupons.FindAsync(id);

            if (order_Coupon == null)
            {
                return NotFound();
            }

            return order_Coupon;
        }

        // PUT: api/Order_Coupon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder_Coupon(Guid id, Order_Coupon order_Coupon)
        {
            if (id != order_Coupon.Id)
            {
                return BadRequest();
            }

            _context.Entry(order_Coupon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_CouponExists(id))
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

        // POST: api/Order_Coupon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order_Coupon>> PostOrder_Coupon(Order_Coupon order_Coupon)
        {
          if (_context.order_coupons == null)
          {
              return Problem("Entity set 'AppDBContext.order_coupons'  is null.");
          }
            _context.order_coupons.Add(order_Coupon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder_Coupon", new { id = order_Coupon.Id }, order_Coupon);
        }

        // DELETE: api/Order_Coupon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder_Coupon(Guid id)
        {
            if (_context.order_coupons == null)
            {
                return NotFound();
            }
            var order_Coupon = await _context.order_coupons.FindAsync(id);
            if (order_Coupon == null)
            {
                return NotFound();
            }

            _context.order_coupons.Remove(order_Coupon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Order_CouponExists(Guid id)
        {
            return (_context.order_coupons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
