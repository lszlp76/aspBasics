using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using basics.Models;

namespace basics.Controllers;


    
    public class CourseController : Controller
    {       
        
       
         public IActionResult Details(int? id)
        {

            if (id== null){
                // return Redirect("/course/list");
                return RedirectToAction("List","Course");
            }
            var kurs = Repository.GetById(id);
            return View(kurs);
        }
        
        public IActionResult List()
         {
            return View("CourseList",Repository.Courses);
            /* REPOSİTORY CLASS ı yaratınce buraya gerek kalmadı
               var kurslar = new List<Course>
            {
                new Course (){Id=2,Title ="php kursu",Description="güzel bir kurs " ,Image ="1.jpg"},
                new Course (){Id=3,Title ="java kursu",Description="güzel bir kurs ",Image ="2.jpg" },
                new Course (){Id=4,Title ="python kursu",Description="güzel bir kurs ",Image ="3.jpg" },
                
            };
             return View("CourseList",kurslar);
            }
            */


         
    }
    
}
