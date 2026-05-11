using System;

namespace L14_DB1049426
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1

            Console.WriteLine("Ejercicio 1");

            Console.Write("\nIngrese el titular de la cuenta 1: ");
            string titular1 = Console.ReadLine();

            Console.Write("Ingrese el numero de cuenta 1: ");
            string numero1 = Console.ReadLine();

            Console.Write("Ingrese el saldo inicial de la cuenta 1: ");
            decimal saldo1 = Convert.ToDecimal(Console.ReadLine());

            CuentaBancaria cuenta1 = new CuentaBancaria(
                titular1,
                numero1,
                saldo1
            );

            Console.Write("\nIngrese el titular de la cuenta 2: ");
            string titular2 = Console.ReadLine();

            Console.Write("Ingrese el numero de cuenta 2: ");
            string numero2 = Console.ReadLine();

            Console.Write("Ingrese el saldo inicial de la cuenta 2: ");
            decimal saldo2 = Convert.ToDecimal(Console.ReadLine());

            CuentaBancaria cuenta2 = new CuentaBancaria(
                titular2,
                numero2,
                saldo2
            );

            cuenta1.MostrarInformacion();
            cuenta2.MostrarInformacion();

            Console.Write("\nIngrese monto a depositar en cuenta 1: ");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Saldo antes: Q" + cuenta1.saldo);

            cuenta1.Depositar(deposito);

            Console.WriteLine("Saldo despues: Q" + cuenta1.saldo);

            Console.Write("\nIngrese monto a retirar de cuenta 2: ");
            decimal retiro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Saldo antes: Q" + cuenta2.saldo);

            cuenta2.Retirar(retiro);

            Console.WriteLine("Saldo despues: Q" + cuenta2.saldo);



            //Ejercicio 2

            Console.WriteLine("\nEjercicio 2");

            Console.Write("\nIngrese nombre del producto 1: ");
            string nombre1 = Console.ReadLine();

            Console.Write("Ingrese precio del producto 1: ");
            decimal precio1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese cantidad del producto 1: ");
            int cantidad1 = Convert.ToInt32(Console.ReadLine());

            Producto producto1 = new Producto(
                nombre1,
                precio1,
                cantidad1
            );

            Console.Write("\nIngrese nombre del producto 2: ");
            string nombre2 = Console.ReadLine();

            Console.Write("Ingrese precio del producto 2: ");
            decimal precio2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese cantidad del producto 2: ");
            int cantidad2 = Convert.ToInt32(Console.ReadLine());

            Producto producto2 = new Producto(
                nombre2,
                precio2,
                cantidad2
            );

            producto1.MostrarInformacion();
            producto2.MostrarInformacion();

            Console.Write("\nIngrese cantidad a vender del producto 1: ");
            int venta = Convert.ToInt32(Console.ReadLine());

            producto1.Vender(venta);

            Console.Write("\nIngrese cantidad a reabastecer del producto 2: ");
            int reabastecer = Convert.ToInt32(Console.ReadLine());

            producto2.Reabastecer(reabastecer);

            producto1.MostrarInformacion();
            producto2.MostrarInformacion();



            //Ejercicio 3

            Console.WriteLine("\nEjercicio 3");

            Console.Write("\nIngrese nombre del estudiante 1: ");
            string estudianteNombre1 = Console.ReadLine();

            Console.Write("Ingrese edad del estudiante 1: ");
            int edad1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese grado del estudiante 1: ");
            string grado1 = Console.ReadLine();

            decimal[] notas1 = new decimal[3];

            for (int i = 0; i < notas1.Length; i++)
            {
                Console.Write("Ingrese nota " + (i + 1) + ": ");
                notas1[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Estudiante estudiante1 = new Estudiante(
                estudianteNombre1,
                edad1,
                grado1,
                notas1
            );

            Console.Write("\nIngrese nombre del estudiante 2: ");
            string estudianteNombre2 = Console.ReadLine();

            Console.Write("Ingrese edad del estudiante 2: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese grado del estudiante 2: ");
            string grado2 = Console.ReadLine();

            decimal[] notas2 = new decimal[3];

            for (int i = 0; i < notas2.Length; i++)
            {
                Console.Write("Ingrese nota " + (i + 1) + ": ");
                notas2[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Estudiante estudiante2 = new Estudiante(
                estudianteNombre2,
                edad2,
                grado2,
                notas2
            );

            estudiante1.MostrarInformacion();
            estudiante2.MostrarInformacion();

            Console.Write("\nIngrese nueva nota para estudiante 2: ");
            decimal nuevaNota = Convert.ToDecimal(Console.ReadLine());

            estudiante2.AgregarNota(nuevaNota);

            estudiante2.MostrarInformacion();

            Console.ReadKey();
        }
    }
}