using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Education : Address
    {
        public int EducationId { get; set; }

        [Required]
        public string EducationName { get; set; }

        public string EducationLevel { get; set; }


    }
}
