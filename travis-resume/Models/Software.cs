using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Software : Skills
    {
        public int SoftwareId { get; set; }

        [Required]
        public string SoftwareName { get; set; }
    }
}
