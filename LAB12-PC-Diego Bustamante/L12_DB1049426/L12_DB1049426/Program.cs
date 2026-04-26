using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int[,] m1 = new int[5, 5];
                    llenar5x5(m1);

                    Console.WriteLine("Suma diagonal principal: " + sumaDiagonalPrincipal(m1));
                    Console.WriteLine("Suma diagonal secundaria: " + sumaDiagonalSecundaria(m1));
                    break;

                case 2:
                    int[,] m2 = new int[4, 6];
                    llenar4x6(m2);

                    Console.WriteLine("Pares: " + contarPares(m2));
                    Console.WriteLine("Impares: " + contarImpares(m2));
                    break;

                case 3:
                    float[,] notas = new float[5, 4];
                    ingresarNotas(notas);

                    for (int i = 0; i < 5; i++)
                    {
                        float prom = promedio(notas, i);
                        Console.WriteLine("Estudiante " + (i + 1) +
                            " - Promedio: " + prom +
                            " - " + (aprueba(prom) ? "Aprobado" : "Reprobado"));
                    }
                    break;

                case 4:
                    int[,] m3 = new int[3, 3];
                    llenar3x3(m3);

                    Console.WriteLine(esSimetrica(m3) ? "Es simétrica" : "No es simétrica");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona una tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    //  FUNCIONES 

    // Ejercicio 1
    static void llenar5x5(int[,] m)
    {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write("[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int sumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, i];
        return suma;
    }

    static int sumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, 4 - i];
        return suma;
    }

    // Ejercicio 2
    static void llenar4x6(int[,] m)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 6; j++)
            {
                Console.Write("[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int contarPares(int[,] m)
    {
        int c = 0;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 6; j++)
                if (m[i, j] % 2 == 0)
                    c++;
        return c;
    }

    static int contarImpares(int[,] m)
    {
        int c = 0;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 6; j++)
                if (m[i, j] % 2 != 0)
                    c++;
        return c;
    }

    // Ejercicio 3
    static void ingresarNotas(float[,] m)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1));
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Nota " + (j + 1) + ": ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static float promedio(float[,] m, int est)
    {
        float suma = 0;
        for (int j = 0; j < 4; j++)
            suma += m[est, j];
        return suma / 4;
    }

    static bool aprueba(float prom)
    {
        return prom >= 61;
    }

    // Ejercicio 4
    static void llenar3x3(int[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write("[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static bool esSimetrica(int[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (m[i, j] != m[j, i])
                    return false;

        return true;
    }
}