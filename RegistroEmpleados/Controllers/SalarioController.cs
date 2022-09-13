using Microsoft.AspNetCore.Mvc;
using RegistroEmpleados.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistroEmpleados.Controllers
{
    [Route("api/salario")]
    [ApiController]
    public class SalarioController : ControllerBase
    {

        private readonly aplicationDbContext _context;
        public SalarioController(aplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<SalarioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SalarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SalarioController>
        [HttpPost]
        public async Task<IActionResult> Post(Salario salario)
        {
            try
            {
                _context.Add(salario);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = salario.Id }, salario);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        // PUT api/<SalarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
