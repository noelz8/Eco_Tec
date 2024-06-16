using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_1105.Interfaz;
using CE_1105.Logica.General;


namespace CE_1105.Logica.VerTransacciones
{
    public class GestorGlobal
    {

        private string rutaArchivoTransacciones;
        public GestorGlobal()
        {
            rutaArchivoTransacciones = Constantes.RutaArchivoTransacciones;
        }

        public List<TransaccionCentro> ObtenerTransacciones(DateTime fechaInicio, DateTime fechaFin)
        {
            var transacciones = new List<TransaccionCentro>();
            var lineas = File.ReadAllLines(rutaArchivoTransacciones);

            foreach (var linea in lineas)
            {
                var partes = linea.Split(',');

                if (partes.Length < 8) continue;

                DateTime fecha;
                try
                {
                    fecha = DateTime.ParseExact(partes[4], "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                }
                catch (FormatException ex)
                {
                    // Loggear la excepción o manejarla según sea necesario
                    Console.WriteLine($"Error al parsear la fecha: {partes[4]} - {ex.Message}");
                    continue; // Saltar a la siguiente línea si hay un error de formato
                }

                // Filtrar por rango de fechas o misma fecha
                if ((fecha >= fechaInicio && fecha <= fechaFin)||(fechaInicio.Date == fechaFin.Date && fecha.Date == fechaInicio.Date))
                {
                    var materialesBuilder = new StringBuilder();
                    for (int i = 5; i < partes.Length; i += 3)
                    {
                        if (i + 2 < partes.Length)
                        {
                            materialesBuilder.AppendLine($"{partes[i].Trim()}: {partes[i + 1].Trim()} unidades, {partes[i + 2].Trim()} TecColones");
                        }
                    }

                    var transaccion = new TransaccionCentro
                    {
                        IdTransaccionCentro = partes[0],
                        Centro = partes[2],
                        Estado = partes[3],
                        FechaHora = fecha,
                        Materiales = materialesBuilder.ToString().Trim()
                    };

                    transacciones.Add(transaccion);
                }
            }

            // Ordenar las transacciones por fecha de manera descendente
            return transacciones.OrderByDescending(t => t.FechaHora).ToList();
        }

    }
}


