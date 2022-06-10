using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDemo1.Models
{
    public class StudentCouseContext:DbContext
    {
        public StudentCouseContext():base("myconnection")
        {

        }
        public DbSet<Course> Courses { get; set; }  
        public DbSet<Student> Students { get; set; }    
    }
}