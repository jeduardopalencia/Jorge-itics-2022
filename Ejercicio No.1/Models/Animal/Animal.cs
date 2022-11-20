using Ejercicio_No._1.Interfaz.IAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_No._1.Models.Animal
{
    public class Animal: IAnimal
    {
        public Animal()
        {

        }
        public Animal(string nombre, string genero, double peso)
        {
            Nombre = nombre;
            Genero = genero;
            Peso = peso;
        }

        public string Nombre { get; set; }
        public string Genero { get; set; }
        public double Peso { get; set; }

        Animal[] animal = new Animal[5];
        public void IngresoInformacion()
        {
            animal[0] = new Animal();
            animal[1] = new Animal();
            animal[2] = new Animal();
            animal[3] = new Animal();
            animal[4] = new Animal();

            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine($"Ingresa el nombre del animal:");
                animal[i].Nombre = Console.ReadLine();

                Console.WriteLine($"Ingresa el genero:");
                animal[i].Genero = Console.ReadLine();

                Console.WriteLine($"Ingresa el peso:");
                animal[i].Peso = Convert.ToDouble(Console.ReadLine());

            }
        }
        public void Impresion()
        {
            for(int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine($"Nombre: {animal[i].Nombre}, Genero: {animal[i].Genero}, Pesa: {animal[i].Peso}");
            }
        }
    }
}
