using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new ();

    static Repository(){

        _courses = new List<Course>()
        {
                new Course (){Id=1,
                Title ="php kursu",
                Description="güzel bir kurs " ,
                Image ="1.jpg",
                Tags = new string[]{"aspnet","web geliştirme"},
                isActive = true,
                isHome= true},
                new Course (){Id=2,Title ="java kursu",Description="güzel bir kurs ",Image ="2.jpg" ,
                Tags = new string[]{"java","web geliştirme","native"},
                isActive = false,
                isHome= true},
                new Course (){Id=3,Title ="python kursu",Description="güzel bir kurs ",Image ="3.jpg",
                Tags = new string[]{"python","web geliştirme"},
                isActive = true,
                isHome= true},
                new Course (){Id=4,Title ="JavaScript Kursu",Description="güzel bir kurs ",Image ="4.jpg" ,
                
                isActive = true,
                isHome= false}
        };
    }
        public static List<Course> Courses {
            get {
                return _courses;
            }
        }
        public static Course? GetById (int? id){
            return _courses.FirstOrDefault (c=> c.Id == id);
        }
    }
}