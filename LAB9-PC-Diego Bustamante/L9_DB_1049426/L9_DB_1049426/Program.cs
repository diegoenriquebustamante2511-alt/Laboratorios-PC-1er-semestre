using System;
using System.Diagnostics.Contracts;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        string palabra1, palabra2;
        Console.WriteLine("Ingrese su palabra favorita");
        palabra1 = Convert.ToString(Console.ReadLine());
        contar(palabra1);
        Console.WriteLine("Ingrese su segunda palabra favorita");
        palabra2 = Convert.ToString(Console.ReadLine());
        contar(palabra2);

        //Ejercicio 2
        int a = 2026;
        int b = 4563;
        Console.WriteLine($"\nLos valores al principio son a={a} y b={b}");
        cambiar(ref a, ref b);
        Console.WriteLine($"Los valores despues de cambiar son a={a} y b={b}\n");

        //Ejercicio 3
        double ticket = 55;
        double descuento = 0.15;
        Console.WriteLine($"El precio del ticket original es de {ticket}");
        cine(descuento, ref ticket);
        Console.WriteLine($"El precio del ticket con su descuento es de {ticket}");

        //Ejercicio 4

        // Ejercicio 4
        int pv = 10;
        bool jugando = true;

        while (jugando)
        {
            Console.WriteLine("\n--- MENÚ DE JUEGO ---");
            Console.WriteLine("1. Recibir daño (-5)");
            Console.WriteLine("2. Curarse (+3)");
            Console.WriteLine("3. Ver salud actual");
            Console.WriteLine("4. Terminar juego");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    Dañar(ref pv);
                    break;
                case "2":
                    Curar(ref pv);
                    break;
                case "3":
                    Mostrar(pv);
                    break;
                case "4":
                    Nota(pv);
                    jugando = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void contar(string text)
    {
        //Ejercicio 1
        int longitud = text.Length;
        Console.WriteLine("Su texto tiene " + longitud);
    }

    //Ejercicio 2
    static void cambiar(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    //Ejercicio 3
    static void cine(double descuento, ref double precio)
    {
        precio = precio - (precio * descuento);
    }
    //Ejercicio 4
    static void Contar(string texto)
    {
        Console.WriteLine("Cantidad de caracteres: " + texto.Length);
    }

    // Ejercicio 2
    static void Cambiar(ref int n1, ref int n2)
    {
        int temporal = n1;
        n1 = n2;
        n2 = temporal;
    }

    // Ejercicio 3
    static void Descuento(double porc, ref double total)
    {
        total = total - (total * porc);
    }

    // Ejercicio 4
    static void Dañar(ref int pv)
    {
        int daño = 5;
        pv -= daño;
        if (pv < 0) pv = 0;
        Console.WriteLine($"¡Ouch! Has perdido {daño} puntos de vida.");
    }

    static void Curar(ref int pv)
    {
        int curacion = 3;
        pv += curacion;
        if (pv > 15) pv = 15;
        Console.WriteLine($"¡Genial! Has recuperado {curacion} puntos de vida.");
    }

    static void Mostrar(int pv)
    {
        if (pv >= 11) Console.ForegroundColor = ConsoleColor.Green;
        else if (pv >= 6) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"Puntos de Vida (PV): {pv}");
        Console.ResetColor();
    }

    static void Nota(int pv)
    {
        Console.Write("Calificación de desempeño: ");
        if (pv == 15) Console.WriteLine("S");
        else if (pv >= 11) Console.WriteLine("A");
        else if (pv >= 6) Console.WriteLine("B");
        else if (pv >= 1) Console.WriteLine("C");
        else Console.WriteLine("F (Derrotado)");
    }
}
