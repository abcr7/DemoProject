using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        static List<Student> studlst = new List<Student>()
        {
             new Student(){Id=1,Name="Cristiano Ronaldo", BirthDate=05021985,Email="Cr7@gmail.com",ContactNo="7777777777",HighestEducation="GOAT"},
                new Student(){Id=2,Name="Lionel Messi", BirthDate=24061987,Email="Messi@gmail.com",ContactNo="1010101010",HighestEducation="Tiki-Taka"},
        };
    
        // GET: Student
        public ActionResult Index()
        {
            studlst.OrderBy(e => e.Id);
            return View(studlst);
        }

        // GET: Student/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = studlst.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        // GET: Student/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            studlst.Add(student);
            return RedirectToAction("Index");
            
        }

        // GET: Student/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = studlst.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            Student dbStudent = studlst.Where(x => x.Id == student.Id).FirstOrDefault();
            studlst.Remove(dbStudent);
            dbStudent = student;
            studlst.Add(dbStudent);
            studlst.OrderBy(e => e.Id);
            return RedirectToAction("Index");
            
        }

        // GET: Student/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = studlst.Where(x => x.Id == id).FirstOrDefault();
            studlst.Remove(model);
            return RedirectToAction("Index");
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
           
                return View();
           
        }
    }
}
