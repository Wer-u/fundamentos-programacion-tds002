//      Jade Mateo Baez 20260706
//      Fecha: 15/11/2026
//      Resumen: Realización de un programa con dos partes. La primera parte evalua una nota y la segunda es un menú de calculadora
        
    
    // PARTE 1: CALIFICACIÓN
    
        Console.WriteLine(" PARTE 1: == EVALUACIÓN DE CALIFICACIÓN ==");
        Console.Write("Ingrese una nota en el rango de 0 a 100: ");
        string inputNota = Console.ReadLine()!;
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");

        /* Evaluamos que el texto sea parseable a entero y que se mantenga
        dentro del dominio lógico de calificaciones (0 a 100)  */

        if (int.TryParse(inputNota, out int nota) && nota >= 0 && nota <= 100)
        {
        
        /* Realizamos la evaluación de mayor a menor para que 
        los rangos superiores descarten automáticamente los inferiores */

            if (nota >= 90)
            {
                Console.WriteLine("Calificación: A");
            }
            else if (nota >= 80)
            {
                Console.WriteLine("Calificación: B");
            }
            else if (nota >= 70)
            {
                Console.WriteLine("Calificación: C");
            }
            else
            {
                Console.WriteLine("Calificación: F");
            }
        }
        else
        {
        /*Se activa si el usuario ingresa letras, caracteres especiales o números fuera del rango permitido */

            Console.WriteLine("Error: Ingrese un número entero válido entre 0 y 100.");
        }

        Console.WriteLine();
        Console.WriteLine(); // Espacio visual para separar ambas secciones en consola

    
    
    // PARTE 2: CALCULADORA
    
        Console.WriteLine("PARTE 2: === CALCULADORA BÁSICA ===");
        
        Console.Write("Ingrese el primer número: ");

        // Empleamos double.TryParse para admitir tanto enteros como decimales sin que el programa colapse
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine();
                Console.WriteLine("\nSeleccione un número para realizar una operación:");
                Console.WriteLine("1. Sumar (+)");
                Console.WriteLine("2. Restar (-)");
                Console.WriteLine("3. Multiplicar (*)");
                Console.WriteLine("4. Dividir (/)");
                Console.WriteLine();
                Console.WriteLine("-------------------");

           

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    // Realizamos la ejecución según la opción numérica seleccionada por el usuario
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                            break;
                        case 4:
                            // Prevenimos la división entre cero.
                            if (num2 != 0)
                            {
                                Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            }
                            break;
                        default:
                            // Se ejecuta si el entero ingresado no coincide con ninguna opción del menú.
                            Console.WriteLine("Error: Opción de menú no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: La opción seleccionada debe ser un número entero.");
                }
            }
            else
            {
                Console.WriteLine("Error: El segundo número ingresado no es válido.");
            }
        }
        else
        {
            Console.WriteLine("Error: El primer número ingresado no es válido.");
        }