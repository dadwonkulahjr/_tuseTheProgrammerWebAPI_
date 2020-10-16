using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerWebAPI.Dtos;
using tuseTheProgrammerWebAPI.Models;

namespace tuseTheProgrammerWebAPI.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Employee, EmployeeReadDto>();
            CreateMap<EmployeeCreateDto, Employee>();
        }
    }
}
