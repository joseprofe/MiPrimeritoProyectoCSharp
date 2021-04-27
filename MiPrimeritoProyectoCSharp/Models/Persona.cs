using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritoProyectoCSharp.Models
{
    public class Persona
    {
        public int DNI { get; set; }

        public Persona(int DNI)
        {
            this.DNI = DNI;
        }
    }
}
