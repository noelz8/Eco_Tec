using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_1105.Logica.General;

namespace CE_1105.Logica.Transacciones
{
    public class TransaccionesLog
    {
        // Variable para mantener el total acumulado de materiales
        private static double totalAcumulado = 0.0;

        // Método para cargar materiales en un ComboBox desde un archivo de texto
        public static void CargarMateriales(ComboBox comboBox)
        {
            try
            {
                // Ruta del archivo de texto
                string filePath = Constantes.RutaArchivoMateriales;

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
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("El archivo de materiales no se encuentra en la ruta especificada.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato de algunos datos en el archivo no es válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }


        // Método para cargar centros de acopio en un ComboBox desde un archivo de texto
        public static void CargarCentros(ComboBox comboBox)
        {
            // Ruta del archivo de texto
            string filePath = Constantes.RutaArchivoCentros;

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
                MessageBox.Show("El archivo de centros no se encuentra en la ruta especificada.");
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
            if (!System.Text.RegularExpressions.Regex.IsMatch(identificacion.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Por favor, ingrese una identificación válida (10 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// Coordina la creación de archivos de transacción basada en la información ingresada en la interfaz.
       
        public static void CrearArchivosTransaccion(TextBox identificacion, ComboBox centros, ListBox listBox1)
        {
            string centroFilePath = Constantes.RutaArchivoTransacciones;
            string estudianteFilePath = Constantes.RutaArchivoEstudiantes;
            string idUnico = GenerarIdUnicoValido(centroFilePath);
            string idCentro = centros.SelectedItem.ToString().Split(',')[0].Trim();

            string centroLine = ConstruirLineaTransaccion(idUnico, idCentro, identificacion, listBox1, false);
            EscribirEnArchivo(centroFilePath, centroLine);

            string estudianteLine = ConstruirLineaTransaccion(idUnico, idCentro, identificacion, listBox1, true);
            EscribirEnArchivo(estudianteFilePath, estudianteLine);
        }

        /// Construye una única línea de texto que representa una transacción, para ser escrita en un archivo.     
        public static string ConstruirLineaTransaccion(string idUnico, string idCentro, TextBox identificacion, ListBox listBox1, bool esEstudiante)
        {
            StringBuilder line = new StringBuilder();
            line.Append(esEstudiante ? $"T-{idUnico},{identificacion.Text},{idCentro}" : $"R-{idUnico},T-{idUnico},{idCentro},Ingreso,{DateTime.Now}");

            foreach (var item in listBox1.Items)
            {
                var parts = item.ToString().Split(',');
                var nombreMaterial = parts[1].Trim();
                var detalles = parts.Where(p => p.Contains("Cantidad:") || p.Contains("Subtotal:")).Select(p => p.Split(':')[1].Trim()).ToArray();
                line.Append($",{nombreMaterial},{detalles[0]},{detalles[1]}");
            }

            return line.ToString();
        }

            /// Escribe una línea de datos en un archivo especificado.
            public static void EscribirEnArchivo(string filePath, string dataLine)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true)) 
            {
                sw.WriteLine(dataLine);  // Escribe la línea de datos en el archivo
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

        /// Genera un ID único y asegura que no exista ya en el archivo dado.
        public static string GenerarIdUnicoValido(string filePath)
        {
            string idUnico;
            do
            {
                idUnico = GenerarIDUnico();  // Llama a la función que genera un ID basado en caracteres aleatorios
            } while (IdUnico(filePath, $"R-{idUnico}"));  // Verifica si el ID ya existe en el archivo especificado
            return idUnico;
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
            string filePath = Constantes.RutaArchivoBilleteras;
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

            // Intenta convertir el texto del TextBox de cantidad a un número positivo
            if (!double.TryParse(cantidad.Text, out double cantidadIngresada))
            {
                // Si la entrada no se puede convertir a un número, muestra un mensaje de error.
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cantidadIngresada <= 0)
            {
                // Verifica si el número es positivo y mayor que cero
                MessageBox.Show("Por favor, ingrese una cantidad positiva mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Obtiene el material seleccionado del ComboBox y lo divide en partes
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