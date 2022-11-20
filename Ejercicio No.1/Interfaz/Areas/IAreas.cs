using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Interfaz.Areas
{
    public interface IAreas
    {
        public double Area { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Operacion( double Altura, double Base);
        public void Impresion();
    }
}
