using Ejercicio_No._1.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Aulas
{
    public class Aula : Alumno, IAula
    {
        public Aula()
        {
           
        }

        public Aula(string grado, string materia, int totalAlumnos)
        {
            Grado = grado;
            Materia = materia;
            TotalAlumnos = totalAlumnos;
        }

        public string Grado { get; set; }
        public string Materia { get; set; }
        public int TotalAlumnos { get; set; }

        List<Aula> aula = new List<Aula>();
        public void ImpresionAula()
        {
            foreach(var au in aula)
            {
                Console.WriteLine($"Grado: {au.Grado}, Materia: {au.Materia}, Total alumnos: {au.TotalAlumnos}");
            }        
        }

        public void DatosAula()
        {
            Console.WriteLine("Ingresa el grado:");
            Grado = Console.ReadLine();

            Console.WriteLine("Ingresa la materia:");
            Materia = Console.ReadLine();

            Console.WriteLine("Ingresa el total de alumnos:");
            TotalAlumnos = Convert.ToInt32(Console.ReadLine());
        }
    }
}
