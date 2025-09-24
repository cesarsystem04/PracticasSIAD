using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Models
{

    /// <summary>
    /// Estructura para almacenar Valores de referencias
    /// </summary>
    public class OrdenFabricacion : IBaseDTO
    {
        public string id { get; set; }
        public string claveOrdenFabricacion { get; set; }
        public string loteFabricacion { get; set; }
        public string idProducto { get; set; }
        public List<DetalleFabricacion> detalleFabricacion { get; set; }

    }
}
