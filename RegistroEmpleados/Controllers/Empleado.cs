using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistroEmpleados.Controllers
{
    [Route("api/empleado")]
    [ApiController]
    public class Empleado : ControllerBase
    {
        // GET: api/<Empleado>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Empleado>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Empleado>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Empleado>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Empleado>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
