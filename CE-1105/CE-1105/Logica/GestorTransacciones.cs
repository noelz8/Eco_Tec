using CE_1105.Interfaz;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica
{
    public class GestorTransacciones
    {
        private string rutaArchivoTransacciones;
        private string rutaArchivoCentros;

        public GestorTransacciones(string rutaArchivoTransacciones, string rutaArchivoCentros)
        {
            this.rutaArchivoTransacciones = rutaArchivoTransacciones;
            this.rutaArchivoCentros = rutaArchivoCentros;
        }

        public List<string> ObtenerCentros()
        {
            var centros = new List<string>();
            var lineas = File.ReadAllLines("Centros.txt");
            foreach (var linea in lineas)
            {
                var partes = linea.Split(',');
                centros.Add(partes[0].Trim());
            }
            return centros;
        }

        public List<ManejoTransaccion> ObtenerTransacciones(string centroAcopio, DateTime fechaInicio, DateTime fechaFin)
        {
            var transacciones = new List<ManejoTransaccion>();
            var lineas = File.ReadAllLines("TransaccionCentro.txt");

            foreach (var linea in lineas)
            {
                var partes = linea.Split(',');

                if (partes.Length < 10) continue;

                var fecha = DateTime.ParseExact(partes[4], "dd/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);

                if (partes[2] == centroAcopio && fecha >= fechaInicio && fecha <= fechaFin)
                {
                    transacciones.Add(new ManejoTransaccion
                    {
                        IdTransaccionCentro = partes[0],
                        IdTransaccionEstudiante = partes[1],
                        CentroAcopio = partes[2],
                        Estado = partes[3],
                        FechaHora = fecha,
                        Material = partes[5].Trim(),
                        Cantidad = int.Parse(partes[6].Trim()),
                        TecColones = int.Parse(partes[7]),

                    });
                }
            }

            return transacciones.OrderByDescending(t => t.FechaHora).ToList();
        }


}
}
