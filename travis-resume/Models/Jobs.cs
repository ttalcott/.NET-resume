using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Jobs : Location
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Company")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        public string jobName { get; set; }

        [Required]
        [Display(Name = "Title")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        public string jobTitle { get; set; }

        [Required]
        [Display(Name = "Job Description")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string jobDescription { get; set; }

        [Required]
        [Display(Name ="Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime jobDateHired { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime jobDateOver { get; set; }

    }
}
