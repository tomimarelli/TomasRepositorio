using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialN_1LaboratorioMarelliTomas
{
    class Banco
    {
        private double montoDeposito;

        public Banco()
        {
            montoDeposito = 3500;
        }

        public void Deposito(double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Hay que depositar un valor 1Peso o más.");
            }
            else
            {
                montoDeposito += cantidad;
                Console.WriteLine($"Se depositó ${cantidad} pesos.");
            }
        }

        public double TotalDep()
        {
            return montoDeposito;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Total de deposito: ${montoDeposito}");
        }
    }
}
