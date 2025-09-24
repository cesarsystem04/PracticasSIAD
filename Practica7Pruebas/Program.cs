
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
        Console.WriteLine("1. Registrar Prueba");
        Console.WriteLine("2. Listar Pruebas");
        Console.WriteLine("3. Actualizar Prueba");
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
        PruebasServices services = new PruebasServices();
        Task<HttpResponseMessage> result = services.Guardar(new Prueba
        {
            id = "",
            nombre = "Resistencia eléctrica del conductor",
            estatus = "ACTIVA",
            tipoPrueba = "ACEPTACION",
            tipoResultado = "VALOR_REFERENCIA",
            fechaRegistro = "2025-09-23T18:58:08.750Z"
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
        PruebasServices services = new PruebasServices();
        Task<HttpResponseMessage> result = services.Actualizar(new Prueba
        {
            id = "",
            nombre = "Resistencia eléctrica del conductor",
            estatus = "ACTIVA",
            tipoPrueba = "ACEPTACION",
            tipoResultado = "VALOR_REFERENCIA",
            fechaRegistro = "2025-09-23T18:58:08.750Z"
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
        PruebasServices services = new PruebasServices();
        Task<HttpResponseMessage> result = services.Leer();
        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

        else
        {

            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }

}