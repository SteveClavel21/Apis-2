using GSMC20240903.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GSMC20240903.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnsController : ControllerBase
    {
        static List<Alumnos> alumnos = new List<Alumnos>();

        // GET: api/<AlumnsController>
        [HttpGet]
        public IEnumerable<Alumnos> Get()
        {
            return alumnos;
        }

        // GET api/<AlumnsController>/5
        [HttpGet("{id}")]
        public Alumnos Get(int id)
        {
            var alumno = alumnos.FirstOrDefault(c => c.Id == id);
            return alumno;
        }

        // POST api/<AlumnsController>
        [HttpPost]
        public IActionResult Post([FromBody] Alumnos alumno)
        {
            alumnos.Add(alumno);
            return Ok();
        }

        // PUT api/<AlumnsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumnos alumno)
        {
            var existingAlumno = alumnos.FirstOrDefault(c => c.Id == id);
            if (existingAlumno != null)
            {
                existingAlumno.Nombre = alumno.Nombre;
                existingAlumno.Apellido = alumno.Apellido;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<AlumnsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingAlumno = alumnos.FirstOrDefault(c => c.Id == id);
            if (existingAlumno != null)
            {
                alumnos.Remove(existingAlumno);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
