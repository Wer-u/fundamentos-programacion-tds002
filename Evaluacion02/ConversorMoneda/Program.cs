
/* Jade Mariel Mateo Baez 20260706;
    Programa que se encarga de calcula el equivalente de pesos dominicanos a dólares
    */


namespace ConversorMoneta

{     class Program
    {
        
        static void Main(string[] args)
        {
            
        //Declaramos la constante con la tasa del día
        const double TASA_USD = 60.07;

        //Se solicitan la cantidad a convertir y se declara la variable montoEnPesos

        Console.WriteLine(" --- Conversor de Pesos a Dólares --- ");
        Console.WriteLine("Ingrese la cantidad en pesos dominicanos (DOP):");
        double montoEnPesos = double.Parse(Console.ReadLine()!);

        //Se hace el calculo para conseguir el equivalente en USD

        double montoEnDolares = montoEnPesos/TASA_USD;

        //Resultado con interpolación
        Console.WriteLine("\n __ MONTO CONVERTIDO A USD __");
        Console.WriteLine($"Monto ingresado: RD$ {montoEnPesos}");
        Console.WriteLine($"Tasa de cambio aplicada: {TASA_USD} DOP por USD");
        Console.WriteLine($"Equivalente en dólares: US$ {montoEnDolares:F2}");
        }



        }
    }