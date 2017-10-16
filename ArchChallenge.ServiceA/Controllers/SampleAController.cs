using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArchChallenge.Infra.Core.ServiceInterceptor;
using Microsoft.Extensions.Logging;

namespace ArchChallenge.ServiceA.Controllers
{
    [Route("api/[controller]")]
    public class SampleAController : BaseController
    {
        public SampleAController(ILogger<SampleAController> logger) : base(logger)
        {

        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Sample", "A" };
        }

        /*
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

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
            new Application.SampleAApplication().DoSomething(RequestInfo, value);
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