using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_1105.Logica;

public class LeerEscribir 
{
    public static void EscribirDatosEnArchivoSede(string IDE, string Nombre_Sede, string Contacto, bool estadoCheckBox, string seleccionComboBox)
    {
        Nombre_Sede = Nombre_Sede.Replace(" ", "-");
        // Obtener la ruta de la carpeta de la aplicación
        string rutaCarpetaAplicacion = Application.StartupPath;

        // Construir la ruta completa del archivo
        string rutaArchivo = Path.Combine(rutaCarpetaAplicacion, "Sedes.txt"); // Asegúrate de que el nombre del archivo sea único o maneja la sobrescritura según sea necesario

        using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) // 'true' para agregar al final del archivo
        {
            writer.Write($"{IDE}, {Nombre_Sede}, {Contacto}, {seleccionComboBox}, {estadoCheckBox}\n");
        }
    }
    public static void EscribirDatosEnArchivoCentro(string IDE, string Nombre_Sede, string Contacto,  bool estadoCheckBox, string seleccionComboBox)
    {
        // Obtener la ruta de la carpeta de la aplicación
        string rutaCarpetaAplicacion = Application.StartupPath;

        // Construir la ruta completa del archivo
        string rutaArchivo = Path.Combine(rutaCarpetaAplicacion, "Centros.txt"); // Asegúrate de que el nombre del archivo sea único o maneja la sobrescritura según sea necesario

        // Verificar si el archivo ya existe
        if (File.Exists(rutaArchivo))
        {
            // Si el archivo existe, abrirlo en modo append para agregar datos al final
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) // 'true' para agregar al final del archivo
            {
                writer.WriteLine($"{IDE}, {Nombre_Sede}, {Contacto}, {estadoCheckBox}, {seleccionComboBox}");
            }
        }
        else
        {
            // Si el archivo no existe, crear uno nuevo y escribir los datos
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false)) // 'false' para sobrescribir el archivo si no existe
            {
                writer.WriteLine($"{IDE}, {Nombre_Sede}, {Contacto}, {estadoCheckBox}, {seleccionComboBox}");
            }
        }
    }
}

