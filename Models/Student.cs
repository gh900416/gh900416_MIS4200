using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gh900416_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public ICollection<Class> classes { get; set; }
    }
}