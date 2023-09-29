using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public Guid ID { get; set; }
        public Guid ReviewId { get; set; }
        [Column(TypeName = "ntext")]
        public string CommentStr { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime CommentDate { get; set; }
        public int Status { get; set; }
        [ForeignKey("ReviewId")]
        public virtual Review? Review { get; set; }

    }
}
