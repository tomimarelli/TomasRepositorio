using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerPrac2
{
    internal class Comercio
    {
        public int cantidad;
        public double importe;
        double totalV = 0, totalP = 0, totalF = 0;


        public void Menu()
        {
            int opc;


            do
            {
                Console.WriteLine("\n******* Elija una opción del menú *******\n");
                Console.WriteLine("1 - Sector Ferretería");
                Console.WriteLine("2 - Sector Pinturería");
                Console.WriteLine("3 - Sector Varias");
                Console.WriteLine("0 - Salir");

                Console.Write("\nIngrese una Opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Ferreteria();
                        break;
                    case 2:
                        Pintureria();
                        break;
                    case 3:
                        Varias();
                        break;
                    case 0: break;
                    default:
                        Console.WriteLine("Debe ingresar una opción del menú válida");
                        break;

                }

            } while (opc != 0);
        }
        public void Ferreteria()
        {

            Console.Write("Ingrese el importe vendido en el rubro Ferretería: ");
            double impV = Convert.ToDouble(Console.ReadLine());
            totalF += impV;
            importe += impV;
            cantidad++;

        }
        public void Pintureria()
        {

            Console.Write("Ingrese el importe vendido en el rubro Pinturería: ");
            double impP = Convert.ToDouble(Console.ReadLine());
            totalP += impP;
            importe += impP;
            cantidad++;

        }
        public void Varias()
        {

            Console.Write("Ingrese el importe vendido en el rubro Varias: ");
            double impVr = Convert.ToDouble(Console.ReadLine());
            totalV += impVr;
            importe += impVr;
            cantidad++;

        }
        public void Imprimir()
        {
            Console.WriteLine("\nLa cantidad de ventas ingresadas es de {0}.", cantidad);
            Console.WriteLine("El total vendido para Ferretería es: $ {0}.", totalF.ToString("N2"));
            Console.WriteLine("El total vendido para Pinturería es: $ {0}.", totalP.ToString("N2"));
            Console.WriteLine("El total vendido para el rubro Varias es: $ {0}.", totalV.ToString("N2"));
            Console.WriteLine("El monto total vendido es de $ {0}.", importe.ToString("N2"));
            Console.ReadKey();

        }
    }
}
