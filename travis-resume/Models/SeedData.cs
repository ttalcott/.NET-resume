using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using travis_resume.Data;

namespace TravisResume.Models
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

                context.Jobs.AddRange(
                    new Jobs
                    {

                    }
                    );
            }
        }
    }
}
