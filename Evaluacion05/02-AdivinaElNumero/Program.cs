
//      Jade Mateo Baez 20260706
//      Fecha: 15/11/2026
//      Resumen: Programa de adivinar un número, haciendo uso de un contador para saber el número de intentos


            int numeroSecreto = Random.Shared.Next(1, 101);
            int intentoUsuario = 0;
            int contadorIntentos = 0;

            Console.WriteLine("======================================================");
            Console.WriteLine("                  ADIVINA EL NÚMERO                   ");
            Console.WriteLine("======================================================");
            Console.WriteLine("          ¡Adivina el número entre 1 y 100!\n");

            do
            {
                Console.Write($" Intento #{contadorIntentos + 1,2} -> Ingresa un número: ");
                string? entrada = Console.ReadLine();

                // Validamos que la entrada esté dentro del rango permitido
                if (!int.TryParse(entrada, out intentoUsuario) || intentoUsuario < 1 || intentoUsuario > 100)
                {
                    Console.WriteLine(" [!] Entrada no válida. Solo se permiten enteros entre 1 y 100.\n");
                    continue;
                }

                contadorIntentos++;

                if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine(" -> Pista: El número secreto es MAYOR.\n");
                }
                else if (intentoUsuario > numeroSecreto)
                {
                    Console.WriteLine(" -> Pista: El número secreto es MENOR.\n");
                }

            } while (intentoUsuario != numeroSecreto);

            Console.WriteLine("\n======================================================");
            Console.WriteLine("                    ¡FELICIDADES!                     ");
            Console.WriteLine("======================================================");
            Console.WriteLine($" {"Número secreto:",-26} {numeroSecreto,12}");
            Console.WriteLine($" {"Total de intentos:",-26} {contadorIntentos,12}");
            Console.WriteLine("======================================================");