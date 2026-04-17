using System;

class Program
{
    static void Main()
    {
        int repetir = 1;

        while (repetir == 1)
        {
            int decision;

            Console.WriteLine("""
            Ingrese la acción que desea realizar
            1. Verificar palíndromo
            2. Traducir palabra
            3. Calificar un curso
            4. Simulación de pagos en planilla
            """);

            decision = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (decision)
            {
                case 1:
                    string palabra;
                    Console.WriteLine("Ingrese su palabra para detectar si es palíndromo o no:");
                    palabra = Console.ReadLine();

                    if (Palindromo(palabra))
                        Console.WriteLine("Es palíndromo");
                    else
                        Console.WriteLine("No es palíndromo");
                    break;

                case 2:
                    int menu;
                    string word;

                    Console.WriteLine("""
                    ¿Qué desea hacer? (Escriba el número)
                    1. Practicar lección
                    2. Finalizar el programa
                    """);

                    menu = int.Parse(Console.ReadLine());

                    if (menu == 1)
                    {
                        Console.WriteLine("Escriba una palabra:");
                        word = Console.ReadLine();
                        Traduccion(word);
                    }
                    else
                    {
                        Console.WriteLine("Gracias por preferirnos");
                        repetir = 2;
                    }
                    break;

                case 3:
                    int again = 0;

                    Random rnd = new Random();
                    double[] notas = new double[10];

                    for (int i = 0; i < notas.Length; i++)
                    {
                        notas[i] = rnd.Next(50, 101);
                    }

                    while (again != 4)
                    {
                        Console.WriteLine("""
                        ¿Qué acción desea realizar?
                        1. Reporte de rendimiento
                        2. Promedio
                        3. Nota mayor y menor
                        4. Salir del programa
                        """);

                        again = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (again)
                        {
                            case 1:
                                for (int i = 0; i < notas.Length; i++)
                                {
                                    if (notas[i] >= 50 && notas[i] <= 64)
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    else if (notas[i] <= 79)
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    else
                                        Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine(notas[i]);
                                }
                                Console.ResetColor();
                                break;

                            case 2:
                                double suma = 0;
                                for (int i = 0; i < notas.Length; i++)
                                {
                                    suma += notas[i];
                                }
                                Console.WriteLine("Promedio: " + (suma / notas.Length));
                                break;

                            case 3:
                                double mayor = notas[0];
                                double menor = notas[0];

                                for (int i = 0; i < notas.Length; i++)
                                {
                                    if (notas[i] > mayor)
                                        mayor = notas[i];

                                    if (notas[i] < menor)
                                        menor = notas[i];
                                }

                                Console.WriteLine("Nota mayor: " + mayor);
                                Console.WriteLine("Nota menor: " + menor);
                                break;

                            case 4:
                                Console.WriteLine("Saliendo...");
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                    }
                    break;

                case 4:
                    Planilla();
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            Console.WriteLine("""
            ¿Desea realizar otra acción?
            1: si
            2: no
            """);
            repetir = int.Parse(Console.ReadLine());
            Console.Clear();
        }
    }

    static bool Palindromo(string palabra)
    {
        char[] word = palabra.ToCharArray();

        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static void Traduccion(string palabra)
    {
        string[] español = { "rojo", "azul", "amarillo", "blanco", "verde" };
        string[] ingles = { "red", "blue", "yellow", "white", "green" };
        string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };

        for (int i = 0; i < español.Length; i++)
        {
            if (palabra == español[i])
            {
                Console.WriteLine(español[i] + ", " + ingles[i] + ", " + italiano[i]);
                return;
            }
        }

        Console.WriteLine("Palabra inválida");
    }

    static void Calificacion(double[] notas)
    {
        double suma = 0;
        double mayor = notas[0];
        double menor = notas[0];

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];

            if (notas[i] > mayor)
                mayor = notas[i];

            if (notas[i] < menor)
                menor = notas[i];
        }

        double promedio = suma / notas.Length;

        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Nota mayor: " + mayor);
        Console.WriteLine("Nota menor: " + menor);
    }

    static void Planilla()
    {
        string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
        double[] salario = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
        double[] horas = new double[6];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Horas de " + nombres[i] + ":");
            horas[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nPagos:");

        for (int i = 0; i < nombres.Length; i++)
        {
            double pago;

            if (horas[i] > 40)
                pago = (40 * salario[i]) + ((horas[i] - 40) * salario[i] * 1.5);
            else
                pago = horas[i] * salario[i];

            Console.WriteLine(nombres[i] + " - Q" + pago);
        }
    }
}