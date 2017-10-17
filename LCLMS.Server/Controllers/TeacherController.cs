using LCLMS.Model.Teachers;
using LCLMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LCLMS.Server.Controllers
{
    public class TeacherController : ApiController
    {
        public IHttpActionResult Post(Teacher teacher)
        {

            TeacherService service = new TeacherService();
            var add = service.Add(teacher);
            return this.Ok(add);
        }
    }
}
