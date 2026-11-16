//      Jade Mateo Baez 20260706
//      Fecha: 15/11/2026
// Resumen: menú de opciones para 1. tabla de ciclos anidados, y 2. para dibujar triángulos de asteriscos con N.

        int opcion;

            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine("           MENÚ PRINCIPAL          ");
                Console.WriteLine("===================================");
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1. Mostrar tablas con ciclos anidados");
                Console.WriteLine("2. Dibujar triángulo de asteriscos");
                Console.WriteLine("0. Salir");

                // Validamos que la entrada sea un número entero
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("--- TABLAS DE MULTIPLICAR (1 al 10) ---");
                            // Ciclos anidados con formato de columnas alineadas
                            for (int i = 1; i <= 10; i++)
                            {
                                for (int j = 1; j <= 10; j++)
                                {
                                    Console.Write($"{i * j, 4}");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 2:;
                            Console.WriteLine("--- TRIÁNGULO DE ASTERISCOS ---");
                            Console.Write("Ingrese el número de filas (N): ");
                            
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                // Ciclos anidados para construir el triángulo de N filas
                                for (int fila = 1; fila <= n; fila++)
                                {
                                // Imprimir los espacios en blanco para centrar
                                    for (int espacio = 1; espacio <= n - fila; espacio++)
                                    {
                                            Console.Write(" ");
                                    }
                                // Imprimir los asteriscos en número impar
                                    for (int k = 1; k <= (2 * fila - 1); k++)
                                    {
                                        Console.Write("*");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor, ingrese un número válido mayor a 0.");
                            }
                            
                            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 0:
                            Console.WriteLine("\nSaliendo del programa... ¡Hasta pronto!");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0); // El ciclo se repite hasta que el usuario elija 0