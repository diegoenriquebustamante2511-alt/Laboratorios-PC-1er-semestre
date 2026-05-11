using System;

namespace L14_DB1049426
{
    class Estudiante
    {
        public string nombre;
        public int edad;
        public string grado;
        public decimal[] notas;

        //Constructor

        public Estudiante(string nombre, int edad, string grado, decimal[] notas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notas;
        }

        //Calcular promedio

        public decimal CalcularPromedio()
        {
            decimal suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }

            return suma / notas.Length;
        }

        //Mostrar informacion

        public void MostrarInformacion()
        {
            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);

            Console.Write("Notas: ");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Promedio: " + CalcularPromedio());

            if (Aprobar())
            {
                Console.WriteLine("Estado: Aprobado");
            }
            else
            {
                Console.WriteLine("Estado: Reprobado");
            }
        }

        //Aprobar

        public bool Aprobar()
        {
            return CalcularPromedio() >= 61;
        }

        //Agregar nota

        public void AgregarNota(decimal nuevaNota)
        {
            decimal[] nuevoArreglo = new decimal[notas.Length + 1];

            for (int i = 0; i < notas.Length; i++)
            {
                nuevoArreglo[i] = notas[i];
            }

            nuevoArreglo[notas.Length] = nuevaNota;

            notas = nuevoArreglo;

            Console.WriteLine("Nota agregada correctamente");
        }
    }
}