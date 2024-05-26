using CE_1105.Logica;
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
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            TransaccionesLog.CargarMateriales(listaMateriales);

        }

        private void VerCentros(object sender, EventArgs e)
        {
            TransaccionesLog.CargarCentros(centros);
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
