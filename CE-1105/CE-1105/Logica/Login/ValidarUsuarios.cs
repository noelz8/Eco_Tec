using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_1105.Interfaz;

namespace CE_1105.Logica.Login
{
    public class ValidacionesSistema
    {
        public static void Validacion(string datoUsuario, string datoContrasena, ValidacionUsuarios validacionUsuarios)
        {
            try
            {
                if (datoUsuario == "admin@tec.ac.cr" & datoContrasena == "1234abcd")
                {
                    VistaAdministrador vistaAdministrador = new VistaAdministrador();
                    vistaAdministrador.Show();
                    validacionUsuarios.Hide();
                }
                else if (datoUsuario == "estudiante@tec.ac.cr" & datoContrasena == "56789abcd")
                {
                    MessageBox.Show("Billetera del estudiante", "Eco-XTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (datoUsuario == "centro@tec.ac.cr" & datoContrasena == "9900abcd")
                {
                    VistaCentroAcopio vistaCentroAcopio = new VistaCentroAcopio();
                    vistaCentroAcopio.Show();
                    validacionUsuarios.Hide();
                }
                else if (string.IsNullOrWhiteSpace(datoUsuario) || string.IsNullOrWhiteSpace(datoContrasena))
                {
                    MessageBox.Show("Debe llenar los campos para continuar.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Sus credenciales son incorrectos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error presentado ocurrió por: " + ex);
                throw;
            }
        }
    }
}
