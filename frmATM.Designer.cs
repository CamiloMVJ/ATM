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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttIngresar = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.MaskedTextBox();
            this.txtNumCuenta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 25);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
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
            this.groupBox1.Size = new System.Drawing.Size(555, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion requerida";
            // 
            // buttIngresar
            // 
            this.buttIngresar.AutoSize = true;
            this.buttIngresar.Location = new System.Drawing.Point(422, 86);
            this.buttIngresar.Name = "buttIngresar";
            this.buttIngresar.Size = new System.Drawing.Size(75, 27);
            this.buttIngresar.TabIndex = 3;
            this.buttIngresar.Text = "Ingresar";
            this.buttIngresar.UseVisualStyleBackColor = true;
            this.buttIngresar.Click += new System.EventHandler(this.buttIngresar_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(422, 45);
            this.txtPIN.Mask = "99999999999999999999999999999999999999999";
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(100, 25);
            this.txtPIN.TabIndex = 6;
            this.txtPIN.ValidatingType = typeof(int);
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(134, 84);
            this.txtNumCuenta.Mask = "99999999999999999999999999999999999";
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(100, 25);
            this.txtNumCuenta.TabIndex = 5;
            this.txtNumCuenta.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco ATM";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(35, 265);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 207);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero de Cuenta";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Balance";
            this.columnHeader3.Width = 120;
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}