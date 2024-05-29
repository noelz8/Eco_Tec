using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica
{
    public class TransaccionesLog
    {
        // Variable para mantener el total acumulado de materiales
        private static double totalAcumulado = 0.0;

        // Método para cargar materiales en un ComboBox desde un archivo de texto
        public static void CargarMateriales(ComboBox comboBox)
        {
            // Ruta del archivo de texto
            string filePath = @"C:\Users\Invitado1\Documents\GitHub\Eco_Tec\Materiales\bin\Debug\prueba_material.txt";

            // Leer y procesar el archivo de texto
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7)
                    {
                        // Comprobar si el material está activo
                        bool isActive = bool.Parse(parts[4]);
                        if (isActive)
                        {
                            // Agregar la información relevante al ComboBox
                            string displayText = $"{parts[0]}, {parts[1]}, {parts[2]}, {parts[3]}, {parts[6]}";
                            comboBox.Items.Add(displayText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo de materiales no se encuentra en la ruta especificada.");
            }
        }

        // Método para cargar centros de acopio en un ComboBox desde un archivo de texto
        public static void CargarCentros(ComboBox comboBox)
        {
            // Ruta del archivo de texto
            string filePath = @"C:\Users\Invitado1\Documents\GitHub\Eco_Tec\CE-1105\CE-1105\bin\Debug\net8.0-windows\Centros.txt";

            // Leer y procesar el archivo de texto
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 5)
                    {
                        // Comprobar si el centro está activo
                        bool isActive = bool.Parse(parts[3]);
                        if (isActive)
                        {
                            // Agregar la información relevante al ComboBox
                            string displayText = $"{parts[0]}, {parts[1]}";
                            comboBox.Items.Add(displayText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El de centros no se encuentra en la ruta especificada.");
            }
        }

        // Método para resetear el total acumulado de materiales
        public static void ResetTotalAcumulado()
        {
            totalAcumulado = 0.0;
        }

        // Método para eliminar un material del ListBox y actualizar el total acumulado
        public static void EliminarMaterial(ListBox listBox1, TextBox total)
        {
            // Verifica si hay un elemento seleccionado en el ListBox
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un material para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtiene el material seleccionado como cadena de texto
            string itemSeleccionado = listBox1.SelectedItem.ToString();
            // Divide la cadena en partes separadas por comas
            string[] parts = itemSeleccionado.Split(',');

            // Busca sobre las partes para encontrar el subtotal
            foreach (string part in parts)
            {
                // Verifica si la parte actual contiene "Subtotal:"
                if (part.Trim().StartsWith("Subtotal:"))
                {
                    // Extrae el valor del subtotal
                    string subtotalStr = part.Split(':')[1].Trim();
                    // Intenta convertir el valor del subtotal a un número
                    if (double.TryParse(subtotalStr, out double subtotal))
                    {
                        // Resta el subtotal del total acumulado
                        totalAcumulado -= subtotal;
                        break;
                    }
                }
            }

            // Elimina el material seleccionado del ListBox
            listBox1.Items.Remove(listBox1.SelectedItem);
            // Actualiza el texto del TextBox total con el nuevo total acumulado
            total.Text = totalAcumulado.ToString("F2");
        }

        // Método para validar que la transacción sea válida
        public static bool ValidarTransaccion(TextBox identificacion, ComboBox centros, ListBox listBox1)
        {
            // Esta verificación es Temporal para el carnet
            if (identificacion.Text.Length != 10 || !int.TryParse(identificacion.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese una identificación válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Verificación de centro de Acopio seleccionado
            if (centros.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un centro de acopio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Verificación de mínimo 1 seleccionado

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Por favor, agregue al menos un material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Método para crear los archivos de transacción de centro y estudiante
        public static void CrearArchivosTransaccion(TextBox identificacion, ComboBox centros, ListBox listBox1)
        {
            // Establecer las rutas de los archivos de transacción
            string centroFilePath = "TransaccionCentro.txt";
            string estudianteFilePath = "TransaccionEstudiante.txt";

            DateTime fecha = DateTime.Now;


            // Generar un ID único de 12 caracteres alfanuméricos y verificar que no exista en el archivo
            string idUnico;
            do
            {
                idUnico = GenerarIDUnico();
            } while (IdUnico(centroFilePath, $"R-{idUnico}"));

            string idCentro = centros.SelectedItem.ToString().Split(',')[0].Trim();

            // Construir la línea de texto para el archivo de transacción de centro
            StringBuilder centroLine = new StringBuilder();
            centroLine.Append($"R-{idUnico},T-{idUnico},{idCentro},Ingreso,{fecha}");

            // Repetir sobre los elementos del ListBox para agregar los detalles de los materiales
            foreach (var item in listBox1.Items)
            {
                string[] parts = item.ToString().Split(',');
                string nombreMaterial = parts[1].Trim();
                string cantidad = parts.FirstOrDefault(p => p.Contains("Cantidad:")).Split(':')[1].Trim();
                string subtotal = parts.FirstOrDefault(p => p.Contains("Subtotal:")).Split(':')[1].Trim();

                // Agregar el nombre del material, la cantidad y el subtotal a la línea de texto
                centroLine.Append($",{nombreMaterial},{cantidad},{subtotal}");
            }

            // Escribir la línea de texto en el archivo de transacción de centro
            using (StreamWriter swCentro = new StreamWriter(centroFilePath, true))
            {
                swCentro.WriteLine(centroLine.ToString());
            }

            // Construir la línea de texto para el archivo de transacción de estudiante
            StringBuilder estudianteLine = new StringBuilder();
            estudianteLine.Append($"T-{idUnico},{identificacion.Text},{idCentro}");

            // Iterar sobre los elementos del ListBox para agregar los detalles de los materiales
            foreach (var item in listBox1.Items)
            {
                string[] parts = item.ToString().Split(',');
                string nombreMaterial = parts[1].Trim();
                string cantidad = parts.FirstOrDefault(p => p.Contains("Cantidad:")).Split(':')[1].Trim();
                string subtotal = parts.FirstOrDefault(p => p.Contains("Subtotal:")).Split(':')[1].Trim();

                // Agregar el nombre del material, la cantidad y el subtotal a la línea de texto
                estudianteLine.Append($",{nombreMaterial},{cantidad},{subtotal}");
            }

            // Escribir la línea de texto en el archivo de transacción de estudiante
            using (StreamWriter swEstudiante = new StreamWriter(estudianteFilePath, true))
            {
                swEstudiante.WriteLine(estudianteLine.ToString());
            }
        }

        // Método para generar un ID único de 12 caracteres alfanuméricos
        private static string GenerarIDUnico()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Método para verificar si un ID único ya existe en el archivo TransaccionCentro.txt
        private static bool IdUnico(string filePath, string idUnico)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (line.Contains($"R-{idUnico}"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Función para agregar TEC colones al archivo "Billeteras"
        public static void AgregarTecColones(TextBox identificacion, TextBox total)
        {
            string filePath = "Billeteras.txt";
            string id = identificacion.Text;
            double montoTotal = double.Parse(total.Text);

            // Verificar si el archivo existe, sino lo crea
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            // Leer todas las líneas del archivo
            var lines = File.ReadAllLines(filePath).ToList();

            bool idEncontrado = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] parts = lines[i].Split(',');

                if (parts[0].Trim() == id)
                {
                    double montoExistente = double.Parse(parts[1].Trim());
                    double nuevoMonto = montoExistente + montoTotal;

                    lines[i] = $"{id}, {nuevoMonto}";
                    idEncontrado = true;
                    break;
                }
            }

            // Si la identificación no se encuentra en el archivo, agregarla
            if (!idEncontrado)
            {
                lines.Add($"{id}, {montoTotal}");
            }

            // Escribir las líneas actualizadas de vuelta al archivo
            File.WriteAllLines(filePath, lines);
        }
    

        // Método para agregar un material al ListBox y actualizar el total acumulado
        public static void AgregarMaterial(ComboBox listaMateriales, TextBox cantidad, ListBox listBox1, TextBox total)
            {
                // Verifica si se ha seleccionado un material en el ComboBox
                if (listaMateriales.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intenta convertir el texto del TextBox de cantidad a un número
                if (!double.TryParse(cantidad.Text, out double cantidadIngresada))
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtiene el material seleccionado del ComboBox y lo divide en partes+
                string materialSeleccionado = listaMateriales.SelectedItem.ToString();
                string[] parts = materialSeleccionado.Split(',');

                // Verifica si el arreglo tiene al menos 5 partes y si la cuarta parte (precio) puede ser convertida a un número
                if (parts.Length < 5 || !double.TryParse(parts[3], out double precioUnidad))
                {
                    MessageBox.Show("Error al obtener el precio del material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcula el subtotal multiplicando la cantidad ingresada por el precio por unidad
                double subtotal = cantidadIngresada * precioUnidad;
                // Agrega el subtotal al total acumulado
                totalAcumulado += subtotal;

                // Construye una cadena con los detalles del material, la cantidad y el subtotal
                string itemParaAgregar = $"{materialSeleccionado}, Cantidad: {cantidadIngresada}, Subtotal: {subtotal}";
                // Agrega la cadena al ListBox
                listBox1.Items.Add(itemParaAgregar);

                // Actualiza el TextBox total con el nuevo total acumulado, formateado a dos decimales
                total.Text = totalAcumulado.ToString("F2");
            }

    }
}
