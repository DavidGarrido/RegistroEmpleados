using Microsoft.AspNetCore.Mvc;
using RegistroEmpleados.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistroEmpleados.Controllers
{
    [Route("api/empleado")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly aplicationDbContext _context;

        public EmpleadoController(aplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<Empleado>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listEmpleados = await _context.Empleado.Include(e => e.Cargo).Include(e => e.Salario).ToListAsync();
                return Ok(listEmpleados);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<Empleado>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var empleado = await _context.Empleado.Include(e => e.Cargo).Include(e => e.Salario).FirstOrDefaultAsync(i => i.Id == id);

                if (empleado == null)
                    return NotFound();
                return Ok(empleado);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<Empleado>
        [HttpPost]
        public async Task<IActionResult> Post(Empleado empleado)
        {
            try
            {
                empleado.FechaCreacion = DateTime.Now;
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new {id = empleado.Id}, empleado);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
