
using _1_Clases;

Console.WriteLine("Calculadora : EJEMPLO USO DE CLASES.");


Console.WriteLine("Suma:\n");

Ccalculadora sumar = new Ccalculadora(10,20);

int suma = sumar.suma();
Console.WriteLine($"La suma total es: " + suma);