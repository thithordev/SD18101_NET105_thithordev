using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Bill")]
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column(TypeName = "money")]
        public decimal Total_Amount { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Bill_Details>? Bill_Detailss { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customers { get; set; }
    }
}
