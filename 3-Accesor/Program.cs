

using _3_Accesor;

Console.WriteLine("Accesors");

double impuesto = 0.0;
cEmpleado empleado = new cEmpleado();

empleado.set_sueldo(2500);
//empleado.set_impuesto(0.12);


empleado.Muestra();

Console.WriteLine("");
empleado.calcularImpuesto();

impuesto =empleado.get_impuesto();
Console.WriteLine($"El impuesto es: {impuesto}");
empleado.Muestra();
