using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "You must enter a Name for Student")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        [EmailAddress(ErrorMessage = " Email do not math suitable format")]
        public string Email { get; set; } = string.Empty;
        //[Phone]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")]
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DoB {  get; set; }
        public string Address { get; set; } = string.Empty;
        public int Major { get; set; }
        //public string EmailAddress { get; set; } = string.Empty;

        //public string Phone { get; set; }
        //public string City { get; set; }
        //public string Region { get; set; } = string.Empty;
        //public string PostalCode { get; set; } = string.Empty;
        //public string Country { get; set; } = string.Empty;
        
    }
}
