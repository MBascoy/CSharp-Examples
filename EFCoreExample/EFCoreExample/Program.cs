using EFCoreExample;
using Microsoft.EntityFrameworkCore;

using (ColegioContext db = new())
{
    IQueryable<Estudiante>? estudiantes = db.Estudiantes?.Include(e => e.Asignatura);

    foreach (Estudiante e in estudiantes)
    {
        Console.WriteLine(e.Nombre);
        Console.WriteLine("Asignaturas:");

        foreach (Asignatura item in e.Asignatura)
        {
            Console.WriteLine("\t" + item.Nombre);

        }
    }
}