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
    public partial class VistaAdministrador : Form
    {
        public VistaAdministrador()
        {
            InitializeComponent();
        }
        //Llamada de la interfaz de centros
        private void bthSedesCentros_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void btnCrearMaterial_Click(object sender, EventArgs e)
        {
            //Lllamada de la interfaz de crear material
            CrearMaterial crearMaterial = new CrearMaterial();
            crearMaterial.Show();
            this.Hide();
        }
        //Método encargado para llamar a la interfaz de Historial
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //Llamada de la interfaz de vista global 
            VistaGlobal vistaGlobal = new VistaGlobal();
            vistaGlobal.Show();
            this.Hide();
        }
        //Método encargado para salir de la interfaz de VistaAdministrador
        private void btnSalirVistaAdmin_Click(object sender, EventArgs e)
        {
            ValidacionUsuarios validacionUsuarios = new ValidacionUsuarios();
            validacionUsuarios.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
