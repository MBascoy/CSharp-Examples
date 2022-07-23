using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using Newtonsoft.Json;
using FileExample;

string dir = Combine(GetFolderPath(SpecialFolder.UserProfile), "PruebaArchivo");
CreateDirectory(dir);

string archivo = Combine(dir, "persona.json");

Persona persona = new Persona();

List<Persona> lista = new List<Persona>()
{
    new Persona()
    {
        nombre = "Pepe",
        edad = 45
    },
    new Persona()
    {
        nombre = "Mercedes",
        edad = 56
    }
};

/**** SERIALIZAR *****/

using (StreamWriter escritor = File.CreateText(archivo))
{
    JsonSerializer serializador = new JsonSerializer();

    serializador.Serialize(escritor, lista);
}


/**** DESERIALIZAR *****/

string data = File.ReadAllText(archivo);

List<Persona> nuevaLista = JsonConvert.DeserializeObject<List<Persona>>(data);

Console.WriteLine(nuevaLista[1].nombre);