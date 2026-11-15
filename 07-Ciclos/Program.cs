
//      Jade Mateo Baez 20260706
//      Fecha: 15/11/2026
/*      Resumen: Uso de while y do-while para un programa que muestra la tabla de multiplicar y suma los resultados 
        finales de los números del 1 al 12*/


int number = 0;

    // PUNTO 1: Validación del número entre 1 y 12 usando do-while
    do
    {

        Console.WriteLine("========================================================");
        Console.WriteLine("           GENERADOR DE TABLAS DE MULTIPLICAR           ");
        Console.WriteLine("========================================================");
        Console.Write("\nIngrese un número entero (del 1 al 12): ");
                
    
        // Validación para evitar errores si ingresan letras u otros caracteres fuera de rango
        if (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 12)
            {
                    Console.WriteLine("\n [!] Error: Entrada no válida. Debe ser un número entre 1 y 12.");
                    Console.WriteLine(" Presione cualquier tecla para intentar de nuevo...");
                    Console.ReadKey();
            }
            } 
            while (number < 1 || number > 12);

    // PUNTO 2: Tabla de multiplicar con el ciclo while y el acumulador
            int contador = 1;      // Contador para recorrer del 1 al 12
            double sumaResultados = 0; // Acumulador para sumar todos los productos


            Console.WriteLine("========================================================");
            Console.WriteLine($"             TABLA DE MULTIPLICAR DEL {number}                  ");
            Console.WriteLine("========================================================");
            Console.WriteLine("    Iteración    |     Operación     |    Resultado     ");
            Console.WriteLine("-----------------+-------------------+------------------");

            // Ciclo while para mostrar la tabla de multiplicar
            while (contador <= 12)
            {
                int resultado = number * contador;
                sumaResultados += resultado; // Acumulando el valor de cada resultado

                // Impresión con formato alineado
                Console.WriteLine($"       {contador,2}        |      {number,2} x {contador,2}      |      {resultado,3}     ");

                contador++; // Incremento indispensable para evitar un ciclo infinito
            }

            Console.WriteLine("-----------------+-------------------+------------------");
            
            // 3. Mostrar la suma total de los resultados obtenidos
            Console.WriteLine($"\n Suma total de todos los resultados: {sumaResultados,6:N0}");
            Console.WriteLine("========================================================");
            

            Console.WriteLine("\n Presione cualquier tecla para salir...");
            Console.ReadKey();