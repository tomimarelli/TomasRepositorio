using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia3deOct
{
    class Empresa
    {
        private Empleado[] empleadosManana = new Empleado[4];
        private Empleado[] empleadosTarde = new Empleado[4];

        public void IngresarSueldos()
        {
            Console.WriteLine("sueldo turno mañana:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Apellido y Nombre del empleado {i + 1}: ");
                string nombre = Console.ReadLine();
                Console.Write($"Sueldo del empleado {i + 1}: $");
                double sueldo = double.Parse(Console.ReadLine());

                empleadosManana[i] = new Empleado(nombre, sueldo);
            }

            Console.WriteLine("Sueldo turn tarde:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Apellido y nombre del empleado {i + 1}: ");
                string nombre = Console.ReadLine();
                Console.Write($"Sueldo del empleado {i + 1}: $");
                double sueldo = double.Parse(Console.ReadLine());

                empleadosTarde[i] = new Empleado(nombre, sueldo);
            }
        }

        public void ImprimirGastosSueldos()
        {
            double gastosManana = CalcularGastos(empleadosManana);
            double gastosTarde = CalcularGastos(empleadosTarde);

            Console.WriteLine($"Importe a pagar turno mañana: ${gastosManana}");
            Console.WriteLine($"Importe a pagar turno tarde: ${gastosTarde}");
        }

        private double CalcularGastos(Empleado[] empleados)
        {
            double totalSueldos = 0;
            foreach (Empleado empleado in empleados)
            {
                totalSueldos += empleado.Sueldo;
            }
            return totalSueldos;
        }
    }
}
