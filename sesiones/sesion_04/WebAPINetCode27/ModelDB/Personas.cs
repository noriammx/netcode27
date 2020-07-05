using System;
using System.Collections.Generic;

namespace WebAPINetCode27.ModelDB
{
    public partial class Personas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public int Edad { get; set; }
    }
}
