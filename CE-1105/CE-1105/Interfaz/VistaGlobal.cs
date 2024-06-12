using CE_1105.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CE_1105.Logica;

namespace CE_1105.Interfaz
{
    public partial class VistaGlobal : Form
    {
        private GestorGlobal gestor;
        public VistaGlobal()
        {
            InitializeComponent();
            gestor = new GestorGlobal();
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;

            // Obtener las transacciones filtradas por rango de fechas
            var transacciones = gestor.ObtenerTransacciones(fechaInicio, fechaFin);

            if (transacciones.Count == 0)
            {
                labelMensaje.Text = "No hay registros para el rango seleccionado.";
                dataGridViewGlobal.DataSource = null;
            }
            else
            {
                labelMensaje.Text = string.Empty;

                var detalles = new List<TransaccionCentro>();

                // Construir los detalles de las transacciones para mostrar en el DataGrid
                foreach (var transaccion in transacciones)
                {
                    detalles.Add(new TransaccionCentro
                    {
                        IdTransaccionCentro = transaccion.IdTransaccionCentro,
                        Centro = transaccion.Centro,
                        Estado = transaccion.Estado,
                        FechaHora = transaccion.FechaHora,
                        Materiales = transaccion.Materiales
                    });
                }

                // Asignar los detalles de las transacciones como fuente de datos del DataGrid
                dataGridViewGlobal.DataSource = detalles;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            //VistaDesarrollador vistaDesarrollador = new VistaDesarrollador();
            //vistaDesarrollador.Show();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();   
            vistaAdministrador.Show();
            this.Close();
        }
    }
}

