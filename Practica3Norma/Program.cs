
using ApiClientLibrary.Models;
using ApiClientLibrary.Services;

public class Program 
{

    public static void Main(string[] args ) 
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
        Console.WriteLine("1. Registrar Norma");
        Console.WriteLine("2. Listar Norma");
        Console.WriteLine("3. Actualizar Norma");
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
        NormaServices serviceNorma = new NormaServices();
        Task<HttpResponseMessage> result = serviceNorma.Guardar(new Norma
        {
              id = "",
              clave = "E0000-09",
              nombre =  "Conductores múltiples para distribución.",
              edicion = "2001",
              estatus = "Activo",
              esCFE =  true,
              fechaRegistro = "2025-09-23T18:49:11.700Z",
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
        NormaServices serviceNorma = new NormaServices();
        Task<HttpResponseMessage> result = serviceNorma.Actualizar(new Norma
        {
            id = "68d2ec40ce3b00aacea971ef",
            clave = "E0000-09",
            nombre = "Conductores múltiples para distribución.",
            edicion = "2001",
            estatus = "Activo",
            esCFE = true,
            fechaRegistro = "2025-09-23T18:49:11.700Z",
        });

        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

        else
        {

            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }


    public static void Listar()
    {
        // Leer Norma
        NormaServices serviceNorma = new NormaServices();
        Task<HttpResponseMessage> result = serviceNorma.Leer();
        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

        else
        {

            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }

}