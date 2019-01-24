using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDalShow;

namespace StudentDal
{
    public class StuDal : IStudent
    {
        public List<StudentShow> ShowStudent()
        {
            EFStudent stu = new EFStudent();
            var list = stu.Stu.ToList();
            return list;          
        }
    }
}
