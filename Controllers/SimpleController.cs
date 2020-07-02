using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleController : ControllerBase
    {
        public SimpleController()
        {
        }

        // GET api/simple
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new string[] { "Namchok" };
        }

        // GET api/simple/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return "value " + id;
        }

        // POST api/simple
        [HttpPost("")]
        public void Poststring(string value)
        {
        }

        // PUT api/simple/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/simple/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}