using System;

namespace LAB5_D_1049426
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int num1;
            Console.WriteLine("Ingrese un número");
            num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
                Console.WriteLine("El número es positivo.");
            else if (num1 < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");


            //Ejercicio 2
            int año;
            Console.WriteLine("Ingrese un año");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && año % 100 != 0)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año no es bisiesto");


            //Ejercicio 3
            double ingreso;
            Console.WriteLine("Ingrese su salario mensual");

            if (!double.TryParse(Console.ReadLine(), out ingreso))
            {
                Console.WriteLine("Entrada inválida para el salario.");
            }
            else
            {
                Console.Write("¿Tiene multa pendiente? S/N: ");
                bool multa = Console.ReadLine().ToUpper() == "S";

                if (ingreso > 500 && ingreso <= 1000)
                    Console.WriteLine(multa ? "Usted debe pagar Q20" : "Usted debe pagar Q10");

                else if (ingreso > 1000 && ingreso <= 3000)
                    Console.WriteLine(multa ? "Usted debe pagar Q30" : "Usted debe pagar Q15");

                else if (ingreso > 3000 && ingreso <= 6000)
                    Console.WriteLine(multa ? "Usted debe pagar Q100" : "Usted debe pagar Q50");

                else if (ingreso > 6000 && ingreso <= 9000)
                    Console.WriteLine(multa ? "Usted debe pagar Q150" : "Usted debe pagar Q75");

                else if (ingreso > 9000 && ingreso <= 12000)
                    Console.WriteLine(multa ? "Usted debe pagar Q200" : "Usted debe pagar Q100");

                else if (ingreso > 12000)
                    Console.WriteLine(multa ? "Usted debe pagar Q300" : "Usted debe pagar Q150");

                else
                    Console.WriteLine("Rango de ingreso no contemplado.");
            }


            //Ejercicio 4
            int horas;
            int pago;
            int total;

            Console.WriteLine("Ingrese la cantidad de horas que estuvo estacionado:");

            if (!int.TryParse(Console.ReadLine(), out horas))
            {
                Console.WriteLine("Entrada inválida para las horas.");
            }
            else
            {
                total = horas * 10;
                Console.WriteLine("Total a pagar: Q" + total);

                Console.WriteLine("Ingrese el monto con el que realizará el pago:");

                if (!int.TryParse(Console.ReadLine(), out pago))
                {
                    Console.WriteLine("Entrada inválida para el pago.");
                }
                else
                {
                    if (pago < total)
                    {
                        Console.WriteLine("Monto insuficiente. Pago rechazado.");
                    }
                    else if (pago == total)
                    {
                        Console.WriteLine("Pago exacto. No se requiere cambio.");
                    }
                    else
                    {
                        int vuelto = pago - total;
                        Console.WriteLine("Su vuelto es: Q" + vuelto);

                        int b100 = vuelto / 100;
                        vuelto %= 100;

                        int b50 = vuelto / 50;
                        vuelto %= 50;

                        int b20 = vuelto / 20;
                        vuelto %= 20;

                        int b10 = vuelto / 10;
                        vuelto %= 10;

                        int b5 = vuelto / 5;
                        vuelto %= 5;

                        int b1 = vuelto;

                        Console.WriteLine("Billetes entregados:");
                        Console.WriteLine("Q100: " + b100);
                        Console.WriteLine("Q50: " + b50);
                        Console.WriteLine("Q20: " + b20);
                        Console.WriteLine("Q10: " + b10);
                        Console.WriteLine("Q5: " + b5);
                        Console.WriteLine("Q1: " + b1);
                    }
                }
            }

            Console.WriteLine("Gracias por su uso. ¡Que tenga un buen día!");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}