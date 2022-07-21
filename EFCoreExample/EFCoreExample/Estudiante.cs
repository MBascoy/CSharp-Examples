namespace EFCoreExample
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Asignatura> Asignatura { get; set; }
    }
}
