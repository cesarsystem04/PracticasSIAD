
using ApiClientLibrary.Models;
using ApiClientLibrary.Services;

public class Program
{

    public static void Main(string[] args)
    {

        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            continuar = EjecutarOpcion(opcion);


        }

    }

    public static void MostrarMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Menú de Opciones ---");
        Console.Clear();
        Console.WriteLine("1. Registrar Orden Fabricacion");
        Console.WriteLine("2. Listar Ordenes Fabricacion");
        Console.WriteLine("3. Actualizar Orden Fabricacion");
        Console.WriteLine("4. Salir");
    }


    public static bool EjecutarOpcion(string opcion)
    {
        switch (opcion)
        {
            case "1":
                Agregar();
                Console.ReadLine();
                break;
            case "2":
                Listar();
                Console.ReadLine();
                break;
            case "3":
                Actualizar();
                Console.ReadLine();
                break;
            case "4":
                Console.WriteLine("Saliendo del programa...");
                return false;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
        return true;

    }



    public static void Agregar()
    {
        OrdenFabricacionServices services = new OrdenFabricacionServices();
        Task<HttpResponseMessage> result = services.Guardar(new OrdenFabricacion
        {
            id = "",
            claveOrdenFabricacion = "OF2025",
            loteFabricacion = "LT2025",
            idProducto = "68d2f083ce3b00aacea97216",
            detalleFabricacion = new List<DetalleFabricacion>()
  {
      new DetalleFabricacion() {
      contratoId = "68d30229ce3b00aacea97245",
       tipoContrato = "ContratoCFE",
       partidaContratoId = "1",
       descripcionPartida = "Transformador",
       unidad = "pz",
       cantidadOriginalContrato = 10000,
       cantidadAFabricar = 300000
        }
  }
        });

        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

        else
        {

            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }


    public static void Actualizar()
    {
        OrdenFabricacionServices services = new OrdenFabricacionServices();
        Task<HttpResponseMessage> result = services.Guardar(new OrdenFabricacion
        {
            id = "",
            claveOrdenFabricacion = "OF2025",
            loteFabricacion = "LT2025",
            idProducto = "68d2f083ce3b00aacea97216",
            detalleFabricacion = new List<DetalleFabricacion>()
  {
      new DetalleFabricacion() {
      contratoId = "68d30229ce3b00aacea97245",
       tipoContrato = "ContratoCFE",
       partidaContratoId = "1",
       descripcionPartida = "Transformador",
       unidad = "pz",
       cantidadOriginalContrato = 10000,
       cantidadAFabricar = 300000
        }
  }
        });

    }


    public static void Listar()
    {
        OrdenFabricacionServices services = new OrdenFabricacionServices();
        Task<HttpResponseMessage> result = services.Leer("68d3078dce3b00aacea9726f");
        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");
        else
        {
            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }

}