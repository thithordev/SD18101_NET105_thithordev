using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public Guid Acc_Id { get; set; }
        public Guid RoleID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Payment_info { get; set; } = string.Empty;   
        public int Payment_type { get; set;}
        public int Status { get; set; }
        [ForeignKey(nameof(RoleID))]
        public virtual Role? Role { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
