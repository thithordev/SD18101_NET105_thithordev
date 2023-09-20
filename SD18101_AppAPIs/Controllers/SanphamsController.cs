using AppsData.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SD18101_AppAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamsController : ControllerBase
    {
        // GET: api/<SanphamsController>
        [HttpGet("get-all-sanphams")]
        public IEnumerable<Sanpham> Get()
        {
            // Fake list data
            return new List<Sanpham>()
            {
                new Sanpham{ Id = Guid.NewGuid(), Name="Sữa",
                    Description="Ngon", Price=1000, Status=1  },
                new Sanpham{ Id = Guid.NewGuid(), Name="Bánh",
                    Description="Ngon", Price=1000, Status=1  },
                new Sanpham{ Id = Guid.NewGuid(), Name="Kem",
                    Description="Ngon", Price=1000, Status=1  },
                new Sanpham{ Id = Guid.NewGuid(), Name="Muối",
                    Description="Ngon", Price=1000, Status=1  }
            };
        }

        // GET api/<SanphamsController>/5
        [HttpGet("get-sanphams-{id}")]
        public Sanpham GetById(Guid id)
        {
            return new Sanpham
            {
                Id = Guid.NewGuid(),
                Name = "Sữa",
                Description = "Ngon",
                Price = 1000,
                Status = 1
            };
        }

        // POST api/<SanphamsController>
        [HttpPost("post-by-obj")]
        public void PostByObj([FromBody] Sanpham s)
        {
            // Đoạn này chỉ việc add vào cơ sở dữ liệu thôi
        }
        [HttpPost("post-by-params")]
        public void PostByParams([FromBody] Guid id, string name, 
            string description, long price, int status)
        {
            // Đoạn này có thể kiểm tra dữ liệu, validate, sau đó tạo 1 đối tượng mới để thêm vào db
            Sanpham s = new Sanpham
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price,
                Status = status
            };
            // Đoạn sau thì thêm vào db
        }

        // PUT api/<SanphamsController>/5
        [HttpPut("{id}")] // Truyền param - hàm này chỉ cho phép they tên
        public void PutNameById(Guid id, [FromBody] string name)
        {
            // Bước 1: Lấy đối tượng từ db thông qua id
            // Bước 2: Thay tên đổi họ
            // Bước 3: Lưu lại
        }
        [HttpPut("{id}-obj")] // Truyền param - hàm này chỉ cho phép they tên
        public void PutNameByObj(Guid id, [FromBody] Sanpham s)
        {
            // Bước 1: Lấy đối tượng từ db thông qua id
            // Bước 2: Thay dữ liệu
            // Bước 3: Lưu lại
        }

        // DELETE api/<SanphamsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
        // Không nên xóa các sản phẩm đã bán vì nó là hành động phi pháp
    }
}
