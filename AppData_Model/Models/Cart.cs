using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public Guid Acc_Id { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Cart_Details>? Cart_Detailss { get; set; }
        public virtual Customer? Customer { get; set; } 

    }
}
