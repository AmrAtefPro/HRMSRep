using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Emial { get; set; }
        public string Address { get; set; }            
    }
}
