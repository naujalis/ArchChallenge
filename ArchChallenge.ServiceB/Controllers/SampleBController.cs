using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArchChallenge.Infra.Core.ServiceInterceptor;

namespace ArchChallenge.ServiceB.Controllers
{
    [Route("api/[controller]")]
    public class SampleBController : BaseController
    {
        public SampleBController(ILogger<SampleBController> logger) : base(logger)
        {
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Sample", "B" };
        }

        /*
        // GET api/values
        

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        /*
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
        */
    }
}