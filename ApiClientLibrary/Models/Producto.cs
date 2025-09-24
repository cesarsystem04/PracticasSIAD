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
    public class Producto : IBaseDTO
    {
        public string id { get; set; }
        public string codigoFabricante { get; set; }
        public string descripcionCorta { get; set; }
        public string tipoFabricacion { get; set; }
        public string unidad { get; set; }
        public string norma { get; set; }
        public string prototipo { get; set; }
        public string estatus { get; set; }
        public string fechaRegistro { get; set; }
        public List<Prueba> pruebas { get; set; }
    }
}
