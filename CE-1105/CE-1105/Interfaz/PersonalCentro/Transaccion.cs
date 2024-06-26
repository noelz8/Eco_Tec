﻿using CE_1105.Logica.Transacciones;
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
            // Se asocia el evento DoubleClick del listBox1 al método listBox1_DoubleClick
            listBox1.DoubleClick += new EventHandler(listBox1_DoubleClick);
        }

        // Método que se ejecuta cuando inicia, trae la info de los materiales y centros
        private void Cargar(object sender, EventArgs e)
        {
            // Carga los materiales en el comboBox listaMateriales
            TransaccionesLog.CargarMateriales(listaMateriales);
            TransaccionesLog.CargarCentros(centros);
        }

        // Método para cancelar la transacción
        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Resetea el total acumulado de materiales
            TransaccionesLog.ResetTotalAcumulado();
            //VistaDesarrollador vistaDesarrollador = new VistaDesarrollador();
            //vistaDesarrollador.Show();
            VistaCentroAcopio vistaCentroAcopio = new VistaCentroAcopio();
            vistaCentroAcopio.Show();
            this.Close();
        }

        // Método que se ejecuta al finalizar la transacción
        private void finalizar_Click(object sender, EventArgs e)
        {
            // Verifica que la transacción sea válida
            if (TransaccionesLog.ValidarTransaccion(identificacion, centros, listBox1))
            {
                // Muestra un mensaje de éxito
                MessageBox.Show("Transacción finalizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Crea los archivos de la transacción
                TransaccionesLog.CrearArchivosTransaccion(identificacion, centros, listBox1);
                //Agrega los Tec Colones
                TransaccionesLog.AgregarTecColones(identificacion, total);
                // Resetea el total acumulado de materiales
                TransaccionesLog.ResetTotalAcumulado();
                VistaCentroAcopio vistaCentroAcopio = new VistaCentroAcopio();
                vistaCentroAcopio.Show();
                this.Close();
            }
            else
            {
                // Si la transacción no es válida, muestra un mensaje de error
                MessageBox.Show("La transacción no es válida. Por favor, revise los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Método para eliminar un material del listBox1 al hacer doble clic
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            TransaccionesLog.EliminarMaterial(listBox1, total);
        }

        // Método para agregar un material a la transacción
        private void agregar_Click(object sender, EventArgs e)
        {
            TransaccionesLog.AgregarMaterial(listaMateriales, cantidad, listBox1, total);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listaMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
