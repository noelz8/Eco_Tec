namespace CE_1105
{
    public partial class SedeCentro : Form
    {
        public SedeCentro()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiFormulario_FormClosing);
        }
        private void BtnRegresar1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
        private void MiFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el cierre fue iniciado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void BCentro_Click(object sender, EventArgs e){

        }
        private void BSede_Click(object sender, EventArgs e){
        Form formulario = new Sede(this);
            formulario.Show();
            this.Hide();

        }
    }
}
