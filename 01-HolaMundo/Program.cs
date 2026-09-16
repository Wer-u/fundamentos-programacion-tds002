/* Nombre: Jade Mariel Mateo Baez
 - Fecha: 9/16/2026
 - Decripción: Programa de consola en C# que se encarga de imprimir una tarjeta de presentación
         de mi información (nombre y matrícula) + una frase que me describa con un marco hecho de
         caracteres (*,=,|). */
    
string nombre = "Jade Mariel";
string apellido = "Mateo Baez";
int matric = 20260706;
string carrera = "Tecnólogo en Ciberseguridad";
string info = "La ansiedad es mi mejor amiga";
                
        // Uso de String y Int para definir el tipo de variable. Uso de "=" para declarar cada variable con su valor correspondiente.

Console.WriteLine("*===============================================*");
Console.WriteLine("*            Tarjeta de Presentación            *");
Console.WriteLine("*===============================================*");
Console.WriteLine();
        // Comienzo del marco de tarjeta de presentación hecho con los caracteres (*,=,|).

Console.WriteLine($"| Nombre: {nombre}");
Console.WriteLine();
Console.WriteLine($"| Apellido: {apellido}");
Console.WriteLine();
Console.WriteLine($"| Matrícula: {matric}");
Console.WriteLine();
Console.WriteLine($"| Carrera: {carrera}");
Console.WriteLine();
Console.WriteLine("*************************************************");
Console.WriteLine();
Console.WriteLine($"| Frase Descriptiva: {info}");
Console.WriteLine();
Console.WriteLine("*===============================================*");

// Ese bloque imprime los datos que fueron guardados en las variables. El $ permite insertar las variables dentro de las comillas.

