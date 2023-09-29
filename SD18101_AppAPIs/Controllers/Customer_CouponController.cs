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
    public class Customer_CouponController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Customer_CouponController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Customer_Coupon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer_Coupon>>> Getcustomer_coupons()
        {
          if (_context.customer_coupons == null)
          {
              return NotFound();
          }
            return await _context.customer_coupons.ToListAsync();
        }

        // GET: api/Customer_Coupon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer_Coupon>> GetCustomer_Coupon(Guid id)
        {
          if (_context.customer_coupons == null)
          {
              return NotFound();
          }
            var customer_Coupon = await _context.customer_coupons.FindAsync(id);

            if (customer_Coupon == null)
            {
                return NotFound();
            }

            return customer_Coupon;
        }

        // PUT: api/Customer_Coupon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer_Coupon(Guid id, Customer_Coupon customer_Coupon)
        {
            if (id != customer_Coupon.Id)
            {
                return BadRequest();
            }

            _context.Entry(customer_Coupon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer_CouponExists(id))
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

        // POST: api/Customer_Coupon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer_Coupon>> PostCustomer_Coupon(Customer_Coupon customer_Coupon)
        {
          if (_context.customer_coupons == null)
          {
              return Problem("Entity set 'AppDBContext.customer_coupons'  is null.");
          }
            _context.customer_coupons.Add(customer_Coupon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer_Coupon", new { id = customer_Coupon.Id }, customer_Coupon);
        }

        // DELETE: api/Customer_Coupon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer_Coupon(Guid id)
        {
            if (_context.customer_coupons == null)
            {
                return NotFound();
            }
            var customer_Coupon = await _context.customer_coupons.FindAsync(id);
            if (customer_Coupon == null)
            {
                return NotFound();
            }

            _context.customer_coupons.Remove(customer_Coupon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Customer_CouponExists(Guid id)
        {
            return (_context.customer_coupons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
