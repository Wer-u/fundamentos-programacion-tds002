/* Jade Mariel Mateo Baez 20260706
En este proyecto se calcula el precio de la compra de un producto tomando en cuenta el itbs.
*/


const double itbs = 0.18;

    Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");

    Console.Write("Ingrese el nombre del producto: ");
    string producto = Console.ReadLine()!;

    Console.Write("Ingrese la cantidad a comprar: ");
    int cantidad = int.Parse(Console.ReadLine()!);

    Console.Write("Ingrese el precio unitario: ");
    double precioUnitario = double.Parse(Console.ReadLine()!);


    double subtotal = cantidad * precioUnitario;
    double itbisPrecio = subtotal * itbs; //Se hace el calculo de el precio del itbs para luego sumarlo en el precio final (total)
    double total = subtotal + itbisPrecio;

            Console.WriteLine("\n========================================");
            Console.WriteLine("              FACTURA FISCAL            ");
            Console.WriteLine("========================================");
            Console.WriteLine($"{"Producto:",-20} {producto,15}");
            Console.WriteLine($"{"Cantidad:",-20} {cantidad,15}");
            Console.WriteLine($"{"Precio Unitario:",-20} {precioUnitario,15:N2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{"Subtotal:",-20} {subtotal,15:N2}");
            Console.WriteLine($"{"ITBIS (18%):",-20} {itbisPrecio,15:N2}");
            Console.WriteLine($"{"Total a Pagar:",-20} {total,15:N2}");
            Console.WriteLine("========================================");