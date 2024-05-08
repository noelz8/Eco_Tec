using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;

public class ValidadorDatos
{
    // Método para validar los datos y retornar el estado de cada dato
    public string ValidarDatos(string IDE, string Nombre_Sede, string Contacto, string seleccionComboBox, bool estadoCheckBox)
    {
        // Llama a las funciones de validación para cada dato
        //string Identificacion = GenerateUniqueKey(); // Usa ValidarTexto para evaluar correctamente
        string sedeValida = SedeCorrecta(Nombre_Sede); // SedeCorrecta retorna el string de la sede si es válido, null en caso contrario
        string contactoValido = ContactoV(Contacto); // Aplica la misma lógica para textoTextBox3
        string estadoSeleccion = ValidarSeleccion(seleccionComboBox); // Mantén la lógica original si deseas retornar null para selecciones vacías
        string estadoCheckBoxString = ValidarEstado(estadoCheckBox);

        // Construye el mensaje de resultado
        string resultado = $"Identificacion: {IDE}, Sede: {sedeValida ?? "No válido"}, Contacto: {contactoValido}, Estado: {estadoSeleccion}, Provincia: {estadoCheckBoxString}";

        return resultado;
    }

    public static string ValidarTexto(string texto)
    {
        // Retorna "No válido" si el texto está vacío, "Válido" en caso contrario
        return string.IsNullOrEmpty(texto) ? "No válido" : texto;
    }


    public static string ValidarSeleccion(string seleccion)
    {
        // Retorna "No válido" si la selección es nula o vacía, el valor de la selección en caso contrario
        return string.IsNullOrEmpty(seleccion) ? "No válido" : seleccion;
    }


    public static string ValidarEstado(bool estado)
    {
        // Retorna "Activo" si el estado es verdadero, "Inactivo" en caso contrario
        return estado ? "Activo" : "Inactivo";
    }

    public static string SedeCorrecta(string sede)
    {
        // Utiliza una expresión regular para verificar si el string cumple con los criterios
        Regex r = new Regex(@"^[A-Z0-9]+$");
        if (r.IsMatch(sede))
        {
            return null; // Retorna el string de la sede si es válido
        }
        else
        {
            return sede; // Retorna null si el string no es válido
        }
    }
    public static string ContactoV(string contacto)
    {
        // Utiliza una expresión regular para verificar si el número es válido y consta de exactamente 8 dígitos
        Regex r = new Regex(@"^\d{8}$");
        Match match = r.Match(contacto);
        if (match.Success)
        {
            // Retorna el contacto si es válido
            return contacto; // Retorna el contacto válido
        }
        else
        {
            return "No válido"; // Retorna null si el contacto no es válido
        }
    }
    public void EscribirDatosEnArchivo(string IDE, string Nombre_Sede, string Contacto, string seleccionComboBox, bool estadoCheckBox)
    {
        // Obtener la ruta de la carpeta de la aplicación
        string rutaCarpetaAplicacion = Application.StartupPath;

        // Construir la ruta completa del archivo
        string rutaArchivo = Path.Combine(rutaCarpetaAplicacion, "datos.txt"); // Asegúrate de que el nombre del archivo sea único o maneja la sobrescritura según sea necesario

        using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) // 'true' para agregar al final del archivo
        {
            writer.Write($"{IDE}, {Nombre_Sede}, {Contacto}, {seleccionComboBox}, {estadoCheckBox}\n");
        }
    }

}




