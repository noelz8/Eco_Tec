using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CE_1105.Interfaz
{
    public partial class VistaCentroAcopio : Form
    {
        public VistaCentroAcopio()
        {
            InitializeComponent();
        }

        private void btnCrearTransaccion_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Crear", se abre un nuevo formulario de transaccion.
            Transaccion transaccion = new Transaccion();
            transaccion.Show(); // Muestra el formulario de transaccion.
            this.Hide(); // Oculta el formulario actual.
        }
        //Método para llamar a la interfaz de Transaccion centros
        private void btnTransaccionCentros_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
            this.Hide();
        }
        //Método para llamar a la interfaz de Anular transacciones
        private void btnAnularTransacciones_Click(object sender, EventArgs e)
        {
            Anular anular = new Anular();
            anular.Show();
            this.Hide();
        }
        //Método para salir de la interfaz de Vista centro de acopio
        private void btnSalirVistaCentroAcopio_Click(object sender, EventArgs e)
        {
            ValidacionUsuarios validacionUsuarios = new ValidacionUsuarios();
            validacionUsuarios.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
