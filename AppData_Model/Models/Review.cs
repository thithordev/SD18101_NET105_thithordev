using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public Guid ID { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public double Rating { get; set; }
        [Column(TypeName = "ntext")]
        public string ReviewStr { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime ReviewDate { get; set; }
        public int Status { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer? Customers { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product? Products { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
