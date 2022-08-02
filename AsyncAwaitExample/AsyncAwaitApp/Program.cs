
 
public class Program
{
    public static async Task Main(String[] args)
    {
        Console.WriteLine("Inicio");
        Task procesoA = LanzarProcesoA();
        Task procesoB = LanzarProcesoB();

        await procesoA;
        await procesoB;
        Console.WriteLine("terminado");
    }

    private static async Task LanzarProcesoA()
    {
        Console.WriteLine("ProcesoA iniciando");
        await Task.Delay(5000);
        Console.WriteLine("ProcesoA terminado");

    }

    private static async Task LanzarProcesoB()
    {
        Console.WriteLine("ProcesoB iniciando");
        await Task.Delay(5500);
        Console.WriteLine("ProcesoB terminado");
    }
}