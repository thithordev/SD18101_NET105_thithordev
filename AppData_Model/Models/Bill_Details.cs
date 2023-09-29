using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Bill_Details")]
    public class Bill_Details
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Status { get; set; }
        [ForeignKey(nameof(BillId))]
        public virtual Bill? Bill { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product? Product { get; set; }
    }
}
