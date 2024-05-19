using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CE_1105
{
    public partial class Centro : Form
    {
        private Form _SedeCentro;
        public Centro(Form sedeCentro)
        {
            InitializeComponent();
            _SedeCentro = sedeCentro;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiFormulario_FormClosing);
            CargarComboBoxDesdeArchivo("Sedes.txt");

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string Ubicacion = TBUbicacion.Text;
            string Contacto = TBContacto.Text;
            string seleccionComboBox = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            bool estadoCheckBox = ActivoInactivo.Checked;
            string IDE = TBIde.Text;

            ValidacionCentro validadorDatos = new ValidacionCentro();
            string resultado = validadorDatos.ValidadacionCentro(IDE, seleccionComboBox, Contacto, Ubicacion, estadoCheckBox);

            if (resultado.Contains("No válido"))
            {
                MessageBox.Show("Los datos no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LimpiarControles();
                validadorDatos.EscribirDatosEnArchivo(IDE, seleccionComboBox, Contacto, Ubicacion, estadoCheckBox);
                MessageBox.Show($"Los datos son válidos.\nResultado de la validación: {resultado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void LimpiarControles()
        {
            TBContacto.Clear();
            TBUbicacion.Clear();
            TBIde.Clear();
            comboBox1.SelectedIndex = -1; // Selecciona la opción predeterminada
            ActivoInactivo.Checked = false;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            if (_SedeCentro != null)
            {
                _SedeCentro.Show();
                this.Hide();
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
        private void CargarComboBoxDesdeArchivo(string rutaArchivo)
        {
            // Leer el archivo línea por línea
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    // Dividir la línea por algún delimitador, por ejemplo, un espacio
                    string[] partes = linea.Split(' ');

                    // Verificar si la posición 4 es "True"
                    if (partes.Length >= 5 && partes[4] == "True")
                    {
                        // Crear una nueva cadena sin el último carácter
                        string contenidoSinUltimoCaracter = partes[1].Substring(0, partes[1].Length - 1);

                        // Agregar el contenido modificado al ComboBox
                        comboBox1.Items.Add(contenidoSinUltimoCaracter);
                    }
                }
            }
        }

    }
}
