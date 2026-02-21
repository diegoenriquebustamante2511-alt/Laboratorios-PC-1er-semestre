using System;
namespace LAB5_D_1049426
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Determinar si un número es positivo, negativo o cero
            int num1;
            Console.WriteLine("Ingrese un número");
            num1 = int.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
            //Ejercicio 2: Determinar si un año es bisiesto
            int año;
            Console.WriteLine("Ingrese un año");
            año = int.Parse(Console.ReadLine());
            if (año % 4 == 0 && año % 100 != 0)
            {
                Console.WriteLine("El año es bisiesto");
            } 
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            //Ejercicio 3: Boleto de ornato
            int ingreso;
            bool multa;
            Console.WriteLine("Ingrese su salario mensual");
            ingreso = int.Parse(Console.ReadLine());
            if (ingreso==500.01&& )
        }
    }
}


