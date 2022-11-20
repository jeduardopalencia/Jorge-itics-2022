using Ejercicio_No._1.Interfaz.IAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Animal
{
    public class Acuatico: Terrestres, IAnimal
    {
        public Acuatico()
        {

        }
        public Acuatico(string tipoRespiratorio, string tipoDeAgua)
        {
            TipoRespiratorio = tipoRespiratorio;
            TipoDeAgua = tipoDeAgua;
        }
        public string TipoRespiratorio { get; set; }
        public string TipoDeAgua { get; set; }

        Acuatico[] acuatico = new Acuatico[5];
        public void IngresoInformacion()
        {
            
            acuatico[0] = new Acuatico();
            acuatico[1] = new Acuatico();
            acuatico[2] = new Acuatico();
            acuatico[3] = new Acuatico();
            acuatico[4] = new Acuatico();

            base.IngresoInformacion();

            for (var i = 0; i < acuatico.Length; i++)
            {
                Console.WriteLine($"Que tipo de sistema respiratorio tiene:");
                acuatico[i].TipoComida = Console.ReadLine();

                Console.WriteLine($"Que tipo de sistema respiratorio tiene:");
                acuatico[i].TipoRespiratorio = Console.ReadLine();

                Console.WriteLine($"¿Para que tipo de agua es:?");
                acuatico[i].TipoDeAgua = Console.ReadLine();
            }
        }

        public void Impresion()
        {
            base.Impresion();
            for (int i = 0; i < acuatico.Length; i++)
            {
                Console.WriteLine($"Comida: {acuatico[i].TipoComida}, Forma de respirar: {acuatico[i].TipoRespiratorio}, Tipo de Agua: {acuatico[i].TipoDeAgua}");
            }
        }
    }
}
