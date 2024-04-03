class Program
{
    public static void Main(string[] args)
    {
        Persona p = new Persona();
        p.Nombre = "Messi";
        p.Edad = 36;
        p.Imprimit();
        Console.ReadKey(true);
    }
}
