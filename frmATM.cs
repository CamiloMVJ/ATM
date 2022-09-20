namespace pjATM
{
    public partial class frmATM : Form
    {
        public Cuenta cliente = new Cuenta();
        public frmATM()
        {
            InitializeComponent();
            
        }

        private void buttIngresar_Click(object sender, EventArgs e)
        {
            int numCuenta = int.Parse(txtNumCuenta.Text);
            int PIN = int.Parse(txtPIN.Text);
            bool validacion = cliente.Validar(numCuenta, PIN);
            if (validacion)
                MessageBox.Show("Cuenta Valida!", "Anuncio", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void frmATM_Load(object sender, EventArgs e)
        {
            cliente.Balance = 500;
            cliente.PIN = 12345;
            cliente.NumCuenta = 54321;
            cliente.Nombre = "Camilo Javier";
        }
    }
}