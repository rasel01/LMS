using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LCLMS.Model.Students;
using LCLMS.RequestModel;
using LCLMS.Service;

namespace LCLMS.Server.Controllers
{
    public class StudentQueryController : ApiController
    {
        private StudentService service;

        public StudentQueryController()
        {
            this.service = new StudentService();
        }
        
        public IHttpActionResult Post(StudentRequestModel request)
        {
            List<Student> students = service.Search(request);
            return this.Ok(students);
        }
    }
}
