using Ejercicio_No._1.Interfaz.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Persona
{
    public class Profesor: Estudiante, IPersona
    {
        public int IdProfesor { get; set; }
        public string Clases { get; set; }

        public void Impresion()
        {
            base.Impresion();
            Console.WriteLine($"Id Profesor: {IdProfesor}, Clase asignada:{Clases}");
        }

        public void IngresoInfo()
        {
            base.IngresoInfo();

            Console.WriteLine("Ingrese el código del profesor:");
            IdProfesor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la clase a asignarle:");
            Clases = Console.ReadLine();
        }
    }
}
