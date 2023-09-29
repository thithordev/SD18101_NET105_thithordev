using AppData_Model.Models;
using Microsoft.AspNetCore.Mvc;
using static AppData_Model.Models.SanPham;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SD18101_AppAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        // GET: api/<SanPhamController>
        [HttpGet("get-all-sanphams")]
        public IEnumerable<SanPham> Get()
        {
            return new List<SanPham>()
            {
                new SanPham{ Id = Guid.NewGuid(), Name="Sữa",
                    Description="Ngon", Price=1000, Status=1  },
                new SanPham{ Id = Guid.NewGuid(), Name="Bánh",
                    Description="Ngon", Price=1000, Status=1  },
                new SanPham{ Id = Guid.NewGuid(), Name="Kem",
                    Description="Ngon", Price=1000, Status=1  },
                new SanPham{ Id = Guid.NewGuid(), Name="Muối",
                    Description="Ngon", Price=1000, Status=1  }
            };
        }

        // GET api/<SanPhamController>/5
        [HttpGet("get-sanpham-{id}")]
        public SanPham GetById(int id)
        {
            return new SanPham
            {
                Id = Guid.NewGuid(),
                Name = "Sữa",
                Description = "Ngon",
                Price = 1000,
                Status = 1
            };
        }

        // POST api/<SanPhamController>
        [HttpPost("post-by-obj")]
        public void PostByObj([FromBody] SanPham sp)
        {

        }

        [HttpPost("post-by-params")]

        /*
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long Price { get; set; }
        public int Status { get; set; }
        */
        public void PostByPrams([FromBody] Guid id, string Name,
          string Description, long Price, int Status)
        {
            // Kiểm tra dữ liệu và validation ==> Tạo obj ms để add to dbcontext
            SanPham s = new SanPham
            {
                Id = id,
                Name = Name,
                Description = Description,
                Price = Price,
                Status = Status
            };

        }

        // PUT api/<SanPhamController>/5
        [HttpPut("{id}")] // Truyền Prams = Hàm này chỉ cho phép thay tên
        public void PutNameById(Guid id, [FromBody] string Name)
        {
            // Bước 1: Lấy đối tượng từ db thông qua id
            // Bước 2: Thay tên đổ họ
            // Bước 3: Lưu lại
        }
        [HttpPut("{id}-obj")] // Truyền obj = Hàm này chỉ cho phép thay tên
        public void PutNameByObj(Guid id, [FromBody] SanPham sp)
        {
            // Bước 1: Lấy đối tượng từ db thông qua id
            // Bước 2: Thay dữ liệu
            // Bước 3: Lưu lại
        }

        // DELETE api/<SanPhamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
