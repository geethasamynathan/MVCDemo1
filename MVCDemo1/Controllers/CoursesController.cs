using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo1.Models;

namespace MVCDemo1.Controllers
{
    public class CoursesController : Controller
    {
        StudentCouseContext context = new StudentCouseContext();
        // GET: Courses
        public ActionResult Index()
        {
            List<Course> Courselist = new List<Course>();
            Courselist = context.Courses.ToList();
            return View(Courselist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Course course = new Course();
            return View();

        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            //StudentCouseContext context = new StudentCouseContext();
            context.Courses.Add(course);
            context.SaveChanges();
            return  RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Course course = context.Courses.Find(id);
            return View(course);

        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            Course course1 = context.Courses.Find( course.CourseId);
            course1.Name = course.Name;
            context.Entry(course1).State= System.Data.Entity.EntityState.Modified;
            
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Course course = context.Courses.Find(id);
            return View(course);

        }

       

    }
}