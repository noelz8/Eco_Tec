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
            gestor = new GestorTransacciones("TransaccionCentro", "Centro.txt");
            CargarCentros();
        }
        private void CargarCentros()
        {
            comboBoxCentro.DataSource = gestor.ObtenerCentros();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string centroSeleccionado = comboBoxCentro.SelectedItem.ToString();
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;

            var transacciones = gestor.ObtenerTransacciones(centroSeleccionado, fechaInicio, fechaFin);

            if (transacciones.Count == 0)
            {
                labelMensaje.Text = "No hay registros para el rango seleccionado.";
                dataGridViewTransacciones.DataSource = null;
            }
            else
            {
                labelMensaje.Text = string.Empty;
                dataGridViewTransacciones.DataSource = transacciones;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaDesarrollador vistaDesarrollador = new VistaDesarrollador();
            vistaDesarrollador.Show();
            this.Close();
        }
    }
}
