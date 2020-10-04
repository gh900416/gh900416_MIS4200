using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gh900416_MIS4200.Models
{
    public class Class
    {
        public int classID { get; set; }

        public string title { get; set; }

        public string description { get; set; }
        public virtual Student Student { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        public int professorID { get; set; }
    }
}