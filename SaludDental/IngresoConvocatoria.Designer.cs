namespace SaludDental
{
    partial class IngresoConvocatoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbDatosPaciente = new TabControl();
            tbDatosBasicos = new TabPage();
            gbOtrosDatosBasicos = new GroupBox();
            lblTitular = new Label();
            chkTitular = new CheckBox();
            lblSexo = new Label();
            rdbNoBinario = new RadioButton();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cboTiposDocumento = new ComboBox();
            lblTiposDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            label1 = new Label();
            gbDatosBasicos = new GroupBox();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtSegundoNombre = new TextBox();
            lblSegundoNombre = new Label();
            txtPrimerNombre = new TextBox();
            lblPrimerNombre = new Label();
            tbDatosContacto = new TabPage();
            gbDatosContacto = new GroupBox();
            label2 = new Label();
            cboCiudad = new ComboBox();
            lblDepartamento = new Label();
            cboDepartamento = new ComboBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblCelular = new Label();
            txtCelular = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtSalario = new TextBox();
            lblSalario = new Label();
            tbDatosPaciente.SuspendLayout();
            tbDatosBasicos.SuspendLayout();
            gbOtrosDatosBasicos.SuspendLayout();
            gbDatosBasicos.SuspendLayout();
            tbDatosContacto.SuspendLayout();
            gbDatosContacto.SuspendLayout();
            SuspendLayout();
            // 
            // tbDatosPaciente
            // 
            tbDatosPaciente.Controls.Add(tbDatosBasicos);
            tbDatosPaciente.Controls.Add(tbDatosContacto);
            tbDatosPaciente.Location = new Point(12, 12);
            tbDatosPaciente.Name = "tbDatosPaciente";
            tbDatosPaciente.SelectedIndex = 0;
            tbDatosPaciente.Size = new Size(776, 497);
            tbDatosPaciente.TabIndex = 0;
            // 
            // tbDatosBasicos
            // 
            tbDatosBasicos.Controls.Add(gbOtrosDatosBasicos);
            tbDatosBasicos.Controls.Add(gbDatosBasicos);
            tbDatosBasicos.Location = new Point(4, 24);
            tbDatosBasicos.Name = "tbDatosBasicos";
            tbDatosBasicos.Padding = new Padding(3);
            tbDatosBasicos.Size = new Size(768, 469);
            tbDatosBasicos.TabIndex = 0;
            tbDatosBasicos.Text = "Datos Básicos";
            tbDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // gbOtrosDatosBasicos
            // 
            gbOtrosDatosBasicos.Controls.Add(txtSalario);
            gbOtrosDatosBasicos.Controls.Add(lblSalario);
            gbOtrosDatosBasicos.Controls.Add(lblTitular);
            gbOtrosDatosBasicos.Controls.Add(chkTitular);
            gbOtrosDatosBasicos.Controls.Add(lblSexo);
            gbOtrosDatosBasicos.Controls.Add(rdbNoBinario);
            gbOtrosDatosBasicos.Controls.Add(rdbFemenino);
            gbOtrosDatosBasicos.Controls.Add(rdbMasculino);
            gbOtrosDatosBasicos.Controls.Add(lblFechaNacimiento);
            gbOtrosDatosBasicos.Controls.Add(dtpFechaNacimiento);
            gbOtrosDatosBasicos.Controls.Add(cboTiposDocumento);
            gbOtrosDatosBasicos.Controls.Add(lblTiposDocumento);
            gbOtrosDatosBasicos.Controls.Add(txtNumeroDocumento);
            gbOtrosDatosBasicos.Controls.Add(label1);
            gbOtrosDatosBasicos.Location = new Point(6, 206);
            gbOtrosDatosBasicos.Name = "gbOtrosDatosBasicos";
            gbOtrosDatosBasicos.Size = new Size(761, 257);
            gbOtrosDatosBasicos.TabIndex = 1;
            gbOtrosDatosBasicos.TabStop = false;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(31, 176);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(40, 15);
            lblTitular.TabIndex = 10;
            lblTitular.Text = "Titular";
            // 
            // chkTitular
            // 
            chkTitular.AutoSize = true;
            chkTitular.Location = new Point(187, 176);
            chkTitular.Name = "chkTitular";
            chkTitular.Size = new Size(15, 14);
            chkTitular.TabIndex = 11;
            chkTitular.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(31, 139);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo";
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Location = new Point(443, 135);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(81, 19);
            rdbNoBinario.TabIndex = 9;
            rdbNoBinario.TabStop = true;
            rdbNoBinario.Text = "No Binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(316, 135);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 8;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(187, 135);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 7;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(31, 102);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(119, 15);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/mm/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(187, 96);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(436, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // cboTiposDocumento
            // 
            cboTiposDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposDocumento.FormattingEnabled = true;
            cboTiposDocumento.Items.AddRange(new object[] { "Cédula de Ciudadanía", "Cédula de Extranjería", "Tarjeta de Identidad" });
            cboTiposDocumento.Location = new Point(187, 16);
            cboTiposDocumento.Name = "cboTiposDocumento";
            cboTiposDocumento.Size = new Size(436, 23);
            cboTiposDocumento.Sorted = true;
            cboTiposDocumento.TabIndex = 1;
            // 
            // lblTiposDocumento
            // 
            lblTiposDocumento.AutoSize = true;
            lblTiposDocumento.Location = new Point(31, 19);
            lblTiposDocumento.Name = "lblTiposDocumento";
            lblTiposDocumento.Size = new Size(117, 15);
            lblTiposDocumento.TabIndex = 0;
            lblTiposDocumento.Text = "Tipos de Documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(187, 54);
            txtNumeroDocumento.MaxLength = 20;
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(436, 23);
            txtNumeroDocumento.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 57);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 2;
            label1.Text = "Número del Documento";
            // 
            // gbDatosBasicos
            // 
            gbDatosBasicos.Controls.Add(txtSegundoApellido);
            gbDatosBasicos.Controls.Add(lblSegundoApellido);
            gbDatosBasicos.Controls.Add(txtPrimerApellido);
            gbDatosBasicos.Controls.Add(lblPrimerApellido);
            gbDatosBasicos.Controls.Add(txtSegundoNombre);
            gbDatosBasicos.Controls.Add(lblSegundoNombre);
            gbDatosBasicos.Controls.Add(txtPrimerNombre);
            gbDatosBasicos.Controls.Add(lblPrimerNombre);
            gbDatosBasicos.Location = new Point(5, 9);
            gbDatosBasicos.Name = "gbDatosBasicos";
            gbDatosBasicos.Size = new Size(758, 191);
            gbDatosBasicos.TabIndex = 0;
            gbDatosBasicos.TabStop = false;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(187, 160);
            txtSegundoApellido.MaxLength = 100;
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(436, 23);
            txtSegundoApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(31, 159);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(187, 119);
            txtPrimerApellido.MaxLength = 100;
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(436, 23);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(31, 119);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(89, 15);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(187, 84);
            txtSegundoNombre.MaxLength = 100;
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(436, 23);
            txtSegundoNombre.TabIndex = 3;
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(31, 83);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(101, 15);
            lblSegundoNombre.TabIndex = 2;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(187, 43);
            txtPrimerNombre.MaxLength = 100;
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(436, 23);
            txtPrimerNombre.TabIndex = 1;
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(31, 51);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(89, 15);
            lblPrimerNombre.TabIndex = 0;
            lblPrimerNombre.Text = "Primer Nombre";
            // 
            // tbDatosContacto
            // 
            tbDatosContacto.Controls.Add(gbDatosContacto);
            tbDatosContacto.Location = new Point(4, 24);
            tbDatosContacto.Name = "tbDatosContacto";
            tbDatosContacto.Padding = new Padding(3);
            tbDatosContacto.Size = new Size(768, 438);
            tbDatosContacto.TabIndex = 1;
            tbDatosContacto.Text = "Datos de Contacto";
            tbDatosContacto.UseVisualStyleBackColor = true;
            // 
            // gbDatosContacto
            // 
            gbDatosContacto.Controls.Add(label2);
            gbDatosContacto.Controls.Add(cboCiudad);
            gbDatosContacto.Controls.Add(lblDepartamento);
            gbDatosContacto.Controls.Add(cboDepartamento);
            gbDatosContacto.Controls.Add(lblDireccion);
            gbDatosContacto.Controls.Add(txtDireccion);
            gbDatosContacto.Controls.Add(lblCelular);
            gbDatosContacto.Controls.Add(txtCelular);
            gbDatosContacto.Controls.Add(lblTelefono);
            gbDatosContacto.Controls.Add(txtTelefono);
            gbDatosContacto.Location = new Point(21, 18);
            gbDatosContacto.Name = "gbDatosContacto";
            gbDatosContacto.Size = new Size(692, 303);
            gbDatosContacto.TabIndex = 0;
            gbDatosContacto.TabStop = false;
            gbDatosContacto.Text = "Datos de Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 201);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Ciudad";
            // 
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(192, 193);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(441, 23);
            cboCiudad.TabIndex = 7;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(13, 151);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(192, 143);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(441, 23);
            cboDepartamento.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(18, 247);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(192, 239);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(446, 23);
            txtDireccion.TabIndex = 9;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(13, 94);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 2;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(187, 86);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(446, 23);
            txtCelular.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(13, 47);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(187, 47);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(446, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Dock = DockStyle.Bottom;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(0, 515);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(800, 57);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(0, 572);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(800, 57);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(187, 214);
            txtSalario.MaxLength = 100;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(436, 23);
            txtSalario.TabIndex = 13;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(31, 213);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 12;
            lblSalario.Text = "Salario";
            // 
            // DatosPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 629);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(tbDatosPaciente);
            MaximizeBox = false;
            Name = "DatosPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Paciente";
            tbDatosPaciente.ResumeLayout(false);
            tbDatosBasicos.ResumeLayout(false);
            gbOtrosDatosBasicos.ResumeLayout(false);
            gbOtrosDatosBasicos.PerformLayout();
            gbDatosBasicos.ResumeLayout(false);
            gbDatosBasicos.PerformLayout();
            tbDatosContacto.ResumeLayout(false);
            gbDatosContacto.ResumeLayout(false);
            gbDatosContacto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbDatosPaciente;
        private TabPage tbDatosBasicos;
        private GroupBox gbDatosBasicos;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private TextBox txtPrimerNombre;
        private Label lblPrimerNombre;
        private TabPage tbDatosContacto;
        private GroupBox gbDatosContacto;
        private GroupBox gbOtrosDatosBasicos;
        private Label lblTitular;
        private CheckBox chkTitular;
        private Label lblSexo;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cboTiposDocumento;
        private Label lblTiposDocumento;
        private TextBox txtNumeroDocumento;
        private Label label1;
        private Label label2;
        private ComboBox cboCiudad;
        private Label lblDepartamento;
        private ComboBox cboDepartamento;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblCelular;
        private TextBox txtCelular;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtSalario;
        private Label lblSalario;
    }
}