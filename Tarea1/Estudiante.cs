using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Promedio { get; set; }

        public Estudiante(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

        
        public void MostrarInfo() {
            Console.WriteLine($"Nombre: {Nombre}, Edad:{Edad}, Promedio:{Promedio}");
        
        }
        public bool EsMayorDeEdad()
        {

            return Edad >= 18;

        }

    }
    
}
