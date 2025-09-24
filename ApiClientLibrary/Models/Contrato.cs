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
    public class Contrato : IBaseDTO
    {
        public string Tipo { get; set; }
        public string id { get; set; }
        public string tipoContrato { get; set; }
        public string noContrato { get; set; }
        public string estatus { get; set; }
        public List<DetalleContrato> detalleContrato { get; set; }
        public string perdidasGarantizadasVacio { get; set; }
        public string perdidasGarantizadasCarga { get; set; }
        public string urlArchivo { get; set; }
        public string mD5 { get; set; }
        public string fechaEntregaCFE { get; set; }

    }
}
