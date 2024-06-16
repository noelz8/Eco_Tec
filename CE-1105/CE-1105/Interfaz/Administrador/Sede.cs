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
using System.IO;

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

        private void Regresar_Click(object sender, EventArgs e)
        {
            if (_SedeCentro != null)
            {
                _SedeCentro.Show();
                this.Hide();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Recoge los datos de los controles
            string Nombre_Sede = NombreSede.Text;
            string Contacto = NumeroContacto.Text;
            string seleccionComboBox = CProvincias.SelectedItem != null ? CProvincias.SelectedItem.ToString() : "";
            bool estadoCheckBox = ActivoInactivo.Checked;

            ValidadorDeSedes validadorDatos = new ValidadorDeSedes();
            // Genera una identificación única 
            string IDE = GenerateUniqueKey();

            // Llama a la función de validación con los datos recogidos
            string resultado = validadorDatos.ValidarDatos(IDE, Nombre_Sede, Contacto, estadoCheckBox, seleccionComboBox);

            // Determina si los datos son válidos basándote en el resultado
            // Determina si los datos son válidos basándote en el resultado
            if (resultado.Contains("No válido"))
            {
                // Si hay "No válido" en el resultado, muestra un mensaje de error
                MessageBox.Show("Los datos no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si no hay "No válido" en el resultado, muestra un mensaje de éxito
                LimpiarControles();
                LeerEscribir.EscribirDatosEnArchivoSede(IDE, Nombre_Sede, Contacto, estadoCheckBox, seleccionComboBox);
                MessageBox.Show($"Los datos son válidos.\nResultado de la validación: {resultado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void MiFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el cierre fue iniciado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void LimpiarControles()
        {
            NombreSede.Clear();
            NumeroContacto.Clear();
            // Limpiar otros controles según sea necesario
            CProvincias.SelectedIndex = -1; // Selecciona la opción predeterminada
            ActivoInactivo.Checked = false;
        }

 
        public static string GenerateUniqueKey()
        {
            // Implementación de la función
            Random random = new Random();
            string identifier = "";
            for (int i = 0; i < 12; i++)
            {
                int number = random.Next(0, 36);
                if (number < 10)
                {
                    identifier += Convert.ToChar(number + 48);
                }
                else
                {
                    if (number < 26)
                    {
                        identifier += Convert.ToChar(number + 65);
                    }
                    else
                    {
                        identifier += Convert.ToChar(number - 26 + 97);
                    }
                }
            }
            return "S-" + identifier;
        }
    }

}


