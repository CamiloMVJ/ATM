namespace pjATM
{
    public partial class frmATM : Form
    {
        public Cuenta cliente = new Cuenta();
        public ATM ATM = new ATM();
        int num = 0;
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

                ListViewInfo();

                gbAcciones.Visible = true;
                lvInfo.Visible = true;
                lvTransacciones.Visible = true;
            }
            else
            {
                MessageBox.Show("Informacion ingresada no valida, Intente de nuevo", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ATM.Monto = double.Parse(txtMonto.Text); ATM.ValidarNum();
            if (checkRetiro.Checked && checkDeposito.Checked)
            {
                MessageBox.Show("Seleccione solo un metodo", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkDeposito.Checked = false;
                checkRetiro.Checked = false;
            }
            else if (checkRetiro.Checked)
            {
                if (cliente.Balance >= ATM.Monto)
                {
                    if (ATM.Balance >= ATM.Monto)
                    {
                        ATM.Retirar();
                        lvInfo.Items.Clear();
                        ListViewInfo();
                        MessageBox.Show("Retiro completado", "Notificacion");
                        ListViewTrans();
                    }
                    else
                    {
                        MessageBox.Show("El cajero no cuenta con dinero suficiente, favor ingrese un monto inferior", "Notificacion", MessageBoxButtons.OK);
                    }
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
                ListViewInfo();
                MessageBox.Show("Deposito exitoso", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewTrans();
            }
        }
        public void ListViewInfo()
        {
            ListViewItem info = new ListViewItem(cliente.Nombre);
            info.SubItems.Add(cliente.NumCuenta.ToString());
            info.SubItems.Add(cliente.Balance.ToString());
            lvInfo.Items.Add(info);
        }

        public void ListViewTrans()
        {
            String accion = "";
            ListViewItem trans = new ListViewItem(num.ToString());
            trans.SubItems.Add(txtMonto.Text);
            trans.SubItems.Add(cliente.NumCuenta.ToString());
            if (checkDeposito.Checked)
                accion = "Deposito";
            else if (checkRetiro.Checked)
                accion = "Retiro";
            trans.SubItems.Add(accion);
            lvTransacciones.Items.Add(trans);
            num++;
        }
    }
}