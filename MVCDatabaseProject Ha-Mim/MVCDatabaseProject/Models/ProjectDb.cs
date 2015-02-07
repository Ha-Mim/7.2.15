using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDatabaseProject.Models
{
    public class ProjectDb:DbContext
    {
    public ProjectDb():base()
    {
        
    }
    public DbSet<Student> Students { set; get; }
    }
}