using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACSSampleApp.Controllers
{
    public class PersonController : ApiController
    {
        public IEnumerable<Person>  GetPersons()
        {
            DAL dal = new DAL();
            return dal.GetPersons();
        }
    }
}
