
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
        Console.WriteLine("1. Registrar Producto");
        Console.WriteLine("2. Listar Productos");
        Console.WriteLine("3. Actualizar Producto");
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
        ProductoServices serviceProducto = new ProductoServices();
        Task<HttpResponseMessage> result = serviceProducto.Guardar(new Producto
        {
            id = "",
            codigoFabricante = "1010",
            descripcion = "Producto TWD",
            descripcionCorta = "ACSR 3/0",
            tipoFabricacion = "LOTE",
            unidad = "kg",
            norma = "68d2ec40ce3b00aacea971ef",
            prototipo = "68d2eb17ce3b00aacea971ea",
            estatus = "ACTIVO",
            fechaRegistro = "2025-09-23T19:03:41.949Z",
            pruebas = new List<Prueba>
                {
                    new Prueba {
                        id = "68d2eebace3b00aacea97202"
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
        ProductoServices serviceProducto = new ProductoServices();
        Task<HttpResponseMessage> result = serviceProducto.Actualizar(new Producto
        {
            id = "",
            codigoFabricante = "1010",
            descripcion = "Producto TWD",
            descripcionCorta = "ACSR 3/0",
            tipoFabricacion = "LOTE",
            unidad = "kg",
            norma = "68d2ec40ce3b00aacea971ef",
            prototipo = "68d2eb17ce3b00aacea971ea",
            estatus = "ACTIVO",
            fechaRegistro = "2025-09-23T19:03:41.949Z",
            pruebas = new List<Prueba>
                {
                    new Prueba {
                        id = "68d2eebace3b00aacea97202"
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


    public static void Listar()
    {
        ProductoServices serviceProducto = new ProductoServices();
        Task<HttpResponseMessage> result = serviceProducto.Leer();
        if (!result.Result.IsSuccessStatusCode)
            Console.WriteLine($"ERROR:  {result.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

        else
        {

            var resultado = result.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"El resultado es OK: {resultado} ");
        }

    }

}