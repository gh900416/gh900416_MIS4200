using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gh900416_MIS4200.Models
{
    public class Class
    {
        [Required(ErrorMessage ="ClassID required")]
        public int classID { get; set; }
        [Display (Name ="Course Name")]
        [Required(ErrorMessage ="Course Name required")]
        [StringLength(20)]
        public string title { get; set; }
        [Display (Name ="Description")]
        public string description { get; set; }
        public virtual Student Student { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        public int professorID { get; set; }
    }
}