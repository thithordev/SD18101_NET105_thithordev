using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Role_Permission")]
    public class Role_Permission
    {
        [Key]
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        public int Status { get; set; }
        [ForeignKey(nameof(PermissionId))]
        public virtual Permission? Permission { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role? Role { get; set; }
    }
}
