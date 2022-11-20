using Ejercicio_No._1.Interfaz.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Persona
{
    public class Persona: IPersona
    {
        public Persona()
        {

        }

        public Persona(int dPI, string nombre, string apellido, string direccion, int celular, int telefonoCasa)
        {
            DPI = dPI;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Celular = celular;
            TelefonoCasa = telefonoCasa;
        }

        public int DPI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Celular { get; set; }
        public int TelefonoCasa { get; set; }
       
        public void Impresion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Dirección: {Direccion}, Celular: {Celular}, Telefono de casa: {TelefonoCasa}");
        }

        public void IngresoInfo()
        {
            Console.WriteLine("Ingresa el DPI:");
            DPI =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el nombre:");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido:");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingresa la dirección:");
            Direccion = Console.ReadLine();

            Console.WriteLine("Ingresa el celular:");
            Celular = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el número de casa:");
            TelefonoCasa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
