using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Models
{

    /// <summary>
    /// Estructura para almacenar prototipos
    /// </summary>
    public class Prototipo : IBaseDTO
    {
        public string id { get; set; }
        public string numero { get; set; }
        public string fechaEmision { get; set; }
        public string fechaVencimiento { get; set; }
        public string urlArchivo { get; set; }
        public string mD5 { get; set; }
        public string estatus { get; set; }
        public string fechaRegistro { get; set; }

    }
}
