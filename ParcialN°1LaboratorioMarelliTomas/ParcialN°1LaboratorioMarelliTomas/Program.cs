using ParcialN_1LaboratorioMarelliTomas;
using System;

class Program
{
    static void Main()
    {
        Banco miBanco = new Banco();

        Console.WriteLine("Banco");
        Console.WriteLine("-----");

        while (true)
        {
            Console.WriteLine("1. Deposito de dinero");
            Console.WriteLine("2. Monto total deposito");
            Console.Write("Elegi 1 o 2: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("CAntidad depositada por el usuario: $");
                    double cantidad = double.Parse(Console.ReadLine());
                    miBanco.Deposito(cantidad);
                    break;
                case 2:
                    double totalDepositado = miBanco.TotalDep();
                    Console.WriteLine($"El monto total depositado es: ${totalDepositado}");
                    break;
                    return;
                default:
                    Console.WriteLine("Solo puede elegir por 1 o 2.");
                    break;
            }

            Console.WriteLine("------");
        }
    }
}