using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(60)]
        public string PersonFirstName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        public string PersonLastName { get; set; }

        public string PersonFullName
        {
            get
            {
                return PersonFirstName + " " + PersonLastName;
            }
        }


        public string PersonEmail { get; set; }

        public string PersonPhone { get; set; }


    }
}
