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
    public partial class ListaMateriales : Form
    {
        public ListaMateriales()
        {
            InitializeComponent();
            LoadMateriales();
        }
        private void LoadMateriales()
        {
            try
            {
                dataGridViewMateriales.Rows.Clear();//limpia la tabla para evitar errores

                using (StreamReader reader = new StreamReader("prueba_material.txt"))//se llama al archivo donde estan guardados
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] materialData = line.Split(',');//para separar los datos entre si
                        if (materialData.Length > 1)
                        {
                            dataGridViewMateriales.Rows.Add(materialData);//se añaden los datos en las columnas correspondientes
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargar materiales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
