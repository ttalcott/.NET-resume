using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Education : Location
    {
        public int EducationId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        [Display(Name ="Institution")]
        public string EducationName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        [Display(Name = "Level")]
        public string EducationLevel { get; set; }

        [Display(Name = "Description")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string EducationDescription { get; set; }

        public int PersonId { get; set; }
        [ForeignKey("PersonId")]

        public virtual Person People { get; set; }
    }
}
