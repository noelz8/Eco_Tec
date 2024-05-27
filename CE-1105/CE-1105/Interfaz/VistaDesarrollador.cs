using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eco_Tec;


namespace CE_1105.Interfaz
{
    public partial class VistaDesarrollador : Form
    {
        public VistaDesarrollador()
        {
            InitializeComponent();
        }

        private void btn_CrearTransacciones_Click(object sender, EventArgs e)
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Show(); // Muestra el formulario de transaccion.
            this.Hide();
        }

        private void btn_CrearSedes_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show(); 
            this.Hide();
        }

        private void btn_CrearMaterial_Click(object sender, EventArgs e)
        {
            InterfazMaterial material = new InterfazMaterial(); 
            material.Show();
            this.Hide();

        }
    }
}
