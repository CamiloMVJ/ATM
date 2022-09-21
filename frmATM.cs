namespace pjATM
{
    public partial class frmATM : Form
    {
        public Cuenta cliente = new Cuenta();
        public ATM ATM = new ATM();
        public frmATM()
        {
            InitializeComponent();

        }

        private void buttIngresar_Click(object sender, EventArgs e)
        {
            int numCuenta = int.Parse(txtNumCuenta.Text);
            int PIN = int.Parse(txtPIN.Text);
            String nombre = txtNombre.Text;
            bool validacion = cliente.Validar(numCuenta, PIN, nombre);
            if (validacion)
            {
                MessageBox.Show("¡Cuenta Valida!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListView();

                gbAcciones.Visible = true;
                lvInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Informacion ingresada no valida", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPIN.Clear();
                txtNumCuenta.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                gbAcciones.Visible = false;
                lvInfo.Visible = false;
            }

        }
        private void frmATM_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al cajero ATM, Ingrese sus datos", "Bienvenida", MessageBoxButtons.OK);
            cliente.Balance = 6000;
            cliente.PIN = 1234;
            cliente.NumCuenta = 54321;
            cliente.Nombre = "Camilo Javier";

            ATM.Balance = 5000;
            ATM.Cuenta = cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtMonto.Text) < 0)
                ATM.Monto = double.Parse(txtMonto.Text) * -1;
            else
                ATM.Monto = double.Parse(txtMonto.Text);
            
            if (checkRetiro.Checked && checkDeposito.Checked)
            {
                MessageBox.Show("Seleccione solo un metodo", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkDeposito.Checked = false;
                checkRetiro.Checked = false;
            }
            else if (checkRetiro.Checked)
            {
                if (cliente.Balance >= ATM.Monto && ATM.Balance >= ATM.Monto)
                {
                    ATM.Retirar();
                    lvInfo.Items.Clear();
                    ListView();
                    MessageBox.Show("Retiro completado", "Notificacion");
                }
                else
                {
                    MessageBox.Show("No posee suficiente saldo, favor ingrese un monto inferior", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Clear();
                    txtMonto.Focus();
                }
            }
            else if (checkDeposito.Checked)
            {
                ATM.Depositar();
                lvInfo.Items.Clear();
                ListView();
                MessageBox.Show("Deposito exitoso", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ListView()
        {
            ListViewItem info = new ListViewItem(cliente.Nombre);
            info.SubItems.Add(cliente.NumCuenta.ToString());
            info.SubItems.Add(cliente.Balance.ToString());
            lvInfo.Items.Add(info);
        }
    }
}