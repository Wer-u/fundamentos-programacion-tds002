//      Jade Mateo Baez 20260706
//      Fecha: 15/11/2026
//      Resumen: sistema de caja que permite ingresar el precio de una x cantidad de productos y usa 0 para terminar el ciclo.

const double TASA_ITBIS = 0.18;
            double subtotal = 0;
            double precio = 0;
            int cantidadProductos = 0;

            Console.WriteLine("======================================================");
            Console.WriteLine("               SISTEMA DE CAJA REGISTRADORA           ");
            Console.WriteLine("======================================================");
            Console.WriteLine(" Ingrese los precios de los artículos");
            Console.WriteLine(" (Inserte 0 para finalizar) \n");

            // Se usa do-while porque el sistema debe solicitar al menos una entrada antes de evaluar la salida
            do
            {
            // cantidadProducto + 1 permite entender cuántos productos se ingresaron y el orden
                Console.Write($" Precio del producto #{cantidadProductos + 1,2}: RD$ ");
                string? entrada = Console.ReadLine();


                if (!double.TryParse(entrada, out precio) || precio < 0)
                {
                    Console.WriteLine(" [!] Monto inválido. Ingrese un valor numérico positivo (o 0 para salir).");
                    precio = -1; // Asignamos -1 para forzar que el ciclo continúe sin alterar el subtotal ni activar el cierre (0)
                    continue;
                }

                // El 0 actúa como valor de salida, por lo que no debe contabilizarse como un artículo real
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }

            } while (precio != 0);

            double itbis = subtotal * TASA_ITBIS;
            double total = subtotal + itbis;

            Console.WriteLine("\n======================================================");
            Console.WriteLine("                  RESUMEN DE FACTURA                  ");
            Console.WriteLine("======================================================");
            Console.WriteLine($" {"Artículos facturados:",-28} {cantidadProductos,15}");
            Console.WriteLine($" {"Subtotal:",-28} RD$ {subtotal,11:N2}");
            Console.WriteLine($" {"ITBIS (18%):",-28} RD$ {itbis,11:N2}");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($" {"TOTAL A PAGAR:",-28} RD$ {total,11:N2}");
            Console.WriteLine("======================================================");