using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
      static List<Employee> eList = new List<Employee>() 
            {
            new Employee{FirstName= "Aditya", LastName= "Bokade", Age = 34},

            new Employee{FirstName= "Anjan", LastName= "Gonti", Age = 24},

             new Employee{ FirstName = "grapy", LastName = "khanna", Age = 7 },
            };
        public IEnumerable<Employee> Get()
        {
          return eList;
        }

        // GET api/values/5
        public Employee Get(int id)
        {
            return eList[id];
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] Employee emp)
        {
                 eList.Add(emp);
                  return Ok();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
           eList.RemoveAt(id);
            return Ok();
        }
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

        }
    }
}
