
using Ejercicio_No._1.Models.Animal;
using Ejercicio_No._1.Models.Area;
using Ejercicio_No._1.Models.Aulas;
using Ejercicio_No._1.Models.Persona;
using Ejercicio_No._1.Models.Series;
using System.Collections.Generic;

int op = 0;

//Arrays
Terrestres terrestres1 = new Terrestres();
Terrestres[] terrestres = new Terrestres[5];
terrestres[0] = terrestres1;
terrestres[1] = terrestres1;
terrestres[2] = terrestres1;
terrestres[3] = terrestres1;
terrestres[4] = terrestres1;

Acuatico acuatico1 = new Acuatico();
Acuatico[] acuatico = new Acuatico[5];
acuatico[0] = acuatico1;
acuatico[1] = acuatico1;
acuatico[2] = acuatico1;
acuatico[3] = acuatico1;
acuatico[4] = acuatico1;

Volador volador1 = new Volador();
Volador[] volador = new Volador[5];
volador[0] = volador1;
volador[1] = volador1;
volador[2] = volador1;
volador[3] = volador1;
volador[4] = volador1;

Animal animal1 = new Animal();
Animal[] animal = new Animal[5]; 
animal[0] = animal1;
animal[1] = animal1;
animal[2] = animal1;
animal[3] = animal1;
animal[4] = animal1;

//Listas
List<Estudiante> estudiante = new List<Estudiante>();
Estudiante estudiante1 = new Estudiante();
estudiante.Add(estudiante1);

List<Profesor> profesor = new List<Profesor>();
Profesor profesor1 = new Profesor();
profesor.Add(profesor1);

List<Director> director = new List<Director>();
Director director1 = new Director();
director.Add(director1);

List<Aula> aula = new List<Aula>();
Aula aula1 = new Aula();
aula.Add(aula1);

Nota notas1 = new Nota();
Nota[] notas = new Nota[4];
notas[0] = notas1;
notas[1] = notas1;
notas[2] = notas1;
notas[3] = notas1;

Serie series = new Serie();

Aula aula7 = new Aula()
{
    Grado = "Primero Basico",
    Materia = "Matematicas",
    TotalAlumnos = 10,
};
aula.Add(aula7);

Aula aula8 = new Aula()
{
    Grado = "Segundo Basico",
    Materia = "Programación",
    TotalAlumnos = 20,
};
aula.Add(aula8);

Aula aula2 = new Aula()
{
    IdAlumno = 1,
    Nombre = "Mishell Díaz",
    Genero = "Femenina",
    Edad = 17,
    Grado = "Tercero Basico",
    Notas = 100
};
aula.Add(aula2);

Aula aula3 = new Aula()
{
    IdAlumno = 2,
    Nombre = "Melissa Ovalle",
    Genero = "Femenina",
    Edad = 17,
    Grado = "Tercero Basico",
    Notas = 95
};
aula.Add(aula3);

Aula aula4 = new Aula()
{
    IdAlumno = 3,
    Nombre = "Jorge Palencia",
    Genero = "Masculino",
    Edad = 16,
    Grado = "Segundo Basico",
    Notas = 80
};
aula.Add(aula4);

Aula aula5 = new Aula()
{
    IdAlumno = 4,
    Nombre = "Michael Reyes",
    Genero = "Masculino",
    Edad = 15,
    Grado = "Primero Basico",
    Notas = 80
};
aula.Add(aula5);

Aula aula6 = new Aula()
{
    IdAlumno = 5,
    Nombre = "Oscar Orante",
    Genero = "Masculino",
    Edad = 15,
    Grado = "Primero Basico",

};
aula.Add(aula6);

//Declaracion de clases
TrianguloEscaleno trianguloesca1 = new TrianguloEscaleno();
TrianguloIsosceles trianguloiso1 = new TrianguloIsosceles();
Rectangulo rectangulo1 = new Rectangulo();

