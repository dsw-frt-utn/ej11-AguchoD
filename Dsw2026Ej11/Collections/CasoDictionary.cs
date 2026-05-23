namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections.Generic;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        if (!alumnos.ContainsKey(alumno.Id))
        {
            alumnos.Add(alumno.Id, alumno);
        }
    }

    public Alumno BuscarAlumno(int id)
    {
        if (!alumnos.TryGetValue(id, out Alumno alumno))
        {
            return alumno;
        }
    }

    public Dictionary<int, Alumno> MostrarAlumnos()
    {
        return alumnos;
    }

    public Alumno EliminarAlumno(int id)
    {
        alumnos.Remove(id);
    }
}
