using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using StudentDal;

namespace TestShow.Controllers
{
    public class StudentController : ApiController
    {
        
        StuDal stu = new StuDal();
        [HttpGet]
        public List<StudentShow> ShowStudent()
        {
            var list = stu.ShowStudent();
            return list;
        }
    }
}
