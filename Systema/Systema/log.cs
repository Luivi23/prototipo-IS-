namespace prototipo_progra
{
    public partial class Bloqueo : Form
    {
        public Bloqueo()
        {
            InitializeComponent();
        }

        private void BtnLogInicio_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.Show();

            this.Hide();
        }
    }
}
