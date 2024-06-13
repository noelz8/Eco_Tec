﻿using CE_1105.Logica.ModTransacciones;
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
    public partial class Anular : Form
    {
        public Anular()
        {
            InitializeComponent();
            LoadTransacciones();
        }

        private void LoadTransacciones()
        {
            try
            {
                dataGridViewMateriales.Rows.Clear(); // limpia la tabla para evitar errores

                // Lista de archivos de texto a leer
                List<string> fileNames = new List<string> { "TransaccionCentro.txt" }; // Solo se incluye el archivo relevante

                foreach (string fileName in fileNames)
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line;
                        int lineNumber = 0;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] materialData = line.Split(',');

                            // Verifica si la posición 4 es "Desabilitada"
                            if (materialData[3] == "Desabilitada") // Asumiendo que la posición 4 corresponde a la columna 3 después de split
                            {
                                continue; // Salta la iteración actual y pasa a la siguiente línea
                            }

                            // Para el archivo TransaccionCentro.txt, seguimos el mismo patrón anterior
                            dataGridViewMateriales.Rows.Add(
                                materialData[0],  // Columna 1
                                materialData[2], // Columna 2
                                materialData[4], // Columna 3
                                materialData[5],  // Columna 4
                                materialData[6], // Columna 5
                                materialData[7]  // Columna 6
                            );

                            double total = 0; // Inicializamos el total
                            total = double.Parse(materialData[7]);
                            if (materialData.Length > 9)
                            {
                                // Si hay más de 9 elementos, los distribuimos entre las columnas 4, 5 y 6
                                int columnIndex = 3; // Comenzamos en la columna 4
                                for (int i = 8; i < materialData.Length; i++)
                                {
                                    // Agregamos el valor a la celda existente en la columna correspondiente
                                    dataGridViewMateriales.Rows[lineNumber].Cells[columnIndex].Value += ", " + materialData[i];
                                    if (columnIndex == 5) // Si estamos en la columna 6
                                    {
                                        total += double.Parse(materialData[i]); // Sumamos el valor al total
                                    }
                                    columnIndex = (columnIndex + 1) % 3 + 3; // Pasamos a la siguiente columna (4, 5, 6, 4, 5, 6, ...)
                                    if (columnIndex > 5) // Si hemos llegado a la columna 6, reiniciamos a la columna 4
                                    {
                                        columnIndex = 3;
                                    }
                                }
                            }
                            else
                            {
                                // Si hay menos de 9 elementos, el total es igual al valor en la columna 6
                                total = double.Parse(materialData[7]);
                            }
                            dataGridViewMateriales.Rows[lineNumber].Cells["Total"].Value = total; // Asignamos el total a la columna "Total"

                            lineNumber++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivoManipulador manipulador = new ArchivoManipulador();
                DataGridViewRow selectedRow = dataGridViewMateriales.SelectedRows[0];
                string id = selectedRow.Cells["ID"].Value.ToString().Substring(2);
                double total = double.Parse(selectedRow.Cells["Total"].Value.ToString());
                string fileName = "TransaccionEstudiante.txt";
                string[] lines = File.ReadAllLines(fileName);

                List<string> newLines = new List<string>();
                string Estado = "Desabilitada";

                foreach (string line in lines)
                {
                    string[] materialData = line.Split(',');
                    if (materialData[0].Substring(2) == id)
                    {
                        string carnet = materialData[1];

                        manipulador.ModificarBilletera(carnet, total, Estado);
                        manipulador.ModificarTransferenciaCentro(id, Estado);
                        

                        MessageBox.Show("El rebajo fue hecho satisfactoriamente");
                        VistaCentroAcopio vistaCentroAcopio = new VistaCentroAcopio();
                        vistaCentroAcopio.Show();
                        this.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes de seleccionar por completo la fila. Error:: " + ex.Message);
            }
        }


        private void Anular_Load(object sender, EventArgs e)
        {

        }

        private void btnAnularRegresar_Click(object sender, EventArgs e)
        {
            VistaCentroAcopio vistaCentroAcopio = new VistaCentroAcopio();
            vistaCentroAcopio.Show();
            this.Close();
        }

        private void dataGridViewMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}