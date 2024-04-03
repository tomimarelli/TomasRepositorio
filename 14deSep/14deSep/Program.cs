Imports System

Class VentaProducto
    Private precioUnitario As Double
    Private cantidadVendida As Integer

    Public Sub New(precio As Double, cantidad As Integer)
        precioUnitario = precio
        cantidadVendida = cantidad
    End Sub

    Public Function CalcularImporte() As Double
        Return precioUnitario * cantidadVendida
    End Function

    Public Function CalcularComision() As Double
        Return CalcularImporte() *0.15 ' 15% de comisión
    End Function
End Class

Module Program
    Sub Main()
        Console.WriteLine("Ingrese el precio unitario del producto:")
        Dim precio As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese la cantidad vendida del producto:")
        Dim cantidad As Integer = Integer.Parse(Console.ReadLine())

        Dim venta As New VentaProducto(precio, cantidad)

        Dim importe As Double = venta.CalcularImporte()
        Dim comision As Double = venta.CalcularComision()

        Console.WriteLine("Importe vendido: " & importe.ToString("C"))
        Console.WriteLine("Comisión del vendedor (15%): " & comision.ToString("C"))

        Console.ReadLine()
    End Sub
End Module// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
