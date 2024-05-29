using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica
{
    public class ManejoMaterial
    {
        public static void GuardarMaterial(Material material, string filePath = "prueba_material.txt")//Llamar el archivo donde estan guardados los materiales
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string textToSave = $"{material.Id},{material.Nombre},{material.Unidad},{material.ValorUnitario},{material.Estado},{material.FechaCreacion},{material.Descripcion}";
                    writer.WriteLine(textToSave);
                }
                MessageBox.Show("Material guardado exitosamente en " + filePath, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el material: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
