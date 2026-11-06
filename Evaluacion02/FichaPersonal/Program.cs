using System.IO.Compression;

/* Jade Mariel Mateo Baez 20260706
Proyecto de consola que pide información personal
y hace un calculo de en que año el usuario cumplira 30.
*/ 

namespace FichaPersonal
{ 

    class Program
    {
        
        static void Main(string[] args)
        {
            //Directamente se declaran las variables y se solicitan los datos

            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine()!;

            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese su estatura: ");
            double estatura = double.Parse(Console.ReadLine()!);

            Console.WriteLine("¿Trabaja actualmente? (true/false): ");
            bool trabajaAhora = bool.Parse(Console.ReadLine()!);



         // Calculo para obtener el año donde el usuario cumplira 30 años
        //Directamente declaramos las variables, una contiene el año actual y las otras dos hacen uso de calculos para obtener su valor.
            int añoActual = 2026;
            int añoPara30 = 30 - edad;
            int añoCumple30 = añoActual + añoPara30;

        
        // Salida con interpolación

        Console.WriteLine("\n ___Ficha Personal___ ");
        Console.WriteLine($"\nNombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Estatura: {estatura}");
        Console.WriteLine($"Empleado: {trabajaAhora}");
        Console.WriteLine($"Cumplirá 30 años en el: {añoCumple30}");










        }





    }
    












}


