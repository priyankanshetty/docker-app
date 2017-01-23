using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACSSampleAppMS2.Controllers
{
    public class DepartmentController : ApiController
    {
        public IEnumerable<Department> GetDepartments()
        {
            DAL dal = new DAL();
            return dal.GetDepartments();
        }
    }
}
