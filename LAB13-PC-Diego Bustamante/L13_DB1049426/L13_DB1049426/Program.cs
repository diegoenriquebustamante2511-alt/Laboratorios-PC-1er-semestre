using System;

namespace L13_DB1049426
{
    class Program
    {
        static void Main(string[] args)
        {
            // Persona
            Persona persona1 = new Persona();
            persona1.nombre = "Diego";
            persona1.edad = 18;
            persona1.altura = 1.75;
            persona1.estudiante = true;

            Console.WriteLine("=== Persona ===");
            Console.WriteLine("Nombre: " + persona1.nombre);
            Console.WriteLine("Edad: " + persona1.edad);
            Console.WriteLine("Altura: " + persona1.altura);
            Console.WriteLine("Estudiante: " + persona1.estudiante);

            // Vehiculo
            Vehiculo carro = new Vehiculo();
            carro.marca = "Toyota";
            carro.modelo = "Corolla";
            carro.anio = 2020;
            carro.color = "Rojo";
            carro.placa = "P123ABC";

            Console.WriteLine("\n=== Vehiculo ===");
            Console.WriteLine("Marca: " + carro.marca);
            Console.WriteLine("Modelo: " + carro.modelo);
            Console.WriteLine("Año: " + carro.anio);
            Console.WriteLine("Color: " + carro.color);
            Console.WriteLine("Placa: " + carro.placa);

            // Producto (2 objetos)
            Producto p1 = new Producto();
            p1.codigo = "001";
            p1.nombre = "Laptop";
            p1.precio = 5000;
            p1.stock = 10;
            p1.disponible = true;

            Producto p2 = new Producto();
            p2.codigo = "002";
            p2.nombre = "Mouse";
            p2.precio = 150;
            p2.stock = 50;
            p2.disponible = true;

            Console.WriteLine("\n=== Productos ===");
            Console.WriteLine(p1.nombre + " - Q" + p1.precio);
            Console.WriteLine(p2.nombre + " - Q" + p2.precio);

            // Mascota
            Mascota mascota = new Mascota();
            mascota.nombre = "Max";
            mascota.especie = "Perro";
            mascota.edad = 3;
            mascota.peso = 12.5;
            mascota.vacunado = true;

            Console.WriteLine("\n=== Mascota ===");
            Console.WriteLine("Nombre: " + mascota.nombre);
            Console.WriteLine("Especie: " + mascota.especie);
            Console.WriteLine("Edad: " + mascota.edad);
            Console.WriteLine("Peso: " + mascota.peso);
            Console.WriteLine("Vacunado: " + mascota.vacunado);
        }
    }
}