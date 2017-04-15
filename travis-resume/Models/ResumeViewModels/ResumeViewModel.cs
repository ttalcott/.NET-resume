using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travis_resume.Models.ResumeViewModels
{
    public class ResumeViewModel
    {
        public int Id { get; set; }
        public Person Contact { get; set; }

        public IEnumerable<Jobs> Job { get; set; }
        public IEnumerable<Education> Schools { get; set; }
    }
}
