/*Jade Mariel Mateo Baez 20260706 
Este proyeto pone en práctica el uso de operadores con el uso de números enteros*/

namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" === PROGRAMA DE OPERACIONES DE 2 NÚMEROS ENTEROS");

        //Se realiza la solicitud de los dos números (num1 y num2), los cuales deben ser enteros
        Console.WriteLine("\nIngrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine()!);
         Console.WriteLine("\nIngrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine()!);

        //Realizamos las operaciones (suma, resta, multiplicación y división entera)

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multipli = num1 * num2;
        int diviEntera = num1 / num2;

            //Para realizar la * real debemos convertir uno de los números a tipo double/decimal
            decimal diviReal = (decimal)num1 / num2;

        // Calculo para el residuo
        int residuo = num1 % num2;

        //Calculo para saber si el primer número es par
        
        bool ePar = (num1 % 2 == 0);

        //Muestra de resultado

        Console.WriteLine("\n __ RESULTADOS __ ");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Producto: {multipli}");
        Console.WriteLine($"División Real: {diviReal}");
        Console.WriteLine($"División Entera: {diviEntera}");
        Console.WriteLine($"Residuo: {residuo}");
        Console.WriteLine($"El primer número es PAR: {ePar}");

        /* RESULTADOS DEL PROGRAMA x=10, y=3:

        Suma: 13
        Resta: 7
        Producto: 30
        División Real: 3.3333333333333333333333333333
        División Entera: 3
        Residuo: 1
        El primer número es PAR: True



        */


    }
}
