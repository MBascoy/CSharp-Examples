using SerializationExample;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace DemoApplication
{
    class AppSerializacion
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.edad = 24;
            persona.nombre = "Richard";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, persona);
            stream.Close();
            persona.escribir();
            stream = new FileStream(@"ExampleNew.txt", FileMode.Open, FileAccess.Read);
            Persona nuevaPersona = formatter.Deserialize(stream) as Persona;

            Console.WriteLine(nuevaPersona.edad);
            Console.WriteLine(nuevaPersona.nombre);
        }
    }
}