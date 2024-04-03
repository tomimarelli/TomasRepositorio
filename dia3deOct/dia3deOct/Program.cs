using dia3deOct;
using System;

class Program
{
    static void Main()
    {
        dia3deOct.Empresa miEmpresa = new Empresa();
        miEmpresa.IngresarSueldos();
        Console.WriteLine("---------");
        miEmpresa.ImprimirGastosSueldos();
    }
}