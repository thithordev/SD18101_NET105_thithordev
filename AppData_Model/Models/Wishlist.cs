using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Wishlist")]
    public class Wishlist
    {
        [Key]
        public Guid ID { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string WishlistName { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeletedDate { get; set; }
        public int Status { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }
    }
}
