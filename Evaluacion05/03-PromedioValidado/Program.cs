//      Jade Mateo Baez 20260706
//      Fecha: 15/11/2026
//      Resumen:

    double sumaNotas = 0;
    int cantidadNotas = 0;
    
        // Se inicializan en los extremos opuestos del rango (0-100) para garantizar que la primera nota válida las reemplace correctamente sin sesgos
        double notaMayor = -1;
        double notaMenor = 101;
        double notaActual = 0;

        Console.WriteLine("======================================================");
        Console.WriteLine("            SISTEMA DE PROMEDIO ACADÉMICO             ");
        Console.WriteLine("======================================================");
        Console.WriteLine("Ingrese calificaciones (0 a 100) | Escriba -1 para salir \n");

        do
            {
                bool entradaValida;

                // El ciclo se repite hasta que se ingrese una calificación real o el -1 para salir
                do
                {
                    Console.Write($" Calificación #{cantidadNotas + 1,2}: ");
                    string? entrada = Console.ReadLine();

                    entradaValida = double.TryParse(entrada, out notaActual) &&
                        ((notaActual >= 0 && notaActual <= 100) || notaActual == -1);

                    if (!entradaValida)
                    {
                        Console.WriteLine(" [!] Error: La nota debe estar entre 0 y 100 (o -1 para finalizar).");
                    }

                } while (!entradaValida);

                // Excluimos explícitamente el valor -1 para que no contamine los cálculos estadísticos
                if (notaActual != -1)
                {
                    sumaNotas += notaActual;
                    cantidadNotas++;

                // Actualiza los valor de las notas mayor y menor mientras se van sumando más notas
                    if (notaActual > notaMayor) notaMayor = notaActual;
                    if (notaActual < notaMenor) notaMenor = notaActual;
                }

            } while (notaActual != -1);

            Console.WriteLine("\n==========================================");
            Console.WriteLine("                ESTADÍSTICAS                ");
            Console.WriteLine("============================================");

            if (cantidadNotas > 0)
            {
                double promedio = sumaNotas / cantidadNotas;

                Console.WriteLine($" {"Notas procesadas:",-26} {cantidadNotas,12}");
                Console.WriteLine($" {"Promedio general:",-26} {promedio,12:N2}");
                Console.WriteLine($" {"Calificación más alta:",-26} {notaMayor,12:N2}");
                Console.WriteLine($" {"Calificación más baja:",-26} {notaMenor,12:N2}");
            }
            else
            {
                Console.WriteLine(" No se registraron calificaciones válidas para procesar.");
            }
            Console.WriteLine("======================================================");