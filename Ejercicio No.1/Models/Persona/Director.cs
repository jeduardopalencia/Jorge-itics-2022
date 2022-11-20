using Ejercicio_No._1.Interfaz.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Persona
{
    public class Director : Persona, IPersona
    {
        public string TipoDirector { get; set; }
        public Director()
        {
        }

        public Director(string tipoDirector)
        {
            TipoDirector = tipoDirector;
        }

        public void Impresion()
        {
            base.Impresion();
            Console.WriteLine($"Tipo de director: {TipoDirector}");
        }

        public void IngresoInfo()
        {
            base.IngresoInfo();
            Console.WriteLine("Ingresa el tipo de director:");
            TipoDirector = Console.ReadLine();
        }
    }
}
