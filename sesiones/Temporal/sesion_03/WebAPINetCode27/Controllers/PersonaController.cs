using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPINetCode27.Model;
using WebAPINetCode27.ModelDb;

namespace WebAPINetCode27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<PersonaDTO> Get()
        {

            List<PersonaDTO> personas = new List<PersonaDTO>();

            using (NetCode27Context context = new NetCode27Context())
            {
                var entidades = context.Personas;

                foreach (var item in entidades)
                {
                    PersonaDTO p = new PersonaDTO();
                    p.ApMaterno = item.ApMaterno;
                    p.ApPaterno = item.ApPaterno;
                    p.Edad = item.Edad;
                    p.Id = item.Id;
                    p.Nombre = item.Nombre;

                    personas.Add(p);

                }
            }

            return personas;
        }

        // GET: api/Persona/5
        [HttpGet("{id}", Name = "Get")]
        public PersonaDTO Get(int id)
        {
            PersonaDTO p = new PersonaDTO();

            using (NetCode27Context context = new NetCode27Context())
            {

                var item = context.Personas.FirstOrDefault(p => p.Id == id);                
                p.ApMaterno = item.ApMaterno;
                p.ApPaterno = item.ApPaterno;
                p.Edad = item.Edad;
                p.Id = item.Id;
                p.Nombre = item.Nombre;

            }
            return p;
        }

        // POST: api/Persona
        [HttpPost]
        public string Post([FromBody] PersonaDTO value)
        {
            using (NetCode27Context context = new NetCode27Context())
            {
                Personas objectDb = new Personas();
                objectDb.ApMaterno = value.ApMaterno;
                objectDb.ApPaterno = value.ApPaterno;
                objectDb.Edad = value.Edad;
                objectDb.Nombre = value.Nombre;
                context.Personas.Add(objectDb);
                context.SaveChanges();

            }

            return ";) todo ok";


        }

        // PUT: api/Persona/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] PersonaDTO value)
        {
            using (NetCode27Context context = new NetCode27Context())
            {

                var item = context.Personas.FirstOrDefault(p => p.Id == id);
                item.ApMaterno = value.ApMaterno;
                item.ApPaterno = value.ApPaterno;
                item.Edad = value.Edad;
                item.Nombre = value.Nombre;
                
                context.SaveChanges();

            }

            return ";) todo ok";


        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (NetCode27Context context = new NetCode27Context())
            {

                var item = context.Personas.FirstOrDefault(p => p.Id == id);
                context.Personas.Remove(item);
                context.SaveChanges();

            }
        }
    }
}
