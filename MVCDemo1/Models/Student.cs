using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage =" Enter the Name")]
        public string Name { get; set; }
        public string Gender { get; set; }
       
        public Course Course { get; set; }
    }
} 