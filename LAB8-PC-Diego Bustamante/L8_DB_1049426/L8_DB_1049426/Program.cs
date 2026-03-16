using System;

class Program
{
    static void Main()
    {
        //Numero mayor, menor y promedio de 20 números
        double sumaTotal = 0;
        double numeroMayor = double.MinValue;
        double numeroMenor = double.MaxValue;

        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine("Ingrese el número " + (j + 1) + ":");
                double numeroIngresado = double.Parse(Console.ReadLine());
                sumaTotal += numeroIngresado;

                if (numeroIngresado > numeroMayor)
                {
                    numeroMayor = numeroIngresado;
                }

                if (numeroIngresado < numeroMenor)
                {
                    numeroMenor = numeroIngresado;
                }
            }

            Console.WriteLine("Mayor: " + numeroMayor);
            Console.WriteLine("Menor: " + numeroMenor);
            Console.WriteLine("Promedio " + (sumaTotal / 20));
        }
        //Números del 1 al 100 con condiciones
        for (int i = 0; i < 1; i++)
        {
            for (int j = 1; j <= 100; j++)
            {
                if (j % 2 == 0 && j % 7 == 0)
                {
                    Console.WriteLine(j + " ParSiete");
                }
                else if (j % 7 == 0)
                {
                    Console.WriteLine(j + " Siete");
                }
                else if (j % 2 == 0)
                {
                    Console.WriteLine(j + " Par");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
        }
        //Compras de 10 clientes
        double acumuladoVentasDia = 0;
        int conteoClientesDescuento = 0;

        for (int i = 0; i < 1; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("Monto de compra para cliente " + j + ": ");
                double montoCompraIndividual = double.Parse(Console.ReadLine());
                double valorDescuento = 0;

                if (montoCompraIndividual > 700)
                {
                    valorDescuento = montoCompraIndividual * 0.12;
                    conteoClientesDescuento++;
                }
                else if (montoCompraIndividual > 300)
                {
                    valorDescuento = montoCompraIndividual * 0.05;
                    conteoClientesDescuento++;
                }

                double totalAPagar = montoCompraIndividual - valorDescuento;
                acumuladoVentasDia += totalAPagar;
                Console.WriteLine("Total a pagar: " + totalAPagar);
            }
        }
        Console.WriteLine("Clientes con descuento: " + conteoClientesDescuento);
        Console.WriteLine("Total general del día: " + acumuladoVentasDia);

        //Solicitar un número y pedir que elija una opción
        Console.WriteLine("Ingrese un número entero positivo: ");
        int numeroLimite=int.Parse(Console.ReadLine());
        Console.WriteLine("Opciones: ");
        Console.WriteLine("1. Descendente ");
        Console.WriteLine("2. Múltiplos de 3");
        Console.WriteLine("3. Múltiplos de 5");
        int opcion = int.Parse(Console.ReadLine());
        for (int i = 0; i < 1; i++)
        {
            if (opcion == 1)
            {
                for (int j = numeroLimite; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
            }
            else if (opcion == 2)
            {
                for (int j = 3; j <= numeroLimite; j += 3)
                {
                    Console.Write(j + " ");
                }
            }
            else if (opcion == 3)
            {
                for (int j = 5; j <= numeroLimite; j += 5)
                {
                    Console.Write(j + " ");
                }
            }
        }
        //Triangulo de asteriscos
        Console.WriteLine("Ingrese cantidad de filas que desea para el triángulo: ");
        int filas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= filas; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}