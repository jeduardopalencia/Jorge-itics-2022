using Ejercicio_No._1.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Series
{
    public class Serie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Temporadas { get; set; }
        public double Duracion { get; set; }
        public string Clasificación { get; set; }

        Dictionary<int, Serie> series = new Dictionary<int, Serie>();

        public void IngresarSerie()
        {
            try
            {
                Console.WriteLine("Ingresa el código de la serie:");
                Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre de la serie:");
                Nombre = Console.ReadLine();

                Console.WriteLine($"Cual es la descripción de {Nombre}");
                Descripcion = Console.ReadLine();

                Console.WriteLine($"¿Cuantas temporadas tiene {Nombre}?");
                Temporadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"¿Cuanto dura {Nombre}?");
                Duracion = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"¿Que clasificación es?");
                Clasificación = Console.ReadLine();

                series.TryAdd(Id, new Serie()
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Temporadas = Temporadas,
                    Duracion = Duracion,
                    Clasificación = Clasificación
                });
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e}");
            }
            
        }
                       
       public void BuscarSerie() 
       {
            try
            {
                Console.WriteLine("Ingresa el código de la serie a buscar:");
                Id = Convert.ToInt32(Console.ReadLine());

                foreach(var serie in series.Keys)
                {
                    if (Id == serie)
                    {
                        Console.WriteLine($"Nombre: {Nombre}, Descripción: {Descripcion}" +
                            $"Temporadas: {Temporadas}, Duración: {Duracion}," +
                            $"Clasificación: {Clasificación}");
                    }
                    else
                    {
                        Console.WriteLine("El código ingresado no exite!");
                    }break;
                }

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
       }
    }
}
