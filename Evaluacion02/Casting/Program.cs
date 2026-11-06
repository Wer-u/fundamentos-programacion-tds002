
    /* Jade Mariel Mateo Baez 20260706
        Proyecto de práctica de casting explícito y implícito*/

namespace Casting

{
    class Program
    {
        static void Main(string[] args)
        {

            //Se solicita el número con decimales
            Console.WriteLine("=== DEMOSTRACIÓN DE CASTING ===");
            Console.Write("Ingrese un número con decimales: ");
            double numeroDecimal = double.Parse(Console.ReadLine()!);

            // Realizamos el casting explícito (de double a int)
            int parteEntera = (int)numeroDecimal;

            Console.WriteLine($"\n[Casting Explícito]");
            Console.WriteLine($"Valor original en double: {numeroDecimal}");
            Console.WriteLine($"Valor convertido a int: {parteEntera}");

            // Realizamos el casting implícito (de int a double) "demostración"
            // En este caso use la clase random para que el sistema tomara un número cualquiera (de 1 a 100 ) para realizar la demostración
        
            Random random = new();


            int numeroRandom = random.Next(1,101);
            double numeroDoo = numeroRandom; // Conversión automática de int a double, en este caso no habra diferencia

            Console.WriteLine($"\n[Casting Implícito]");
            Console.WriteLine($"\n-Demostración con número aleatorio:");
            Console.WriteLine($"Valor inicial en int: {numeroRandom}");
            Console.WriteLine($"Convertido implícitamente a double: {numeroDoo}");
        }
    }
}