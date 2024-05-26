using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CE_1105.Interfaz;

namespace CE_1105
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Crear", se abre un nuevo formulario de SedeCentro.
            SedeCentro sedeCentro = new SedeCentro();
            sedeCentro.Show(); // Muestra el formulario de SedeCentro.
            this.Hide(); // Oculta el formulario actual.
        }

        private TreeNode CreateNode(string[] values)
        {
            TreeNode node = new TreeNode(values[0]); // Crea un nuevo nodo con el primer valor como texto.

            // Construye la descripción del nodo con los elementos "Código", "Nombre", "Provincia", "Número", y "Estado".
            // Cambia el valor del último elemento a "Activo" o "Desactivado" basado en el valor booleano original.
            string estado = values[4] == " True" ? "Activo" : "Desactivado";
            node.Text = $"Nombre: {values[1]}, Número: {values[2]}, Provincia: {values[3]}, Estado: {estado}";

            return node; // Retorna el nodo creado.
        }




        private void Principal_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, se limpian los nodos existentes en ListaSedeCentro.
            ListaSedeCentro.Nodes.Clear();

            // Se lee el archivo Sedes.txt y se crean nodos para cada línea.
            string sedesPath = "Sedes.txt";
            if (File.Exists(sedesPath))
            {
                using (StreamReader reader = new StreamReader(sedesPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string sede = reader.ReadLine();
                        string[] sedeValues = sede.Split(',');
                        if (sedeValues.Length > 0) // Verifica si hay suficientes valores.
                        {
                            TreeNode sedeNode = CreateNode(sedeValues); // Crea un nodo para la sede.
                                                                        // Si el nodo de la sede no tiene hijos, se agrega un nodo hijo vacío.
                            ListaSedeCentro.Nodes.Add(sedeNode); // Agrega el nodo de la sede a la lista.
                        }
                    }
                }
            }

            // Se lee el archivo Centros.txt y se agregan subnodos para cada línea.
            string centrosPath = "Centros.txt";
            if (File.Exists(centrosPath))
            {
                using (StreamReader centroReader = new StreamReader(centrosPath))
                {
                    while (!centroReader.EndOfStream)
                    {
                        string centro = centroReader.ReadLine();
                        string[] centroValues = centro.Split(',');
                        if (centroValues.Length > 0) // Verifica si hay suficientes valores.
                        {
                            // Busca el nodo de la sede correspondiente basándose en el nombre de la sede.
                            foreach (TreeNode nodo in ListaSedeCentro.Nodes)
                            {
                                if (nodo.Text.Contains(centroValues[1])) // Comprueba si el nodo contiene el nombre de la sede.
                                {
                                    string estado = centroValues[3] == " True" ? "Activo" : "Desactivado";
                                    // Agrega el Centro como subnodo con todos los datos de la línea.
                                    nodo.Nodes.Add(new TreeNode($"Código: {centroValues[0]}, Nombre: {centroValues[1]}, Número: {centroValues[2]}, Estado: {estado}, Ubicacion: {centroValues[4]}"));
                                    // Elimina subnodos vacíos después de agregar los subnodos reales.
                                    break; // Salta de la iteración una vez que se ha encontrado el nodo correcto.
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Crear", se abre un nuevo formulario de transaccion.
            Transaccion transaccion = new Transaccion();
            transaccion.Show(); // Muestra el formulario de transaccion.
            this.Hide(); // Oculta el formulario actual.
        }
    }
}



