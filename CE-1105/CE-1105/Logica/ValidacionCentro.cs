using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidacionCentro
{
    // Método para validar los datos y retornar el estado de cada dato
    public string ValidadacionCentro(string IDE, string Nombre_Sede, string Contacto, string Ubicacion, bool estadoCheckBox)
    {
        // Llama a las funciones de validación para cada dato
        string sedeValida = SedeCorrecta(Nombre_Sede); // SedeCorrecta retorna el string de la sede si es válido, null en caso contrario
        string contactoValido = ContactoV(Contacto); 
        string estadoSeleccion = ValidarSeleccion(Ubicacion); 
        string estadoCheckBoxString = ValidarEstado(estadoCheckBox);
        string identificacion = VerificaIde(IDE);

        // Construye el mensaje de resultado
        string resultado = $"Identificacion: {identificacion}, Sede: {sedeValida ?? "No válido"}, Contacto: {contactoValido}, Estado: {estadoSeleccion}, Provincia: {estadoCheckBoxString}";

        return resultado;
    }

    public static string ValidarSeleccion(string seleccion)
    {
        // Expresión regular para verificar que la cadena tenga entre 1 y 100 caracteres
        Regex r = new Regex("^.{{1,100}}$");

        // Si la selección es nula o vacía, retorna "No válido"
        if (string.IsNullOrEmpty(seleccion))
        {
            return "No válido";
        }
        // Si la selección no cumple con la expresión regular, retorna "No válido"
        else if (!r.IsMatch(seleccion))
        {
            return "No válido";
        }
        // Si la selección cumple con todos los criterios, retorna el valor de la selección
        else
        {
            return seleccion;
        }
    }

    public static string ValidarEstado(bool estado)
        {
            // Retorna "Activo" si el estado es verdadero, "Inactivo" en caso contrario
            return estado ? "Activo" : "Inactivo";
        }

    public static string SedeCorrecta(string sede)
    {
        return string.IsNullOrEmpty(sede) ? "No válido" : sede;
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
        { // Muestra un mensaje de error si el contacto no es válido
            MessageBox.Show("El contacto debe tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "No válido"; // Retorna null si el contacto no es válido
        }
    }

    public void EscribirDatosEnArchivo(string IDE, string Nombre_Sede, string Contacto, string seleccionComboBox, bool estadoCheckBox)
    {
        LeerEscribir.EscribirDatosEnArchivoCentro(IDE, Nombre_Sede, Contacto, seleccionComboBox, estadoCheckBox);
    }

    public string VerificaIde(string IDE)
    {
        // Ruta del archivo donde se almacenan los códigos
        string rutaArchivo = Path.Combine(Application.StartupPath, "Centros.txt");

        // Verifica si el archivo existe, si no, crea uno vacío
        if (!File.Exists(rutaArchivo))
        {
            File.Create(rutaArchivo).Close(); // Crea el archivo si no existe
        }

        // Lee el archivo y almacena los códigos en un HashSet para evitar duplicados
        HashSet<string> codigosExistentes = new HashSet<string>();
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                // Suponiendo que el código está en la primera columna del archivo 
                codigosExistentes.Add(linea.Split(',')[0]);
            }
        }

        // Verifica si el nuevo código ya existe en el HashSet
        if (codigosExistentes.Contains(IDE))
        {
            // Si el código ya existe, muestra un mensaje de error y retorna "No válido"
            MessageBox.Show("El código ya existe. Por favor, ingrese un código diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "No válido";
        }
        else
        {
            // Si el código no existe, retorna "Válido"
            return IDE;
        }
    }
}

