
int tabla, numero;
for (tabla = 1; tabla <= 5; tabla++)
{
    for (numero = 1; numero <= 10; numero++)
    {
        Console.WriteLine("{0} por {1} es {2}", tabla, numero, tabla * numero);
    }
    Console.WriteLine();
}
Console.ReadKey();



// 1) Cambiar los datos correspondientes para mostrar de la A a la Z.
// 2) Ahora mostrr el abecedario en orden invertido, osea de la Z a la A.
// Crear un programa que escria en pantalla los numeros del 1 al 50 que sean multiplos de 3 (pista: el multiplo se evalua si el resto
// de la division por 3 es igual a 0).