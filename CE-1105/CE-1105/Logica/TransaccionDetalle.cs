using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica
{
    // Clase que representa los detalles de una transacción para mostrarlos en el DataGrid
    public class TransaccionDetalle
    {
        public string IdTransaccionCentro { get; set; }
        public string CentroAcopio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHora { get; set; }
        public string Materiales { get; set; }
    }

}
