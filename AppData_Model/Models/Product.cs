using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "ntext")]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Specifications { get; set; } = string.Empty;
        public string Materials { get; set; } = string.Empty;
        public string Dimensions { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeletedDate { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Category_Product>? Category_Products { get; set; }
        public virtual ICollection<Bill_Details>? Bill_Detailss { get; set; }
        public virtual ICollection<Wishlist>? Wishlists { get; set; }
        public virtual ICollection<Cart_Details>? Cart_Detailss { get; set; }
        public virtual ICollection<Order_Details>? Order_Detailss { get; set; }
    }
}
