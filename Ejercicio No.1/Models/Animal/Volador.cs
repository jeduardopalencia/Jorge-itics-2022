using Ejercicio_No._1.Interfaz.IAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Animal
{
    public class Volador : Terrestres, IAnimal
    {
        public Volador(double tamañoAlas, string TipoComida)
        {
            TamañoAlas = tamañoAlas;
        }

        public Volador()
        {

        }

        public double TamañoAlas { get; set; }

        Volador[] volador = new Volador[5];
        public void IngresoInformacion()
        {
            volador[0] = new Volador();
            volador[1] = new Volador();
            volador[2] = new Volador();
            volador[3] = new Volador();
            volador[4] = new Volador();

            base.IngresoInformacion();

            for (int i = 0; i < volador.Length; i++)
            {
                Console.WriteLine("Ingresa el tamaño de las alas:");
                volador[i].TamañoAlas = Convert.ToDouble(Console.ReadLine());
            }

        }
        public new void Impresion()
        {
            base.Impresion();

            for (int i = 0; i < volador.Length; i++)
            {
                Console.WriteLine($"Tamaño de las alas: {volador[i].TamañoAlas}");
            }
        }
    }
}
