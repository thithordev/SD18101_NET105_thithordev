using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsData.Models
{
    public class Sanpham
    {
        // Trong Data Anotation chúng ta có thể thực hiện được validate
        // cho thuộc tính của đối tượng
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public int Status { get; set; }

    }
}
