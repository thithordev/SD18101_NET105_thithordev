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
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SinhviensController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
