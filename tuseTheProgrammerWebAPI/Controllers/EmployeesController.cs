using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using tuseTheProgrammerWebAPI.Dtos;
using tuseTheProgrammerWebAPI.Models;
using tuseTheProgrammerWebAPI.Services;

namespace tuseTheProgrammerWebAPI.Controllers
{
    [ApiController]
    [Route(template: "api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAllEmployees()
        {
            var result = _employeeRepo.GetEmployees();
            return base.Ok(_mapper.Map<IEnumerable<EmployeeReadDto>>(result));
        }

        [HttpGet(template: "{id}", Name = "GetEmployee")]
        public ActionResult<EmployeeReadDto> GetEmployee(int id)
        {
            var result = _employeeRepo.GetEmployeeById(id);
            if (result != null)
            {
                return base.Ok(_mapper.Map<EmployeeReadDto>(result));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<EmployeeReadDto> Create(EmployeeCreateDto employeeCreateDto)
        {
            var employeeModel = _mapper.Map<Employee>(employeeCreateDto);
            _employeeRepo.CreateNewEmployee(employeeModel);
            _employeeRepo.SaveChanges();

            var empReadDto = _mapper.Map<EmployeeReadDto>(employeeModel);
            return CreatedAtRoute(nameof(GetEmployee), new { Id = empReadDto.Id }, empReadDto);
          
        }
    }
}
