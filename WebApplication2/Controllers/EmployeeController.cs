using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using EmployeeData;

namespace WebApplication2.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<EMP_Details> Get()
        {
            using(EmployeeEntities entity =new EmployeeEntities())
            {
               return entity.EMP_Details.ToList();
            }
           
        }

        // GET: api/Employee/5
        public EMP_Details Get(string id)
        {
            using (EmployeeEntities entity = new EmployeeEntities())
            {
                return entity.EMP_Details.FirstOrDefault(e => e.EMPID == id);
            }
        }

        // POST: api/Employee
        public HttpResponseMessage Post([FromBody]EMP_Details employee)
        {
            try
            {
                using (EmployeeEntities entity = new EmployeeEntities())
                {
                    entity.EMP_Details.Add(employee);
                    entity.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.EMPID);
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
