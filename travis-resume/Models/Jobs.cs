using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravisResume.Models
{
    public class Jobs
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Job Description")]
        public string JobDescription { get; set; }

        [Required]
        [Display(Name ="Date Hired")]
        public string DateHired { get; set; }


    }
}
