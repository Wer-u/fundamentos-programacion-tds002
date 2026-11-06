
/* Jade Mariel Mateo Baez 20260706 */

Console.WriteLine(" === CONVERSOR DE UNIDADES === ");

Console.WriteLine("\nIngrese una unidad en lb para convertir a kg:");
double pesoLibra = double.Parse(Console.ReadLine()!);

Console.WriteLine("\nIngrese la temperatura en °F para convertir a °C:");
double fahr = double.Parse(Console.ReadLine()!);

// Cramos la contante de lbPorKg = 0.453592 para multiplicarlo por la variable pesoLibra, para obtener la conversión
const double lbPorKg = 0.453592;

double pesoKilogramo = pesoLibra * lbPorKg;

//En esta parte se realiza el calculo de conversión a celsius primero restando la cantidad de °F menos 32.0 y luego multiplicando por la división
//Usamos decimales en los números para obtener los deimales exactos

double celsius = (fahr - 32.0) * 5.0 / 9.0;

//Se realiza el redondeo de 2 decimales a las dos conversiones (kg y celsius)
double kgRedondeado = Math.Round(pesoKilogramo, 2);
double celsiusRedondeado = Math.Round(celsius, 2);

Console.WriteLine("\n--------------------------------------------");
Console.WriteLine("                 RESULTADOS                   ");
Console.WriteLine("---------------==-----------------------------");
Console.WriteLine($"Peso: {pesoLibra:F2} lb  -->  {kgRedondeado:F2} kg");
Console.WriteLine($"Temperatura: {fahr:F2} °F  -->  {celsiusRedondeado:F2} °C");
Console.WriteLine("----------------------------------------------");




