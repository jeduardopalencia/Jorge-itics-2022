using Ejercicio_No._1.Interfaz.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Area
{
    public class Areas : IAreas
    {
        public Areas()
        {
        }

        public Areas(double area, double @base, double altura)
        {
            this.Area = area;
            this.Base = @base;
            this.Altura = altura;
        }

        public double Area { get; set; }
        public double Base { get; set ; }
        public double Altura { get; set ; }

        public double Operacion(double Base, double Altura)
        {
            Console.WriteLine("Ingresa la base:");
            this.Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la altura:");
            this.Altura = Convert.ToDouble(Console.ReadLine());

            this.Area = this.Base * this.Altura;
            return this.Area;
        }
        public void Impresion()
        {
            Console.WriteLine($"Su base: {this.Base}, altura: {this.Altura} y su area: {this.Area}");
        }
    }
}
