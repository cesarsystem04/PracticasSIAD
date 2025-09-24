using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Models
{

    /// <summary>
    /// Estructura para almacenar Pruebas
    /// </summary>
    public class Prueba : IBaseDTO
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string estatus { get; set; }
        public string tipoPrueba { get; set; }
        public string tipoResultado { get; set; }
        public string fechaRegistro { get; set; }

    }
}
