using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    public class LunchController: Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Lunch> Get()
        {
            return new Lunch[]
            { new Lunch { Name = "Caroline", Time = 11, Duration = 1},
             new Lunch { Name = "Laura", Time = 11, Duration = 1 },
             new Lunch { Name = "Natasha", Time = 12, Duration = 1} };


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
