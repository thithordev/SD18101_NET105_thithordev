using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Coupon")]
    public class Coupon
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Code { get; set; } = string.Empty;
        public int Discount_Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Expiration_Date { get; set; }
        public int Conditions { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public ICollection<Customer_Coupon>? Customer_Coupons { get; set; }
        public ICollection<Order_Coupon>? Order_Coupons { get; set; }
    }
}
