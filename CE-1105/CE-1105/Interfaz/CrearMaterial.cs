using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CE_1105;
using CE_1105.Logica;

namespace CE_1105.Interfaz
{
    public partial class CrearMaterial : Form
    {
        public CrearMaterial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMaterial = txtNombreMaterial.Text.Trim();//guardar los datos escritos
                string unidadMaterial = comboBoxUnidad.SelectedItem?.ToString();
                decimal valorUnitarioMaterial;
                decimal.TryParse(txtValorUnitario.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out valorUnitarioMaterial);
                bool estadoMaterial = checkBoxEstado.Checked;
                string descripcionMaterial = txtDescripcion.Text.Trim();

                (string mensaje, Material material) = Material.CrearMaterial(nombreMaterial, unidadMaterial, txtValorUnitario.Text, estadoMaterial, descripcionMaterial);

                if (material != null)
                {
                    ManejoMaterial.GuardarMaterial(material);
                    MessageBox.Show("Material creado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //VistaDesarrollador vistaDesarrollador = new VistaDesarrollador();
            //vistaDesarrollador.Show();
            
            VistaAdministrador  vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
            this.Hide();
        }

        private void btnListaMateriales_Click(object sender, EventArgs e)
        {
            ListaMateriales materialListForm = new ListaMateriales();
            materialListForm.ShowDialog();
        }
    }
}
