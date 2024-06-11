using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CE_1105;
using CE_1105.Logica;

namespace CE_1105.Interfaz
{
    public partial class ValidacionUsuarios : Form
    {
        public ValidacionUsuarios()
        {
            InitializeComponent();
            //Maneja el evento de cerrarse del formulario
            this.FormClosing += new FormClosingEventHandler(ValidacionUsuarios_FormClosing);
        }
        //Método para enviar los parámetros para verificar los datos recibidos
        private void BotonVerificacion_Click(object sender, EventArgs e)
        {
            string usuario, contrasena;
            // Datos para enviar a validar 
            usuario = datoUsuario.Text;
            contrasena = datoContrasena.Text;
            // Llamada de método para enviar los datos para la lógica de credenciales
            ValidacionesSistema.Validacion(usuario, contrasena, this);
        }
        //Garantiza que el sistema sí se cerrará cuando se presione la X
        private void ValidacionUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

