using Ejercicio_No._1.Interfaz.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Persona
{
    public class Estudiante:Persona, IPersona
    {
        public Estudiante()
        {
        }

        public Estudiante(string grado)
        {
            this.grado = grado;
        }

        public string grado { get; set; }

        public void Impresion()
        {
            base.Impresion();
            Console.WriteLine($"Grado: {grado}");
        }

        public void IngresoInfo()
        {
            base.IngresoInfo();
            Console.WriteLine("Ingresa el grado del estudiante:");
            grado = Console.ReadLine();
        }
    }
}
