using System;

public class SobreConst
{
    // Constructor por defecto (sin parámetros)
    public SobreConst()
    {
        Console.WriteLine("Constructor sin parámetros. Constructor por defecto");
    }

    // Constructor con un parámetro de tipo int
    public SobreConst(int valor)
    {
        Console.WriteLine("Constructor con un parámetro. El valor del mismo es: " + valor);
    }

    // Constructor con dos parámetros: int y string
    public SobreConst(int valor1, string valor2)
    {
        Console.WriteLine("Constructor con dos parámetros. Valores: " + valor1 + " y " + valor2);
    }
}