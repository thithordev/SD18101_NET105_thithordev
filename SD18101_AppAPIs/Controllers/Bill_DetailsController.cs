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
    public class Bill_DetailsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Bill_DetailsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Bill_Details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bill_Details>>> Getbill_detailss()
        {
          if (_context.bill_detailss == null)
          {
              return NotFound();
          }
            return await _context.bill_detailss.ToListAsync();
        }

        // GET: api/Bill_Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bill_Details>> GetBill_Details(Guid id)
        {
          if (_context.bill_detailss == null)
          {
              return NotFound();
          }
            var bill_Details = await _context.bill_detailss.FindAsync(id);

            if (bill_Details == null)
            {
                return NotFound();
            }

            return bill_Details;
        }

        // PUT: api/Bill_Details/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBill_Details(Guid id, Bill_Details bill_Details)
        {
            if (id != bill_Details.Id)
            {
                return BadRequest();
            }

            _context.Entry(bill_Details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Bill_DetailsExists(id))
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

        // POST: api/Bill_Details
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bill_Details>> PostBill_Details(Bill_Details bill_Details)
        {
          if (_context.bill_detailss == null)
          {
              return Problem("Entity set 'AppDBContext.bill_detailss'  is null.");
          }
            _context.bill_detailss.Add(bill_Details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBill_Details", new { id = bill_Details.Id }, bill_Details);
        }

        // DELETE: api/Bill_Details/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBill_Details(Guid id)
        {
            if (_context.bill_detailss == null)
            {
                return NotFound();
            }
            var bill_Details = await _context.bill_detailss.FindAsync(id);
            if (bill_Details == null)
            {
                return NotFound();
            }

            _context.bill_detailss.Remove(bill_Details);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Bill_DetailsExists(Guid id)
        {
            return (_context.bill_detailss?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
