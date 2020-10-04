using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace gh900416_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display (Name ="Last Name")]
        [Required(ErrorMessage ="Last Name Required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        public ICollection<Class> classes { get; set; }
    }
}