using AppsData.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SD18101_AppAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhviensController : ControllerBase
    {
        public AppDbContext context = new AppDbContext();
        // GET: api/<SinhviensController>
        [HttpGet]
        public IEnumerable<Sinhvien> GetAll()
        {
            return context.sinhviens.ToList();
        }

        // GET api/<SinhviensController>/5
        [HttpGet("get-by-id")]
        public Sinhvien GetById(Guid id)
        {
            return context.sinhviens.Find(id);
        }
        [HttpGet("get-by-name")]
        public IEnumerable<Sinhvien> GetByName(string name)
        {
            return context.sinhviens.Where(p=>p.Name.Contains(name)).ToList(); 
        }

        // POST api/<SinhviensController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] Sinhvien sinhvien)
        {
            try
            {
                context.sinhviens.Add(sinhvien);
                context.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost("post-by-params")]
        public bool PostByParams(string Name, string Description, string Email, 
            string PhoneNumber, DateTime DoB, string Address, int Major)
        {
            Guid id = Guid.NewGuid();
            Sinhvien sinhvien = new Sinhvien
            {
                Id = id, Name = Name, Description = Description,
                Email = Email, PhoneNumber = PhoneNumber, DoB = DoB,
                Address = Address, Major = Major
            };
            try{
                context.sinhviens.Add(sinhvien);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<SinhviensController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SinhviensController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
