using AppData_Model.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SD18101_AppAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public AppDBContext context = new AppDBContext();   
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return context.students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student GetByID(Guid id)
        {
            return context.students.Find(id);
        }

        [HttpGet("{name}")]
        public IEnumerable<Student> GetByName(string name)
        {
            return context.students.Where(p => p.Name.Contains(name)).ToList();
        }

        // POST api/<StudentsController>
        [HttpPost("Post-by-Obj")]
        public bool PostbyObj([FromBody] Student student)
        {
            try
            {
                context.students.Add(student);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;                
            }
        }

        [HttpPost("Post-by-Prams")]
        public bool PostbyPrams(string Name, string Description, string email, string phoneNumber, DateTime Dob, string Address, int Major)
        {
            Student st = new Student()
            {
                Id = Guid.NewGuid(),
                Name = Name,
                Description = Description,
                Email = email,
                PhoneNumber = phoneNumber,
                DoB = Dob,
                Address = Address,
                Major = Major
            };
            try
            {
                context.students.Add(st);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // PUT api/<StudentsController>/5
        [HttpPut("put-by-obj")]
        public bool PutbyObj([FromBody] Student student)
        {
            Student st = context.students.Find(student.Id);
            st.Name = student.Name;
            st.Description = student.Description;
            st.Email = student.Email;
            st.PhoneNumber = student.PhoneNumber;
            st.DoB = student.DoB;
            st.Address = student.Address;
            st.Major = student.Major;
            try
            {
                context.students.Update(st);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        [HttpPut("put-by-prams/{id}")]
        public bool PutbyPrams(int id, string Name, string Description, string email, string phoneNumber, DateTime Dob, string Address, int Major)
        {
            Student st = context.students.Find(id);
            st.Name = Name;
            st.Description = Description;
            st.Email = email;
            st.PhoneNumber = phoneNumber;
            st.DoB = Dob;
            st.Address = Address;
            st.Major = Major;
            try
            {
                context.students.Update(st);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                context.students.Remove(context.students.Find(id));
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