//Menu principal
do
{
    Console.WriteLine("Bienvenido! Elige el ejercicio al cual deseas ingresar:");
    Console.WriteLine("1. Ingresar tipos de animales.");
    Console.WriteLine("2. Ingresa información de estudiantes, profesores y directores.");
    Console.WriteLine("3. Operaciones de areas.");
    Console.WriteLine("4. Objetos tipo aula.");
    Console.WriteLine("5. Series.");
    Console.WriteLine("6. Salir");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            MenuAnimales();
            break;
        case 2:
            MenuPersona();
            break;
        case 3:
            MenuAreas();
            break;
        case 4:
            MenuAula();
            break;
        case 5:
            MenuSeries();
            break;
    }

} while (op < 6);

void MenuSeries()
{
    int op = 0;
    do
    {
        Console.WriteLine("Elige la opción a utilizar:");
        Console.WriteLine("1. Crear la serie.");
        Console.WriteLine("2. Buscar las series que quieras.");
        Console.WriteLine("3. Regresar a menú anterior.");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                series.IngresarSerie();
                break;
            case 2:
                series.BuscarSerie();
                break;
        }

    } while (op < 3);
}


void MenuAula()
{
    int op = 0;
    do
    {
        Console.WriteLine("Elige la opción a utilizar:");
        Console.WriteLine("1. Crear datos de aulas.");
        Console.WriteLine("2. Crear datos de estudiantes.");
        Console.WriteLine("3. Mostrar datos.");
        Console.WriteLine("4. Regresar a menú anterior.");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                aula1.DatosAula();
                break;
            case 2:
                aula1.Estudiante();
                break;
            case 3:
                foreach(var estu in aula)
                {
                    Console.WriteLine($"Clave del alumno: {estu.IdAlumno}, nombre del estudiante: {estu.Nombre}, Edad: {estu.Edad}, Genero: {estu.Genero}");

                }
                foreach(var au in aula)
                {
                    Console.WriteLine($"Grado: {au.Grado}, Materia: {au.Materia}, Total alumnos: {au.TotalAlumnos}");
                }
                break;
        }

    }while (op < 4);
}

void MenuAreas()
{
    int op = 0;
    do
    {
        Console.WriteLine("Elige el area:");
        Console.WriteLine("1. Triangulo escaleno.");
        Console.WriteLine("2. Triangulo isosceles.");
        Console.WriteLine("3. Rectangulo.");
        Console.WriteLine("4 Regresar al menu anterior.");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                trianguloesca1.Operacion(trianguloesca1.Base, trianguloesca1.Altura);
                trianguloesca1.Impresion();
                break;
            case 2:
                trianguloiso1.Operacion(trianguloiso1.Base, trianguloiso1.Altura);
                trianguloiso1.Impresion();
                break;
            case 3:
                rectangulo1.Operacion(rectangulo1.Base, rectangulo1.Altura);
                rectangulo1.Impresion();
                break;
        }

    }while (op < 4);
}

void MenuPersona()
{
    int op = 0;
    do
    {
        Console.WriteLine("Crea los siguiente perfiles:");
        Console.WriteLine("1. Estudiante.");
        Console.WriteLine("2. Profesor.");
        Console.WriteLine("3. Director.");
        Console.WriteLine("4. Regresar al menú anterior.");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                estudiante1.IngresoInfo();
                estudiante1.Impresion();
                break;
            case 2:
                profesor1.IngresoInfo();
                profesor1.Impresion();
                break;
            case 3:
                director1.IngresoInfo();
                director1.Impresion();
                break;
        }

    } while (op < 4);
}

void MenuAnimales()
{
    int o = 0;
    do
    {
        Console.WriteLine("Elige al animalito a registrar:");
        Console.WriteLine("1. Terrestre.");
        Console.WriteLine("2. Acuatico.");
        Console.WriteLine("3. Volador.");
        Console.WriteLine("4. Salir");
        o = Convert.ToInt32(Console.ReadLine());

        switch (o)
        {
            case 1:
                terrestres1.IngresoInformacion();
                terrestres1.Impresion();
                break;
            case 2:
                acuatico1.IngresoInformacion();
                acuatico1.Impresion();
                break;
            case 3:
                volador1.IngresoInformacion();
                volador1.Impresion();
                break;
        }

    } while (o < 4);
}