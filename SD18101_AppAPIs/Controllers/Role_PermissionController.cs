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
    public class Role_PermissionController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Role_PermissionController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Role_Permission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role_Permission>>> Getrole_permissions()
        {
          if (_context.role_permissions == null)
          {
              return NotFound();
          }
            return await _context.role_permissions.ToListAsync();
        }

        // GET: api/Role_Permission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Role_Permission>> GetRole_Permission(Guid id)
        {
          if (_context.role_permissions == null)
          {
              return NotFound();
          }
            var role_Permission = await _context.role_permissions.FindAsync(id);

            if (role_Permission == null)
            {
                return NotFound();
            }

            return role_Permission;
        }

        // PUT: api/Role_Permission/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole_Permission(Guid id, Role_Permission role_Permission)
        {
            if (id != role_Permission.Id)
            {
                return BadRequest();
            }

            _context.Entry(role_Permission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Role_PermissionExists(id))
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

        // POST: api/Role_Permission
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Role_Permission>> PostRole_Permission(Role_Permission role_Permission)
        {
          if (_context.role_permissions == null)
          {
              return Problem("Entity set 'AppDBContext.role_permissions'  is null.");
          }
            _context.role_permissions.Add(role_Permission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRole_Permission", new { id = role_Permission.Id }, role_Permission);
        }

        // DELETE: api/Role_Permission/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole_Permission(Guid id)
        {
            if (_context.role_permissions == null)
            {
                return NotFound();
            }
            var role_Permission = await _context.role_permissions.FindAsync(id);
            if (role_Permission == null)
            {
                return NotFound();
            }

            _context.role_permissions.Remove(role_Permission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Role_PermissionExists(Guid id)
        {
            return (_context.role_permissions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
