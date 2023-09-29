using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Order_Coupon")]
    public class Order_Coupon
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid CouponId { get; set; }
        public int Status { get; set; }
        [ForeignKey(nameof(OrderId))]
        public virtual Order? Order { get; set; }
        [ForeignKey(nameof(CouponId))]
        public virtual Coupon? Coupon { get; set; }
    }
}
