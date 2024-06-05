﻿using CE_1105.Interfaz;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica
{
    // Clase que gestiona las operaciones relacionadas con las transacciones
    public class GestorTransacciones
    {
        private string rutaArchivoTransacciones;
        private string rutaArchivoCentros;

        public GestorTransacciones(string rutaArchivoTransacciones, string rutaArchivoCentros)
        {
            this.rutaArchivoTransacciones = rutaArchivoTransacciones;
            this.rutaArchivoCentros = rutaArchivoCentros;
        }

        // Método para obtener la lista de centros de acopio desde un archivo
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

        // Método para obtener las transacciones filtradas por centro de acopio y rango de fechas
        public List<ManejoTransaccion> ObtenerTransacciones(string centroAcopio, DateTime fechaInicio, DateTime fechaFin)
        {
            var transacciones = new List<ManejoTransaccion>();
            var lineas = File.ReadAllLines(rutaArchivoTransacciones);

            foreach (var linea in lineas)
            {
                var partes = linea.Split(',');

                if (partes.Length < 8) continue;

                var fecha = DateTime.ParseExact(partes[4], "dd/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);

                // Filtrar por centro de acopio y rango de fechas
                if (partes[2] == centroAcopio && fecha >= fechaInicio && fecha <= fechaFin)
                {
                    var transaccion = new ManejoTransaccion
                    {
                        IdTransaccionCentro = partes[0],
                        CentroAcopio = partes[2],
                        Estado = partes[3],
                        FechaHora = fecha
                    };

                    // Agregar materiales a la transacción
                    for (int i = 5; i < partes.Length; i += 3)
                    {
                        if (i + 2 < partes.Length)
                        {
                            transaccion.Materiales.Add(new GridMateriales
                            {
                                Nombre = partes[i].Trim(),
                                Cantidad = int.Parse(partes[i + 1].Trim()),
                                TecColones = int.Parse(partes[i + 2].Trim())
                            });
                        }
                    }

                    transacciones.Add(transaccion);
                }
            }

            // Ordenar las transacciones por fecha de manera descendente
            return transacciones.OrderByDescending(t => t.FechaHora).ToList();
        }
    }
}