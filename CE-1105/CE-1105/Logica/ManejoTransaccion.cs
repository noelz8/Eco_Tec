using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_1105.Interfaz;

namespace CE_1105.Logica
{
    public class ManejoTransaccion
    {
        public string IdTransaccionCentro { get; set; }
        public string IdTransaccionEstudiante { get; set; }
        public string CentroAcopio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHora { get; set; }
        public string Material { get; set; }
        public int Cantidad { get; set; }
        public int TecColones { get; set; }

    }
}
