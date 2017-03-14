using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string AddressLineOne { get; set; }

        public string AddressLineTwo { get; set; }

        public string AddressCity { get; set; }

        public string AddressState { get; set; }

        public string AddressZip { get; set; }

    }
}
