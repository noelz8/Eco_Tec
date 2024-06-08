using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CE_1105.Logica;

namespace CE_1105.Interfaz
{
    public partial class Historial : Form
    {
        private GestorTransacciones gestor;
        public Historial()
        {
            InitializeComponent();
            gestor = new GestorTransacciones();
            CargarCentros();
        }

        // Cargar los centros de acopio en el ComboBox al iniciar el formulario
        private void CargarCentros()
        {
            comboBoxCentro.DataSource = gestor.ObtenerCentros();
        }

        // Maneja el evento de clic del botón "Buscar"
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string centroSeleccionado = comboBoxCentro.SelectedItem.ToString();
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;

            // Obtener las transacciones filtradas por centro de acopio y rango de fechas
            var transacciones = gestor.ObtenerTransacciones(centroSeleccionado, fechaInicio, fechaFin);

            if (transacciones.Count == 0)
            {
                labelMensaje.Text = "No hay registros para el rango seleccionado.";
                dataGridViewTransacciones.DataSource = null;
            }
            else
            {
                labelMensaje.Text = string.Empty;

                var detalles = new List<TransaccionDetalle>();

                // Construir los detalles de las transacciones para mostrar en el DataGrid
                foreach (var transaccion in transacciones)
                {
                    var materialesBuilder = new StringBuilder();
                    foreach (var material in transaccion.Materiales)
                    {
                        // Concatenar los detalles de los materiales en una sola cadena
                        materialesBuilder.AppendLine($"{material.Nombre}: {material.Cantidad} unidades, {material.TecColones} TecColones");
                    }

                    // Agregar los detalles de la transacción a la lista
                    detalles.Add(new TransaccionDetalle
                    {
                        IdTransaccionCentro = transaccion.IdTransaccionCentro,
                        CentroAcopio = transaccion.CentroAcopio,
                        Estado = transaccion.Estado,
                        FechaHora = transaccion.FechaHora,
                        Materiales = materialesBuilder.ToString().Trim()
                    });
                }

                // Asignar los detalles de las transacciones como fuente de datos del DataGrid
                dataGridViewTransacciones.DataSource = detalles;
            }
        }

        // Maneja el evento de clic del botón "Volver"
        private void button1_Click(object sender, EventArgs e)
        {
            VistaDesarrollador vistaDesarrollador = new VistaDesarrollador();
            vistaDesarrollador.Show();
            this.Close();
        }

        private void dataGridViewTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }
    }
}