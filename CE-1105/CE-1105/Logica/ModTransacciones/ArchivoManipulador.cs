using CE_1105.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica.ModTransacciones
{
    public class ArchivoManipulador
    {
        public void ModificarBilletera(string carnet, double total, string estado)
        {
            // Implementación para modificar la billetera
            string fileName = "Billeteras.txt";
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    var data = lines[i].Split(',');
                    if (data[0] == carnet)
                    {
                        double currentTotal = double.Parse(data[1]);
                        currentTotal -= total;
                        lines[i] = $"{carnet},{currentTotal}";
                        File.WriteAllLines(fileName, lines);
                        return;
                    }
                }
            }
        }

        public void ModificarTransferenciaCentro(string id, string estado)
        {
            // Implementación para modificar la transferencia del centro
            string fileName = "TransaccionCentro.txt";
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    var data = lines[i].Split(',');
                    if (data[0].Substring(2) == id)
                    {
                        data[3] = estado; // Asumiendo que la columna 4 es la columna de estado
                        lines[i] = string.Join(",", data);
                        File.WriteAllLines(fileName, lines);
                        return;
                    }
                }
            }
        }

        public string ObtenerCarnetPorId(string id)
        {
            // Implementación para obtener el carnet por id
            string fileName = "TransaccionEstudiante.txt";
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data[0].Substring(2) == id)
                    {
                        return data[1];
                    }
                }
            }
            return null;
        }
    }
}

