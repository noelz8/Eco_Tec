using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using CE_1105.Logica;
using CE_1105.Interfaz;




namespace Eco_Tec
{

    public partial class InterfazMaterial : Form
    {


      
        public InterfazMaterial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


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

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e) //funcion para limitar solo numeros en el espacio tec-colones
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y el punto decimal.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListaMateriales_Click(object sender, EventArgs e)
        {
            ListaMateriales materialListForm = new ListaMateriales();
            materialListForm.ShowDialog();
        }
    }

       
    }



