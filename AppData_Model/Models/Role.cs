using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; }
        public virtual ICollection<Role_Permission>? Role_Permissions { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }

    }
}
