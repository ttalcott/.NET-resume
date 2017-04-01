using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Hardware : Skills
    {
        public int HardwreId { get; set; }

        [Required]
        public string HardwareName { get; set; }
    }
}
