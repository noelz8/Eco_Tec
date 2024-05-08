using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CE_1105
{
    public partial class Sede : Form
    {

        private Form _SedeCentro;
        public Sede(Form SedeCentro)
        {
            InitializeComponent();
            _SedeCentro = SedeCentro;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiFormulario_FormClosing);
        }

        private void ActivoInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            if (_SedeCentro != null)
            {
                _SedeCentro.Show();
                this.Close();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Recoge los datos de los controles
            string textoTextBox1 = Identificacion.Text;
            string textoTextBox2 = NombreSede.Text;
            string textoTextBox3 = NumeroContacto.Text;
            string seleccionComboBox = CProvincias.SelectedItem.ToString();
            bool estadoCheckBox = ActivoInactivo.Checked;

            ValidadorDatos validadorDatos = new ValidadorDatos();

            // Llama a la función de validación con los datos recogidos
            string resultado = validadorDatos.ValidarDatos(textoTextBox1, textoTextBox2, textoTextBox3, seleccionComboBox, estadoCheckBox);

            // Determina si los datos son válidos basándote en el resultado
            if (resultado.Contains("Activo") && resultado.Contains("Activo")) // Asume que "Activo" indica que los datos son válidos
            {
                // Si los datos son válidos, muestra un mensaje de éxito
                MessageBox.Show($"Los datos son válidos.\nResultado de la validación: {resultado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si los datos no son válidos, muestra un mensaje de error
                MessageBox.Show("Los datos no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Muestra un mensaje al usuario
            MessageBox.Show("Este es un mensaje personalizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MiFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el cierre fue iniciado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}


