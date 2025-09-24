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
    public class DetalleContrato : IBaseDTO
    {
        public string partidaContrato { get; set; }
        public string descripcionAviso { get; set; }
        public string areaDestinoCFE { get; set; }
        public string cantidad { get; set; }
        public string unidad { get; set; }
        public string importeTotal { get; set; }


    }
}
