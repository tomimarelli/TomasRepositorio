using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerPrac3
{
    internal class Triangulo
    {
        public int l1, l2, l3;

        public void Ingresar()
        {
            Console.Write("Ingrese el primer lado del triángulo: ");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo lado del triángulo: ");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer lado del triángulo: ");
            l3 = Convert.ToInt32(Console.ReadLine());

        }
        public string TipoTriangulo()
        {
            string tipo = "";
            if ((l1 == l2) && (l1 == l3))
                tipo = "EQUILÁTERO";
            else if ((l1 != l2) && (l1 != l3) && (l2 != l3))
                tipo = "ESCALENO";
            else if (l1 == l2 && l1 != l3 || l2 == l3 && l3 != l1 || l3 == l1 && l1 != l2)
                tipo = "ISÓSCELES";
            return tipo;
        }
        public void Imprimir()
        {
            Console.WriteLine("El triángulo formado con los lados ingresados es: " + TipoTriangulo());
        }
    }
}
