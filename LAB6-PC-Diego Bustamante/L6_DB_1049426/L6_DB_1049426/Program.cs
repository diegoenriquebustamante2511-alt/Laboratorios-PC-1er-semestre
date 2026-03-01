
using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        double temperatura, temperaturaf;
        int opcion;
        Console.WriteLine("Ingrese la temperatura a convertir:");
        temperatura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Seleccione la conversión que desea realizar:");
        Console.WriteLine("1. Celcius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celcius");
        Console.WriteLine("3. Celcius a Kelvin");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                temperaturaf = (temperatura * 9 / 5) + 32;
                Console.WriteLine("La temperatura en fahrenheit es " + temperaturaf);
                break;
            case 2:
                temperaturaf = (temperatura - 32) * 5 / 9;
                Console.WriteLine("La temperatura en celcius es " + temperaturaf);
                break;
            case 3:
                temperaturaf = temperatura + 273.15;
                Console.WriteLine("La temperatura en Kelvin es de " + temperaturaf);
                break;
        }
        // Ejercicio 2
        double cantidad, precio = 10, total;
        int cliente;

        Console.WriteLine("¿Cuántos bubalus de Q10 desea comprar?");
        cantidad = double.Parse(Console.ReadLine());

        Console.WriteLine("¿Cuenta con una membresía VIP? Si=1 / No=2");
        cliente = int.Parse(Console.ReadLine());

        double subtotal = cantidad * precio;

        if (cantidad > 100)
        {
            Console.WriteLine("Usted tendrá un descuento del 15% por compra mayorista");
            total = subtotal - (subtotal * 0.15);
            Console.WriteLine("El total a pagar es de Q" + total);

        }
        else
        {
            switch (cliente)
            {
                case 1:
                    Console.WriteLine("Usted tendrá un descuento del 10% por ser cliente VIP");
                    total = subtotal - (subtotal * 0.10);
                    Console.WriteLine("El total a pagar es de Q" + total);

                    break;

                case 2:
                    Console.WriteLine("Usted tiene un 5% de descuento por ser cliente regular");
                    total = subtotal - (subtotal * 0.05);
                    Console.WriteLine("El total a pagar es de Q" + total);
                    break;

                default:
                    Console.WriteLine("Tipo de cliente inválido");
                    break;
            }
        }

        // Ejercicio 3
        double tiempo, totalhoras;
        Console.WriteLine("¿Cuantas horas ha estado estacionado en el parqueo?");
        tiempo = double.Parse(Console.ReadLine());
        switch (tiempo)
        {
            case double t when (t < 2):
                totalhoras = tiempo * 5;
                Console.WriteLine("El costo es de $" + totalhoras);
                break;
            case double t when (t >= 2 && t <= 5):
                totalhoras = tiempo * 4;
                Console.WriteLine("El costo es de $"+ totalhoras);
                break;
            case double t when (t > 5):
                totalhoras = tiempo * 3;
                Console.WriteLine("El costo es de $" + totalhoras);
                break;
            case double t when (t % 2 <0):
                Console.WriteLine("Tiempo inválido");
                break;

        }
        //Ejercico 4
        double puntuacion, dinero;
        Console.WriteLine("Ingrese su puntuación en obtenida en la evaluación");
        puntuacion = double.Parse(Console.ReadLine());
        switch (puntuacion)
        {
            case double p when (p == 0.0):
                Console.WriteLine("Usted ha tenido una calificación inaceptable, no recibirá ningún premio");
                break;
            case double p when (p == 0.4):
                dinero = (0.4 * 2400);
                Console.WriteLine("Usted ha obtenido una calificación aceptable, por lo que obtendrá un bono en euros de "+ dinero);
                break;
            case double p when (p >= 0.6):
                dinero = 2400 * puntuacion;
                Console.WriteLine("Usted ha tenido una puntuación meritoria, por lo que recibirá un bono en euros de " + dinero);
                break;
            default:
                Console.WriteLine("Puntuación inválida");
                break;
        }
            
        Console.ReadKey();
    }

}







    



