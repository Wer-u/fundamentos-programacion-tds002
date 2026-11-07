/* Jade Mariel Mateo Baez 20260706
En este proyecto se busca realizar las operaciones matematicas de:
conseguir el área y circunferencia de un círculo y la hipotenusa de un triángulo
*/

Console.WriteLine("=== CÁLCULOS GEOMÉTRICOS Y MATEMÁTICOS ===");

    Console.Write("Ingrese el radio del círculo: ");
    double radio = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese el primer cateto del triángulo (a): ");
    double catetoA = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese el segundo cateto del triángulo (b): ");
    double catetoB = double.Parse(Console.ReadLine()!);

        //Calculo del radio, usamos Math.PI, el cual tiene el valor de PI y Math.Pow que funciona para potenciar r al cuadrado.
            double areaCirculo = Math.PI * Math.Pow(radio, 2);
        
        //Calculo de la circunferencia del ciculo usando la fórmula C = 2 * PI * r
            double circunferencia = 2 * Math.PI * radio;

        // Para realizar la fórmula de pitágoras, usamos Math.Sqrt que funciona como raíz cuadrada, y dentro de paréntesis potenciamos (Math.Pow) a los dos catetos.
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));


            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("           RESULTADOS CÍRCULO           ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Radio ingresado: {radio:F2}");
            Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
            Console.WriteLine($"Circunferencia: {circunferencia:F2}");

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("       RESULTADOS TRIÁNGULO RECTÁNGULO  ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Cateto A: {catetoA:F2}");
            Console.WriteLine($"Cateto B: {catetoB:F2}");
            Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
            Console.WriteLine("----------------------------------------");