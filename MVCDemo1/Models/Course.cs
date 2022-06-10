using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
       
        public ICollection<Student> Students { get; set; }
    }
}