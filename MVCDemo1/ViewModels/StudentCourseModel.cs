using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo1.Models;

namespace MVCDemo1.ViewModels
{
    public class StudentCourseModel
    {
        public Student Student1 { get; set; }
        public Course Course { get; set; }
        public string Title { get; set; }
    }
}