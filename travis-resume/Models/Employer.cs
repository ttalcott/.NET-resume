using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Employer : Address
    {
        public int EmployerId { get; set; }

        public string EmployerName { get; set; }

        public string EmployerDuties { get; set; }
    }
}
