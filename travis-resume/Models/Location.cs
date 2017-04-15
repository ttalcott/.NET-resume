using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Location
    {
        public int AddressId { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Address Line One")]
        public string AddressLineOne { get; set; }

        [StringLength(60)]
        [Display(Name = "Address Line Two")]
        public string AddressLineTwo { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        [Display(Name = "City")]
        public string AddressCity { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(2)]
        [Display(Name = "State")]
        public string AddressState { get; set; }

        [Required]
        [Display(Name = "Zip")]
        public string AddressZip { get; set; }

    }
}
