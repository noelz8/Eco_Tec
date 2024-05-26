using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica
{
    public class TransaccionesLog
    {
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
                MessageBox.Show("El archivo no se encuentra en la ruta especificada.");
            }
        }
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
                MessageBox.Show("El archivo no se encuentra en la ruta especificada.");
            }

        }
    }
}

