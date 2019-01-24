using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace StudentDal
{
    public class EFStudent : DbContext
    {
        public EFStudent() : base("StuConnection")
        {
            
        }
        public DbSet<StudentShow> Stu { get; set; }
    }
}
