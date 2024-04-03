using ejerPrac3;

internal class Program
{
    static void Main(string[] args)
    {
        ejerPrac3.Triangulo t = new Triangulo();
        t.Ingresar();
        t.Imprimir();

        Console.ReadKey();
    }
}
