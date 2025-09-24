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
    public class ValorReferencia : IBaseDTO
    {
        public string id { get; set; }
        public string idProducto { get; set; }
        public string idPrueba { get; set; }
        public int valor { get; set; }
        public int valor2 { get; set; }
        public string unidad { get; set; }
        public string comparacion { get; set; }
        public string fechaRegistro { get; set; }

    }
}
