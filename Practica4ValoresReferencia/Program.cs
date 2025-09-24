
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
        Console.WriteLine("1. Registrar Valores referencia");
        Console.WriteLine("2. Listar Valores referencia");
        Console.WriteLine("3. Actualizar Valores referencia");
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
        ValoresReferenciaServices serviceVR = new ValoresReferenciaServices();
        Task<HttpResponseMessage> result = serviceVR.Guardar(new ValorReferencia
        {
            id = "",
            idProducto = "68d2f083ce3b00aacea97216",
            idPrueba = "68d2eebace3b00aacea97202",
            valor = 10,
            valor2 = 0,
            unidad = "ohm/kg",
            comparacion = "VALOR_MINIMO",
            fechaRegistro = "2025-09-23T19:11:13.112Z"
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
        ValoresReferenciaServices serviceVR = new ValoresReferenciaServices();
        Task<HttpResponseMessage> result = serviceVR.Actualizar(new ValorReferencia
        {
            id = "",
            idProducto = "68d2f083ce3b00aacea97216",
            idPrueba = "68d2eebace3b00aacea97202",
            valor = 10,
            valor2 = 0,
            unidad = "ohm/kg",
            comparacion = "VALOR_MINIMO",
            fechaRegistro = "2025-09-23T19:11:13.112Z"
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
        ValoresReferenciaServices serviceVR = new ValoresReferenciaServices();
        Task<HttpResponseMessage> result = serviceVR.Leer();
        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

        else
        {

            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }

}