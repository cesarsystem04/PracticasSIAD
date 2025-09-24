// See https://aka.ms/new-console-template for more information

using ApiClientLibrary.Models;
using ApiClientLibrary.Services;

//F1_Instrumento servicesInstumento = new F1_Instrumento();


bool continuar = true;
while (continuar) 
{
    MostrarMenu();
    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine();

    continuar = EjecutarOpcion(opcion);


}



static void MostrarMenu()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n--- Menú de Opciones ---");
    Console.Clear();
    Console.WriteLine("1. Registrar Intrumento");
    Console.WriteLine("2. Listar Instrumento");
    Console.WriteLine("3. Salir");
}


 static bool EjecutarOpcion(string opcion)
{
    switch (opcion)
    {
        case "1":
            Agregar();
            break;
        case "2":
            Listar();
            break;
        case "3":
            Console.WriteLine("Saliendo del programa...");
            return false;
        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            break;
    }
    return true;

}

static void Agregar() 
{

    F1_Instrumento servicesInstumento = new F1_Instrumento();
    Task<HttpResponseMessage> estado_f1_conf_ini_instrumentos = servicesInstumento.RegistrarInstrumento(new Instrumento
    {
        id = "",
        nombre = "Balanza electrónica de precisión 2",
        numeroSerie = "12345678",
        fechaCalibracion = "2025-09-23T18:08:42.749Z",
        fechaVencimientoCalibracion = "2026-09-23T18:08:42.749Z",
        urlArchivo = "http://repos.com/Certificado-CEM.pdf",
        mD5 = "",
        estatus = "Activo",
        fechaRegistro = "2025-09-23T18:08:42.749Z"
    });

    if (!estado_f1_conf_ini_instrumentos.Result.IsSuccessStatusCode)
        Console.WriteLine($"ERROR:  {estado_f1_conf_ini_instrumentos.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

    else
    {

        var resultado = estado_f1_conf_ini_instrumentos.Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine($"El resultado es OK: {resultado} ");
    }

}

static void Listar() 
{


    // Leer Instrumento 
    F1_Instrumento servicesInstumento = new F1_Instrumento();
    Task<HttpResponseMessage> leer_instrumento = servicesInstumento.LeerInstrumento();
    if (!leer_instrumento.Result.IsSuccessStatusCode)
        Console.WriteLine($"ERROR:  {leer_instrumento.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

    else
    {

        var resultado = leer_instrumento.Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine($"El resultado es OK: {resultado} ");
    }

}


