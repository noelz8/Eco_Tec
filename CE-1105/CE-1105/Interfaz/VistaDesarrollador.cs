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
    public partial class VistaDesarrollador : Form
    {
        public VistaDesarrollador()
        {
            InitializeComponent();
        }

        private void btn_CrearTransaccion_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Crear", se abre un nuevo formulario de transaccion.
            Transaccion transaccion = new Transaccion();
            transaccion.Show(); // Muestra el formulario de transaccion.
            this.Hide(); // Oculta el formulario actual.
        }

        private void btn_CrearSede_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void btn_CrearMaterial_Click(object sender, EventArgs e)
        {
            CrearMaterial crearMaterial = new CrearMaterial();
            crearMaterial.Show();
            this.Hide();
        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
            this.Hide();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            Anular anular = new Anular();
            anular.ShowDialog();
        }
    }
}
