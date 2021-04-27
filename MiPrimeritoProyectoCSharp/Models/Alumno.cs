using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritoProyectoCSharp.Models
{
    public class Alumno : Persona,ICloneable
    {
        public string Nombre { get; set; }
        public float Nota { get; set; }

        public Alumno(string nombre, int DNI, float nota) : base(DNI)
        {
            this.Nombre = nombre;
            this.Nota = nota;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
