using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Models
{
    /// <summary>
    /// Estructura para almacenar los Intrumentos
    /// </summary>
    public class Instrumento : IBaseDTO
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string numeroSerie { get; set; }
        public string fechaCalibracion { get; set; }
        public string fechaVencimientoCalibracion { get; set; }
        public string urlArchivo { get; set; }
        public string mD5 { get; set; }
        public string estatus { get; set; }
        public string fechaRegistro { get; set; }

    }
}
