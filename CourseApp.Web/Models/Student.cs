using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Web.Models
{
    public class Student
    {

        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }   //?= nullable demek

    }
}
