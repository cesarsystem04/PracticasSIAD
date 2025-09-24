
using ApiClientLibrary.Services;
using ApiClientLibrary.Models;



#region Practica_1

F1_ConfiguracionInicial f1_ConfiguracionInicial = new F1_ConfiguracionInicial();

Task<HttpResponseMessage> estadoSid =  f1_ConfiguracionInicial.RegistrarEstadoSID(new EstadoSIDDTO
{
    Estado = "EN_ESPERA"
});


if (!estadoSid.Result.IsSuccessStatusCode)
    Console.WriteLine($"ERROR:  {estadoSid.Result.Content.ReadAsStringAsync().Result ?? string.Empty}");

else {

    var resultado = estadoSid.Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine($"El resultado es OK: { resultado} ");
}
    



Console.WriteLine($"Fin de la ejecución del programa");

#endregion


#region Practica_2
F1_ConfiguracionInicial f1_Conf_ini_intrumentos = new F1_ConfiguracionInicial();


Task<HttpResponseMessage> estado_f1_conf_ini_instrumentos = f1_ConfiguracionInicial.RegistrarEstadoSID(new EstadoSIDDTO
{
    Estado = "EN_ESPERA"
});




#endregion