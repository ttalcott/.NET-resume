using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using travis_resume.Data;

namespace travis_resume.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
               new ApplicationDbContext
               (serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //look for any records, if there are records do nothing
                if (context.Jobs.Any())
                {
                    return;
                }
                //add a job 
                context.Jobs.AddRange(
                    new Jobs
                    {
                        companyName = "Aquila Technologies",
                        jobTitle = "Assistant Network Engineer",
                        jobDescription = "Networking assistant in charge of configuring switches and installing cables",
                        dateHired = DateTime.Parse("05-22-2013"),
                        dateOver = DateTime.Parse("02-01-2014")
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
