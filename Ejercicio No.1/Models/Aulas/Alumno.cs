using Ejercicio_No._1.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Aulas
{
    public class Alumno: Nota, IEstudiante
    {
        public Alumno()
        {
        }

        public Alumno(int idAlumno, string nombre, int edad, string genero, int promedio)
        {
            IdAlumno = idAlumno;
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Promedio = promedio;
        }

        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public int Promedio { get; set; }

        public Nota[] notas = new Nota[4];

        public void Estudiante()
        {
            int pro = 0;
            
            notas[0] = new Nota();
            notas[1] = new Nota();
            notas[2] = new Nota();
            notas[3] = new Nota();

            Console.WriteLine("Ingresa el código del estudiante:");
            IdAlumno = Convert.ToInt32(Console.ReadLine());

            if (IdAlumno <= 5)
            {
                do
                {
                    Console.WriteLine("Este código ya exite ingresa otro!");
                } while (IdAlumno > 5);
            }
            else
            {
                Console.WriteLine("Ingresa el nombre del estudiante:");
                Nombre = Console.ReadLine();

                Console.WriteLine($"Ingresa la edad del {Nombre}");
                Edad = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < notas.Length; i++)
                {
                    Console.WriteLine($"Ingresa la nota {i + 1}:");
                    notas[i].Notas = Convert.ToInt32(Console.ReadLine());

                    pro += notas[i].Notas;
                }
                Promedio = pro / 4;

                Console.WriteLine($"Ingresa el genero de {Nombre}");
                Genero = Console.ReadLine();
            }
        }
       
        public void ImpresionEstudiante()
        {
            Console.WriteLine($"Clave del alumno: {IdAlumno}, nombre del estudiante: {Nombre}, Edad: {Edad}, Genero: {Genero}");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Notas: {notas[i].Notas}");
            }
            Console.WriteLine($"Promedio: {Promedio}");
        }
    }
}
