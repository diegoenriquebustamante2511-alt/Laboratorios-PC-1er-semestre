using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1 - Números del 1 al 20
        string nombre = "Diego Enrique Bustamante Chigua";
        int carnet = 1049426;
        int indice = 1;

        Console.WriteLine("Nombre: " + nombre + " Carnet: " + carnet);

        while (indice <= 20)
        {
            if (indice % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(indice);
            indice++;
        }

        Console.ResetColor();

        // Ejercicio 2 - Divisores de un número
        int numero;
        int divisor = 1;

        Console.WriteLine("\nIngrese un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Divisores del número:");

        while (divisor <= numero)
        {
            if (numero % divisor == 0)
            {
                Console.WriteLine(divisor);
            }

            divisor++;
        }
        //Ejercicio 3 - Serie de Fibonacci
        int limite;
        int n1 = 0;
        int n2 = 1;
        int siguiente;

        Console.WriteLine("Ingrese hasta cuantos números quiere la serie de Fibonacci:");
        limite = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < limite; i++)
        {
            Console.WriteLine(n1);

            siguiente = n1 + n2;
            n1 = n2;
            n2 = siguiente;
        }
        //Ejercicio 4 - Ciclos anidados (Tablas de multiplicar)

        int tabla, multiplicador;

        for (tabla = 1; tabla <= 12; tabla++)
        {
            Console.WriteLine("Tabla del " + tabla);

            for (multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine(tabla + " x " + multiplicador + " = " + (tabla * multiplicador));
            }

            Console.WriteLine();
        }

    }
}