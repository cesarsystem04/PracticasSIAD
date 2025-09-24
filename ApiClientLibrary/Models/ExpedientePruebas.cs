using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Models
{

    /// <summary>
    /// Estructura para almacenar Expediente de pruebas
    /// </summary>
    public class ExpedientePruebas : IBaseDTO
    {
        public string id { get; set; }
        public string claveExpediente { get; set; }
        public string ordenFabricacion { get; set; }
        public string cantidadMuestras { get; set; }
        public string[] maximoRechazos { get; set; }

    }
}
