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
        public void ModificarBilletera(string carnet, double total, string idEstado)
        {
            string[] billeteraLines = File.ReadAllLines("Billeteras.txt");
            List<string> newBilleteraLines = new List<string>();

            foreach (string line in billeteraLines)
            {
                string[] data = line.Split(',');
                if (data[0] == carnet)
                {
                    double currentTotal = double.Parse(data[1]);
                    if (total > currentTotal)
                    {
                        throw new Exception("El rebajo no se puede hacer porque el total es mayor a la cantidad disponible.");
                    }
                    data[1] = ((currentTotal - total).ToString());
                }
                newBilleteraLines.Add(string.Join(", ", data));
            }

            File.WriteAllLines("Billeteras.txt", newBilleteraLines);
        }

        public void ModificarTransferenciaCentro(string id, string estado)
        {
            string[] transferenciaLines = File.ReadAllLines("TransaccionCentro.txt");
            List<string> newTransferenciaLines = new List<string>();

            foreach (string line in transferenciaLines)
            {
                string[] data = line.Split(',');
                if (data[0].Substring(2) == id)
                {
                    data[3] = estado;
                }
                newTransferenciaLines.Add(string.Join(",", data));
            }

            File.WriteAllLines("TransaccionCentro.txt", newTransferenciaLines);
        }
    }
}

