namespace _02_Variables;

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
