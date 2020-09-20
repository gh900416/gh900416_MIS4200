using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gh900416_MIS4200.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public int studentID { get; set; }
        public int classID { get; set; }
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}