using System;

namespace L14_DB1049426
{
    class Producto
    {
        public string nombre;
        public decimal precio;
        public int cantidad;

        //Constructor

        public Producto(string nombre, decimal precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        //Mostrar informacion

        public void MostrarInformacion()
        {
            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("Precio: Q" + precio);
            Console.WriteLine("Cantidad: " + cantidad);
        }

        //Vender

        public void Vender(int cantidadVendida)
        {
            if (cantidad >= cantidadVendida)
            {
                cantidad -= cantidadVendida;

                Console.WriteLine("Venta realizada");
            }
            else
            {
                Console.WriteLine("No hay suficiente stock");
            }
        }

        //Reabastecer

        public void Reabastecer(int cantidadNueva)
        {
            cantidad += cantidadNueva;

            Console.WriteLine("Stock actualizado");
        }
    }
}