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

                gbAcciones2.Visible = true;
                lvTransacciones.Visible = true;
            }
            else
            {
                MessageBox.Show("Informacion ingresada no valida, Intente de nuevo", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPIN.Clear();
                txtNumCuenta.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                gbAcciones2.Visible = false;
                gbAccion.Visible = false;
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
            if (0 == 1)
            {
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
            switch (int.Parse(txtOpcion.Text))
            {
                case (int)Acciones.Retiro:
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
                        break;
                    }
                default: MessageBox.Show("Opcion no valida", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            txtMonto.Clear();
            if (txtOpcion.Text.Trim().Length != 0)
            {
                switch (int.Parse(txtOpcion.Text))
                {
                    case (int)Acciones.Retiro:
                        {
                            gbAccion.Text = "Retiro";
                            gbAccion.Visible = true;
                            break;
                        }
                    case (int)Acciones.Saldo:
                        {
                            if (gbAccion.Visible)
                            {
                                gbAccion.Visible = false;
                            }
                            lvInfo.Visible = true;
                            break;
                        }
                    case (int)Acciones.Salir:
                        {
                            DialogResult salir = MessageBox.Show("¿Esta seguro que quiere salir?", "Notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (salir == DialogResult.Yes)
                                this.Close();
                            break;
                        }
                    default: MessageBox.Show("Valor ingresado no valido", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                }
            }

        }
        internal enum Acciones
        {
            Retiro = 1,
            Saldo = 2,
            Salir = 3,
        }
    }
}