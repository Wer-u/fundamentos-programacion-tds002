
/* Jade Mariel Mateo Baez 20260706
En ese proyecto trata de calcular el salario el salario bruto, los descuentos afp y sfs,
y el neto de un usuario que ingrese nombre, horas trabajadas y pago por hora. */


const double afp = 0.0287;
const double sfs = 0.0304;

Console.WriteLine("--- SISTEMA DE NÓMINA ---");

Console.Write("\nIngrese el nombre del empleado: ");
string nombre = Console.ReadLine()!;

Console.Write("Ingrese las horas trabajadas: ");
double horasRealizadas = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese el pago por hora: ");
double pagoPorHora = double.Parse(Console.ReadLine()!);

// En esta parte se realizan los calculos
double bruto = horasRealizadas * pagoPorHora;
double montoAfp = bruto * afp; //Se calcula cuánto se descuenta el salario bruto para luego restarlo en la variable salarioNeto
double montoSfs = bruto * sfs;
double salarioNeto = bruto - montoAfp - montoSfs;

//Use .ToUpper para que se cree un nuevo string con el contendio en mayúsculas
string nombreMayus = nombre.ToUpper();

Console.WriteLine("\n----------------------------------------");
Console.WriteLine($"Empleado: {nombreMayus}");
Console.WriteLine($"Salario Bruto: RD$ {bruto:N2}");
Console.WriteLine($"Descuento AFP (2.87%): RD$ {montoAfp:N2}");
Console.WriteLine($"Descuento SFS (3.04%): RD$ {montoSfs:N2}");
Console.WriteLine($"Salario Neto: RD$ {salarioNeto:N2}");
Console.WriteLine("------------------------------------------");

