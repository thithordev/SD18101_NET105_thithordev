using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Customer_Coupon")]
    public class Customer_Coupon
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CouponID { get; set; }
        public int Status { get; set; }
        [ForeignKey(nameof(CouponID))]
        public virtual Coupon? Coupon { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public virtual Customer? Customer { get; set; }

    }
}
