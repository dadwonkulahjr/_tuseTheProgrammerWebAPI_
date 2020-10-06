using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuseTheProgrammerWebAPI.Models
{
    public class Department
    {
        public enum Dept : int
        {
            IT = 1,
            HR = 2,
            Payroll = 3,
            Management = 4
        }
    }
}
