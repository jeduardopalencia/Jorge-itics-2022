using Ejercicio_No._1.Interfaz.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Area
{
    public class TrianguloIsosceles : TrianguloEscaleno, IAreas
    {
        public TrianguloIsosceles()
        {
        }

        public TrianguloIsosceles(double area, double @base, double altura)
        {
            this.Area = area;
            this.Base = @base;
            this.Altura = altura;
        }

        public double Area { get ; set ; }
        public double Base { get ; set ; }
        public double Altura { get ; set ; }

        public double Operacion(double Base, double Altura)
        {
            return base.Operacion(this.Base, this.Altura);
        }
        public void Impresion()
        {
            base.Impresion();
        }
    }
}
