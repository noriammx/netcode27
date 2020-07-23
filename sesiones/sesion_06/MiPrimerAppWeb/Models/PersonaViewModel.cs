using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerAppWeb.Models
{
    public class PersonaViewModel
    {
        public List<PersonaDTO> personas { get; set; }
        public PersonaDTO persona { get; set; }
    }
}
