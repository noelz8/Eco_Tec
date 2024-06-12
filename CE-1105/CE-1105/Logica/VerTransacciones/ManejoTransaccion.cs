using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_1105.Interfaz;

namespace CE_1105.Logica.VerTransacciones
{
    // Clase que representa una transacción
    public class ManejoTransaccion
    {
        public string IdTransaccionCentro { get; set; }
        public string CentroAcopio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHora { get; set; }
        public List<GridMateriales> Materiales { get; set; } = new List<GridMateriales>();


    }
}
