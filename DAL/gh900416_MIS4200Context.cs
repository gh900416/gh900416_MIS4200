using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using gh900416_MIS4200.Models;

namespace gh900416_MIS4200.DAL
{
    public class gh900416_MIS4200Context : DbContext
    {
        public gh900416_MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
    }
}