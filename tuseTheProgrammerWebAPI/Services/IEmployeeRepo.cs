using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerWebAPI.Models;

namespace tuseTheProgrammerWebAPI.Services
{
    public interface IEmployeeRepo
    {
         IEnumerable<Employee> GetEmployees();
    }
}

