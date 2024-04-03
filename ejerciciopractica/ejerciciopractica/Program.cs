using System;

public class Alumno
{
    public double NotaConcepto { get; set; }
    public double NotaEscrita { get; set; }
    public double NotaOral { get; set; }

    public double CalcularPromedio()
    {
        return (NotaConcepto + NotaEscrita + NotaOral) / 3.0;
    }

    public string ObtenerEstado()
    {
        double promedio = CalcularPromedio();

        if (promedio >= 7)
        {
            return "PROMOCIONADO";
        }
        else if (promedio >= 5 && promedio < 7)
        {
            return "APROBADO";
        }
        else
        {
            return "DESAPROBADO";
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Alumno alumno = new Alumno();

        Console.Write("Ingrese la nota de concepto: ");
        alumno.NotaConcepto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la nota de evaluación escrita: ");
        alumno.NotaEscrita = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la nota de evaluación oral: ");
        alumno.NotaOral = Convert.ToDouble(Console.ReadLine());

        double promedio = alumno.CalcularPromedio();
        string estado = alumno.ObtenerEstado();

        Console.WriteLine("Promedio: {0}", promedio.ToString("N2"));
        Console.WriteLine("Estado del alumno: {0}", estado);

        Console.ReadKey();
    }
}