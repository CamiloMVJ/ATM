namespace pjATM
{
    partial class frmATM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmATM));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttIngresar = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.MaskedTextBox();
            this.txtNumCuenta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.checkDeposito = new System.Windows.Forms.CheckBox();
            this.checkRetiro = new System.Windows.Forms.CheckBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.buttRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvTransacciones = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.gbAcciones2 = new System.Windows.Forms.GroupBox();
            this.txtOpcion = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAccion = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.gbAcciones2.SuspendLayout();
            this.gbAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(178, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 25);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttIngresar);
            this.groupBox1.Controls.Add(this.txtPIN);
            this.groupBox1.Controls.Add(this.txtNumCuenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion requerida";
            // 
            // buttIngresar
            // 
            this.buttIngresar.AutoSize = true;
            this.buttIngresar.Location = new System.Drawing.Point(476, 84);
            this.buttIngresar.Name = "buttIngresar";
            this.buttIngresar.Size = new System.Drawing.Size(75, 27);
            this.buttIngresar.TabIndex = 3;
            this.buttIngresar.Text = "Ingresar";
            this.buttIngresar.UseVisualStyleBackColor = true;
            this.buttIngresar.Click += new System.EventHandler(this.buttIngresar_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(476, 43);
            this.txtPIN.Mask = "99999999999999999999999999999999999999999";
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(100, 25);
            this.txtPIN.TabIndex = 6;
            this.txtPIN.ValidatingType = typeof(int);
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(178, 86);
            this.txtNumCuenta.Mask = "99999999999999999999999999999999999";
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(100, 25);
            this.txtNumCuenta.TabIndex = 5;
            this.txtNumCuenta.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco ATM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvInfo.GridLines = true;
            this.lvInfo.Location = new System.Drawing.Point(35, 406);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(639, 80);
            this.lvInfo.TabIndex = 3;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero de Cuenta";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Balance";
            this.columnHeader3.Width = 200;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.checkDeposito);
            this.gbAcciones.Controls.Add(this.checkRetiro);
            this.gbAcciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbAcciones.Location = new System.Drawing.Point(963, 182);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbAcciones.Size = new System.Drawing.Size(290, 155);
            this.gbAcciones.TabIndex = 4;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            this.gbAcciones.Visible = false;
            // 
            // checkDeposito
            // 
            this.checkDeposito.AutoSize = true;
            this.checkDeposito.Location = new System.Drawing.Point(6, 59);
            this.checkDeposito.Name = "checkDeposito";
            this.checkDeposito.Size = new System.Drawing.Size(81, 21);
            this.checkDeposito.TabIndex = 1;
            this.checkDeposito.Text = "Deposito";
            this.checkDeposito.UseVisualStyleBackColor = true;
            // 
            // checkRetiro
            // 
            this.checkRetiro.AutoSize = true;
            this.checkRetiro.Location = new System.Drawing.Point(6, 32);
            this.checkRetiro.Name = "checkRetiro";
            this.checkRetiro.Size = new System.Drawing.Size(63, 21);
            this.checkRetiro.TabIndex = 0;
            this.checkRetiro.Text = "Retiro";
            this.checkRetiro.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(80, 42);
            this.txtMonto.Mask = "99999999999999999999999999999999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 25);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // buttRegistrar
            // 
            this.buttRegistrar.AutoSize = true;
            this.buttRegistrar.Location = new System.Drawing.Point(197, 40);
            this.buttRegistrar.Name = "buttRegistrar";
            this.buttRegistrar.Size = new System.Drawing.Size(75, 27);
            this.buttRegistrar.TabIndex = 4;
            this.buttRegistrar.Text = "Registrar";
            this.buttRegistrar.UseVisualStyleBackColor = true;
            this.buttRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monto";
            // 
            // lvTransacciones
            // 
            this.lvTransacciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvTransacciones.GridLines = true;
            this.lvTransacciones.Location = new System.Drawing.Point(1121, 74);
            this.lvTransacciones.Name = "lvTransacciones";
            this.lvTransacciones.Size = new System.Drawing.Size(306, 263);
            this.lvTransacciones.TabIndex = 5;
            this.lvTransacciones.UseCompatibleStateImageBehavior = false;
            this.lvTransacciones.View = System.Windows.Forms.View.Details;
            this.lvTransacciones.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Monto";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cuenta";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Accion";
            this.columnHeader7.Width = 100;
            // 
            // gbAcciones2
            // 
            this.gbAcciones2.Controls.Add(this.txtOpcion);
            this.gbAcciones2.Controls.Add(this.label10);
            this.gbAcciones2.Controls.Add(this.label11);
            this.gbAcciones2.Controls.Add(this.label7);
            this.gbAcciones2.Controls.Add(this.label9);
            this.gbAcciones2.Controls.Add(this.label8);
            this.gbAcciones2.Controls.Add(this.label6);
            this.gbAcciones2.Location = new System.Drawing.Point(35, 241);
            this.gbAcciones2.Name = "gbAcciones2";
            this.gbAcciones2.Size = new System.Drawing.Size(290, 133);
            this.gbAcciones2.TabIndex = 6;
            this.gbAcciones2.TabStop = false;
            this.gbAcciones2.Text = "Acciones";
            this.gbAcciones2.Visible = false;
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(172, 32);
            this.txtOpcion.Mask = "99999999999999999999999999";
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(100, 25);
            this.txtOpcion.TabIndex = 7;
            this.txtOpcion.ValidatingType = typeof(int);
            this.txtOpcion.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Salir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "3.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mostrar saldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "2.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Retiro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "1.";
            // 
            // gbAccion
            // 
            this.gbAccion.Controls.Add(this.buttRegistrar);
            this.gbAccion.Controls.Add(this.txtMonto);
            this.gbAccion.Controls.Add(this.label5);
            this.gbAccion.Location = new System.Drawing.Point(384, 241);
            this.gbAccion.Name = "gbAccion";
            this.gbAccion.Size = new System.Drawing.Size(290, 133);
            this.gbAccion.TabIndex = 7;
            this.gbAccion.TabStop = false;
            this.gbAccion.Text = "Retiro";
            this.gbAccion.Visible = false;
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(731, 554);
            this.Controls.Add(this.gbAccion);
            this.Controls.Add(this.gbAcciones2);
            this.Controls.Add(this.lvTransacciones);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.gbAcciones2.ResumeLayout(false);
            this.gbAcciones2.PerformLayout();
            this.gbAccion.ResumeLayout(false);
            this.gbAccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttIngresar;
        private MaskedTextBox txtPIN;
        private MaskedTextBox txtNumCuenta;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView lvInfo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox gbAcciones;
        private Label label5;
        private CheckBox checkDeposito;
        private CheckBox checkRetiro;
        private Button buttRegistrar;
        private MaskedTextBox txtMonto;
        private ListView lvTransacciones;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private GroupBox gbAcciones2;
        private Label label10;
        private Label label11;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label6;
        private MaskedTextBox txtOpcion;
        private GroupBox gbAccion;
    }
}