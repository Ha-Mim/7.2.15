using System.Collections.Generic;
using MVCDatabaseProject.Models;

namespace MVCDatabaseProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDatabaseProject.Models.ProjectDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCDatabaseProject.Models.ProjectDb context)
        {
            var students = new List<Student>
            {
                new Student { Name = "Ha-Mim",   Email = "h@gmail.com", 
                    Address = "Dhaka" },
                new Student { Name = "Pial",   Email = "p@gmail.com", 
                    Address = "Manikgong" },
               
            };
            students.ForEach(s => context.Students.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
