using System;

class Program
{
    static void Main()
    {

        // EJERCICIO 1

        int num1, num2;
        Console.WriteLine("Ingrese el primer número");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("La suma de los dígitos es: " + (SumaDigitos(num1) + SumaDigitos(num2)));



        // EJERCICIO 2

        double saldo, retiro;

        Console.WriteLine("\nIngrese su saldo actual:");
        saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("¿Qué cantidad desea retirar?");
        retiro = double.Parse(Console.ReadLine());

        string mensajeSaldo = ajuste(ref saldo, retiro);
        Console.WriteLine(mensajeSaldo);



        // EJERCICIO 3

        double tempC, tempF = 0;

        Console.WriteLine("\nIngrese temperatura en Celsius:");
        tempC = double.Parse(Console.ReadLine());

        Console.WriteLine(ConvertirTemperatura(tempC, ref tempF));



        // EJERCICIO 4

        int puntos;

        Console.WriteLine("\nIngrese los puntos del estudiante:");
        puntos = int.Parse(Console.ReadLine());

        puntos = agregarPuntos(ref puntos);
        Console.WriteLine("Después de agregar puntos: " + puntos);

        puntos = quitarPuntos(ref puntos);
        Console.WriteLine("Después de quitar puntos: " + puntos);

        Console.WriteLine("Nivel: " + obtenerNivel(puntos));
        Console.WriteLine("Estado: " + evaluarEstado(puntos));
    }



    // FUNCIONES EJERCICIO 1

    static int SumaDigitos(int numero)
    {
        int suma = 0;
        numero = Math.Abs(numero);

        while (numero != 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        return suma;
    }



    // FUNCIONES EJERCICIO 2

    static string ajuste(ref double saldo, double retiro)
    {
        if (saldo >= retiro)
        {
            saldo -= retiro;
            return "Retiro exitoso. Saldo restante: Q" + saldo;
        }
        else
        {
            return "Fondos insuficientes. Su saldo actual es: Q" + saldo;
        }
    }



    // FUNCIONES EJERCICIO 3

    static string ConvertirTemperatura(double celsius, ref double fahrenheit)
    {
        fahrenheit = (celsius * 9 / 5) + 32;
        return celsius + "°C equivalen a " + fahrenheit + "°F";
    }



    // FUNCIONES EJERCICIO 4

    static int agregarPuntos(ref int puntos)
    {
        puntos += 10;
        if (puntos > 100)
            puntos = 100;
        return puntos;
    }

    static int quitarPuntos(ref int puntos)
    {
        puntos -= 7;
        if (puntos < 0)
            puntos = 0;
        return puntos;
    }

    static string obtenerNivel(int puntos)
    {
        if (puntos >= 80)
            return "Avanzado";
        else if (puntos >= 50)
            return "Intermedio";
        else
            return "Básico";
    }

    static string evaluarEstado(int puntos)
    {
        if (puntos == 100)
            return "Excelente";
        else if (puntos >= 70)
            return "Aprobado";
        else
            return "Reprobado";
    }
}
