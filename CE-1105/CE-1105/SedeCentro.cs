namespace CE_1105
{
    public partial class SedeCentro : Form
    {
        public SedeCentro()
        {
            InitializeComponent();
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
