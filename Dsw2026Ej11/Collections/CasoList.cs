using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumnos(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> MostrarAlumnos()
    {
        return alumnos;
    }

    public Alumno? BuscarAlumno(string nombre)
    {
        foreach (var al in alumnos)
        {
            if (al != null && al.Nombre.Equals(nombre)) return al; 
        }
        return null;
    }

    public void EliminarAlumnoSelect(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    public void EliminarAlumnoIndice(int posicion)
    {
        alumnos.RemoveAt(posicion);
    }

}
