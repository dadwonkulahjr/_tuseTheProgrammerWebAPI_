using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tuseTheProgrammerWebAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        [Required]
        public decimal Salary { get; set; }
        public string Email { get; set; }
        [Required]
        public Department.Dept Department { get; set; }
    }
}
