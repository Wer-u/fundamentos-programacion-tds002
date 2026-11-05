namespace _02_Variables;

// Jade Mariel Mateo Baez 20260706
// Proyecto que se encarga de pedir datos básico y calcular el año de nacimiento basandose en la edad y la constante
// "ANIO_ACTUAL". Además de mostrar los datos con interpolación.
class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;
        double estatura;
        int añoDeNacimiento;

    // CONSTANTE CREADA
    const int ANIO_ACTUAL = 2026;


        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine()!;

        Console.WriteLine("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese su estatura: ");
        estatura = double.Parse(Console.ReadLine()!);

    // CALCULAR AÑO DE NACIMIENTO
        añoDeNacimiento = ANIO_ACTUAL - edad;

    // INTERPOLACIÓN

    Console.WriteLine($"\n___Datos Ingresados___");
    Console.WriteLine($"\nNombre: {nombre}");
    Console.WriteLine($"Edad: {edad}");
    Console.WriteLine($"Estatura: {estatura}");
    Console.WriteLine($"Año de nacimiento: {añoDeNacimiento}");
    }
}
