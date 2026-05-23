using System.Collections;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections.Generic;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList listita = new CasoList();
        
        Alumno a1 = new Alumno(1, "Matias Molina");
        Alumno a2 = new Alumno(2, "Mateo Gomez");
        Alumno a3 = new Alumno(3, "Jose Ruiz");
        listita.AgregarAlumno(a1);
        listita.AgregarAlumno(a2);
        listita.AgregarAlumno(a3);

        Console.WriteLine("Alumnos de la lista: ");
        foreach (var al in listita.BuscarAlumno())
        {
            Console.WriteLine(al.ToString());
        }

        Console.WriteLine("--- Buscando a 'Matias' ---");
        Alumno? alumnoExiste = manejadorList.BuscarAlumno("Matias");
        if (alumnoExiste != null)
        {
            Console.WriteLine($"Encontrado: {alumnoExiste.Nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();


        Console.WriteLine("--- Buscando a 'Juan' ---");
        Alumno? alumnoNoExiste = manejadorList.BuscarAlumno("Juan");
        if (alumnoNoExiste != null)
        {
            Console.WriteLine($"Encontrado: {alumnoNoExiste.Nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();

        Console.WriteLine("--- Eliminando a 'Jose' ---");
        Alumno? alumnoAEliminar = manejadorList.BuscarAlumno("Jose");
        if (alumnoAEliminar != null)
        {
            manejadorList.EliminarAlumnoSelect(alumnoAEliminar);
        }
        ListarAlumnosDeLista(manejadorList.MostrarAlumnos());

        Console.WriteLine("--- Eliminando el primer elemento (Índice 0) ---");
        if (manejadorList.MostrarAlumnos().Count > 0)
        {
            manejadorList.EliminarAlumnoIndice(0);
        }
        ListarAlumnosDeLista(manejadorList.MostrarAlumnos());

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Dictionary<string, Alumno> diccionarioAlumnos = new Dictionary<string, Alumno>();

        manejadorDict.AgregarAlumno(new Alumno { Id = 10, Nombre = "Roberto" });
        manejadorDict.AgregarAlumno(new Alumno { Id = 20, Nombre = "Lucia" });
        manejadorDict.AgregarAlumno(new Alumno { Id = 30, Nombre = "Diego" });


        Console.WriteLine("Alumnos en el Diccionario: ");
        ListarDiccionario(manejadorDict.MostrarAlumnos());


        int claveExiste = 20;
        var dictActual = manejadorDict.MostrarAlumnos();
        if (dictActual.ContainsKey(claveExiste))
        {
            Console.WriteLine($"Clave: {claveExiste} -> Alumno: {dictActual[claveExiste].Nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();


        int claveNoExiste = 99;
        if (dictActual.ContainsKey(claveNoExiste))
        {
            Console.WriteLine($"Clave: {claveNoExiste} -> Alumno: {dictActual[claveNoExiste].Nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();


        Console.WriteLine("Eliminando clave 10");
        manejadorDict.EliminarAlumno(10);
        ListarDiccionario(manejadorDict.MostrarAlumnos());

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq manejadorLinq = new CasoLinq();

        Console.WriteLine($"Total de precios de los libros: {manejadorLinq.GetTotalPrecios():C}");

        Console.WriteLine($"Promedio de precios: {manejadorLinq.GetPromedioPrecios():C}");


    }

    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; };
    }

    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; };
        public decimal Precio { get; set; }
    }
}
