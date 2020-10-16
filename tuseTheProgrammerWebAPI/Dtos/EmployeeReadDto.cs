using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerWebAPI.Models;

namespace tuseTheProgrammerWebAPI.Dtos
{
    public class EmployeeReadDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        //public Department.Dept Department { get; set; }
    }
}
