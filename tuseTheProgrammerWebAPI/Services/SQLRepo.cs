using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerWebAPI.Models;

namespace tuseTheProgrammerWebAPI.Services
{
    public class SQLRepo : IEmployeeRepo
    {
        private readonly AppDbContext _appDbContext;

        public SQLRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateNewEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _appDbContext.Employees.Add(employee);
        
        }

        public Employee GetEmployeeById(int id)
        {
            return _appDbContext.Employees.Find(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _appDbContext.Employees.ToList();
        }

        public bool SaveChanges()
        {
            return (_appDbContext.SaveChanges() >= 0);
        }
    }
}
