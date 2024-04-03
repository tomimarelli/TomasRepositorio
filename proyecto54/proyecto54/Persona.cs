public class Persona
{
    protected string nombre;
    protected int edad;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }


    public void Imprimit()
    {
        Console.WriteLine("nombre: {0},edad: {1}", nombre, edad);
    }
}