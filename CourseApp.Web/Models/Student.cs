using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        [EmailAddress(ErrorMessage = "Email Giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Telefon Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "WillAttend Giriniz")]
        public bool? WillAttend { get; set; }   //?= nullable demek

    }
}
