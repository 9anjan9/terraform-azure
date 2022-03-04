using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        List<Employee> eList = new List<Employee>()
        {
            new Employee { FirstName = "Anjan",LastName = "Gonti", Age = 24},

            new Employee { FirstName = "bharath",LastName = "ss", Age = 23},

            new Employee { FirstName = "Aditya",LastName = "abc", Age = 45},
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
