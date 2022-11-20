using Ejercicio_No._1.Interfaz.IAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Animal
{
    public class Terrestres: Animal, IAnimal
    {
        public Terrestres()
        {
        }
        public Terrestres(string tipoPelaje, string tipoComida)
        {
            TipoPelaje = tipoPelaje;
            TipoComida = tipoComida;
        }
        public string TipoPelaje { get; set; }
        public string TipoComida { get; set; }
        
        Terrestres[] terrestres = new Terrestres[5];

        public void IngresoInformacion()
        {
            terrestres[0] = new Terrestres();
            terrestres[1] = new Terrestres();
            terrestres[2] = new Terrestres();
            terrestres[3] = new Terrestres();
            terrestres[4] = new Terrestres();

            base.IngresoInformacion();

            for (var i = 0; i < terrestres.Length; i++)
            {
                
                Console.WriteLine($"¿Que tipo de pelaje tiene?");
                terrestres[i].TipoPelaje = Console.ReadLine();

                Console.WriteLine($"¿Que clase de comida le daras?");
                terrestres[i].TipoComida = Console.ReadLine();
            }
        }
        public new void Impresion()
        {
            base.Impresion();
            for (int i = 0; i < terrestres.Length; i++)
            {
                Console.WriteLine($"Tipo de pelaje: {terrestres[i].TipoPelaje}, Comida: {terrestres[i].TipoComida}");
            }
        }
    }
}
