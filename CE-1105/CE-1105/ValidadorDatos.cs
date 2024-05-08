using System;
using System.Windows.Forms;

public class ValidadorDatos
{
    // Método para validar los datos y retornar el estado de cada dato
    public string ValidarDatos(string textoTextBox1, string textoTextBox2, string textoTextBox3, string seleccionComboBox, bool estadoCheckBox)
    {
        // Llama a las funciones de validación para cada dato
        bool esTextoTextBox1Valido = !string.IsNullOrEmpty(textoTextBox1);
        bool esTextoTextBox2Valido = !string.IsNullOrEmpty(textoTextBox2);
        bool esTextoTextBox3Valido = !string.IsNullOrEmpty(textoTextBox3);
        string estadoSeleccion = ValidarSeleccion(seleccionComboBox);
        string estadoCheckBoxString = ValidarEstado(estadoCheckBox);

        // Construye el mensaje de resultado
        string resultado = $"TextoTextBox1: {esTextoTextBox1Valido}, TextoTextBox2: {esTextoTextBox2Valido}, TextoTextBox3: {esTextoTextBox3Valido}, {estadoSeleccion}, {estadoCheckBoxString}";

        return resultado;
    }

    public static bool ValidarTexto(string texto)
    {
        // Retorna true si el texto no está vacío, false en caso contrario
        return !string.IsNullOrEmpty(texto);
    }

    public static string ValidarSeleccion(string seleccion)
    {
        // Retorna el valor de la selección si no es nula o vacía, null en caso contrario
        return string.IsNullOrEmpty(seleccion) ? null : seleccion;
    }

    public static string ValidarEstado(bool estado)
    {
        // Retorna "Activo" si el estado es verdadero, "Inactivo" en caso contrario
        return estado ? "Activo" : "Inactivo";
    }
}


