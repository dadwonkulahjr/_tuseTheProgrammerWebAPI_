using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerWebAPI.Models;

namespace tuseTheProgrammerWebAPI.Services
{
    public class ManageEmployeeData : IEmployeeRepo
    {
        private List<Employee> _employees;

        public ManageEmployeeData()
        {
            _employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 101,
                    Name = "Mike",
                    Email = "mike@gmail.com",
                    Department = Department.Dept.IT,
                    Salary = 16000
                },

                new Employee()
                {
                    Id = 102,
                    Name = "Bob",
                    Email = "bob@outlook.com",
                    Department = Department.Dept.IT,
                    Salary = 20000
                },

                new Employee()
                {
                    Id = 103,
                    Name = "Mary",
                    Email = "mary@yahoo.com",
                    Department = Department.Dept.HR,
                    Salary = 7000
                },

                 new Employee()
                {
                    Id = 104,
                    Name = "Princess",
                    Email = "pricess@hotmail.com",
                    Department = Department.Dept.Payroll,
                    Salary = 6700
                },
            };
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees.ToList();
        }
    }
}
