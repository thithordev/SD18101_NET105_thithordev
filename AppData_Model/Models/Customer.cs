using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public Guid Acc_Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(150)")]
        public string Address { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Column(TypeName = "varchar(20)")]
        [Phone]
        public string Phone { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(150)")]
        public string Shipping_Address { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(150)")]
        public string Billing_Address { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime Birthday { get; set; }
        public int Gender { get; set; } 
        public int Status { get; set; }
        public virtual Account? Account { get; set; } = null!;
        public virtual Cart? Cart { get; set; } = null!;
        public virtual ICollection<Customer_Coupon>? Customer_Coupons { get; set; }
        public virtual ICollection<Bill>? Bills { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Wishlist>? Wishlists { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
