namespace SaludDental
{
    partial class Ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            btnIngresar = new Button();
            btnCancelar = new Button();
            gbDatosIngreso = new GroupBox();
            lblUsuario = new Label();
            lblClave = new Label();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            gbDatosIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 255, 192);
            btnIngresar.Dock = DockStyle.Bottom;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(0, 304);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(797, 57);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Dock = DockStyle.Bottom;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(0, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(797, 57);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDatosIngreso
            // 
            gbDatosIngreso.Controls.Add(lblUsuario);
            gbDatosIngreso.Controls.Add(lblClave);
            gbDatosIngreso.Controls.Add(txtClave);
            gbDatosIngreso.Controls.Add(txtUsuario);
            gbDatosIngreso.Location = new Point(329, 40);
            gbDatosIngreso.Name = "gbDatosIngreso";
            gbDatosIngreso.Size = new Size(468, 182);
            gbDatosIngreso.TabIndex = 6;
            gbDatosIngreso.TabStop = false;
            gbDatosIngreso.Text = "Datos Ingreso";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(41, 63);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(41, 106);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 6;
            lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(127, 98);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(268, 23);
            txtClave.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(127, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(268, 23);
            txtUsuario.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 361);
            Controls.Add(pictureBox1);
            Controls.Add(gbDatosIngreso);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Ingreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += Ingreso_Load;
            gbDatosIngreso.ResumeLayout(false);
            gbDatosIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
        private Button btnCancelar;
        private GroupBox gbDatosIngreso;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
    }
}