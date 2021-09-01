using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lsfejercicio.Models;
using lsfejercicio.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lsfejercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileSystemController : ControllerBase
    {
        // GET: api/<FileSystemController>
        [HttpGet]
        [Route("carpeta")]
        public List<Carpeta> Get()
        {
            
            return new string[] { "value1", "value2" };
        }

        // GET api/<FileSystemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FileSystemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FileSystemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileSystemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
