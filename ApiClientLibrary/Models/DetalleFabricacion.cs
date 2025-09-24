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
    public class DetalleFabricacion : IBaseDTO
    {
        public string contratoId { get; set; }
        public string tipoContrato { get; set; }
        public string partidaContratoId { get; set; }
        public string descripcionPartida { get; set; }
        public string unidad { get; set; }
        public string cantidadOriginalContrato { get; set; }
        public string cantidadAFabricar { get; set; }

    }
}
