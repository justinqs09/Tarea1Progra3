using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes que desea registrar: ");
            int CantidadDeEstudiantes;

            while (!int.TryParse(Console.ReadLine(), out CantidadDeEstudiantes) || CantidadDeEstudiantes <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido de estudiantes.");
            }

            List<Estudiante> estudiantes = new List<Estudiante>();

            for (int i = 0; i < CantidadDeEstudiantes; i++)
            {
                Console.WriteLine($"\nEstudiante {i + 1}:");

                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Edad: ");
                int edad;
                while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
                {
                    Console.WriteLine("Por favor, ingrese una edad válida.");
                }

                Console.WriteLine("Promedio: ");
                double promedio;
                while (!double.TryParse(Console.ReadLine(), out promedio) || promedio < 0)
                {
                    Console.WriteLine("Por favor, ingrese un promedio válido.");
                }

                Estudiante estudiante = new Estudiante(nombre, edad, promedio);
                estudiantes.Add(estudiante);
                Console.WriteLine($"Estudiante {nombre} agregado.");
            }

            int contador = 0;
            bool hayEstudiantesAprobados = false;
            while (contador < estudiantes.Count)
            {
                Estudiante estudiante = estudiantes[contador];

                if (estudiante.Promedio >= 70)
                {
                    hayEstudiantesAprobados = true;
                    estudiante.MostrarInfo();

                    if (estudiante.EsMayorDeEdad())
                    {
                        Console.WriteLine($"{estudiante.Nombre} es mayor de edad.");
                    }
                    else
                    {
                        Console.WriteLine($"{estudiante.Nombre} no es mayor de edad.");
                    }
                }

                contador++;
            }

            if (!hayEstudiantesAprobados)
            {
                Console.WriteLine("No hay estudiantes con promedio mayor o igual a 70.");
            }

            // Para mantener la consola abierta
            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();










        }
    }
}

