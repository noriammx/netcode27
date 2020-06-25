using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPINetCode27.Model;

namespace WebAPINetCode27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<Persona> Get()
        {

            List<Persona> personas = new List<Persona>();
            
            Persona p = new Persona();
            p.ApMaterno = "Candelero";
            p.ApPaterno = "Martínez";
            p.Edad = 33;
            p.Id = 1;
            p.Nombre = "Luis Marino";

            personas.Add(p);

            p = new Persona();
            p.ApMaterno = "Alvarez";
            p.ApPaterno = "Falcón";
            p.Edad = 30;
            p.Id = 2;
            p.Nombre = "Jorge Alejandro";

            personas.Add(p);

            return personas;
        }

        // GET: api/Persona/5
        [HttpGet("{id}", Name = "Get")]
        public Persona Get(int id)
        {
            List<Persona> personas = new List<Persona>();

            Persona p = new Persona();
            p.ApMaterno = "Candelero";
            p.ApPaterno = "Martínez";
            p.Edad = 33;
            p.Id = 1;
            p.Nombre = "Luis Marino";

            personas.Add(p);

            p = new Persona();
            p.ApMaterno = "Alvarez";
            p.ApPaterno = "Falcón";
            p.Edad = 30;
            p.Id = 2;
            p.Nombre = "Jorge Alejandro";

            personas.Add(p);

            Persona resultado = personas.Find(p => p.Id == id);

            return resultado;

        }

        // POST: api/Persona
        [HttpPost]
        public string Post([FromBody] Persona value)
        {
            List<Persona> personas = new List<Persona>();

            Persona p = new Persona();
            p.ApMaterno = "Candelero";
            p.ApPaterno = "Martínez";
            p.Edad = 33;
            p.Id = 1;
            p.Nombre = "Luis Marino";

            personas.Add(p);

            p = new Persona();
            p.ApMaterno = "Alvarez";
            p.ApPaterno = "Falcón";
            p.Edad = 30;
            p.Id = 2;
            p.Nombre = "Jorge Alejandro";

            personas.Add(p);

            //Agregar persona creada
            personas.Add(value);

            return ";) todo ok";


        }

        // PUT: api/Persona/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Persona value)
        {
            List<Persona> personas = new List<Persona>();

            Persona p = new Persona();
            p.ApMaterno = "Candelero";
            p.ApPaterno = "Martínez";
            p.Edad = 33;
            p.Id = 1;
            p.Nombre = "Luis Marino";

            personas.Add(p);

            p = new Persona();
            p.ApMaterno = "Alvarez";
            p.ApPaterno = "Falcón";
            p.Edad = 30;
            p.Id = 2;
            p.Nombre = "Jorge Alejandro";

            personas.Add(p);

            Persona resultado = personas.Find(p => p.Id == id);

            resultado.Edad = value.Edad;

            return ";) todo ok";


        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            try
            {
                List<Persona> personas = new List<Persona>();

                Persona p = new Persona();
                p.ApMaterno = "Candelero";
                p.ApPaterno = "Martínez";
                p.Edad = 33;
                p.Id = 1;
                p.Nombre = "Luis Marino";

                personas.Add(p);

                p = new Persona();
                p.ApMaterno = "Alvarez";
                p.ApPaterno = "Falcón";
                p.Edad = 30;
                p.Id = 2;
                p.Nombre = "Jorge Alejandro";

                personas.Add(p);

                Persona resultado = personas.Find(p => p.Id == id);

                personas.Remove(resultado);

                throw new Exception("Mi Excepción");

            }
            catch (Exception ex)
            {

                throw ex;
            }
         



        }
    }
}
