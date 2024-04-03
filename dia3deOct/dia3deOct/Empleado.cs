using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia3deOct
{
    class Empleado
    {
        public string Nombre { get; set; }
        public double Sueldo { get; set; }

        public Empleado(string nombre, double sueldo)
        {
            Nombre = nombre;
            Sueldo = sueldo;
        }
    }
}
