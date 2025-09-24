
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
        Console.WriteLine("1. Registrar Contrato");
        Console.WriteLine("2. Listar Contratos");
        Console.WriteLine("3. Actualizar Contrato");
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
        ContratoServices services = new ContratoServices();
        Task<HttpResponseMessage> result = services.Guardar(new Contrato
        {

            Tipo = "ContratoCFE",
            id = "",
            tipoContrato = "ContratoCFE",
            noContrato = "68d30229ce3b00aacea97245",
            estatus = "ACTIVO",
            detalleContrato = new List<DetalleContrato>()
  {
        new DetalleContrato
        {
            partidaContrato = "1",
            descripcionAviso = "Transformador",
            areaDestinoCFE = "CFE",
            cantidad = 10000,
            unidad= "PIEZA",
            importeTotal= 100000
        },

            new DetalleContrato
        {
            partidaContrato = "2",
            descripcionAviso = "Transformador",
            areaDestinoCFE = "CFE",
            cantidad = 50000,
            unidad= "PIEZA",
            importeTotal= 50000
        },
  },

            perdidasGarantizadasVacio = 2131.90,
            perdidasGarantizadasCarga = 23.90,
            urlArchivo = "https://www.cfe.mx",
            mD5 = "",
            fechaEntregaCFE = "2025-07-18T17:25:06.51Z"
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
        ContratoServices services = new ContratoServices();
        Task<HttpResponseMessage> result = services.Actualizar(new Contrato
        {

            Tipo = "ContratoCFE",
            id = "",
            tipoContrato = "ContratoCFE",
            noContrato = "68d30229ce3b00aacea97245",
            estatus = "ACTIVO",
            detalleContrato = new List<DetalleContrato>()
  {
        new DetalleContrato
        {
            partidaContrato = "1",
            descripcionAviso = "Transformador",
            areaDestinoCFE = "CFE",
            cantidad = 10000,
            unidad= "PIEZA",
            importeTotal= 100000
        },

            new DetalleContrato
        {
            partidaContrato = "2",
            descripcionAviso = "Transformador",
            areaDestinoCFE = "CFE",
            cantidad = 50000,
            unidad= "PIEZA",
            importeTotal= 50000
        },
  },

            perdidasGarantizadasVacio = 2131.90,
            perdidasGarantizadasCarga = 23.90,
            urlArchivo = "https://www.cfe.mx",
            mD5 = "",
            fechaEntregaCFE = "2025-07-18T17:25:06.51Z"
        });

    }


    public static void Listar()
    {
        ContratoServices services = new ContratoServices();
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