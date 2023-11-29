namespace SaludDental
{
    partial class IngresoDatosProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoDatosProyecto));
            tbIngresoConvocatoria = new TabControl();
            tbDatosBasicos = new TabPage();
            gbDatosConvocatoria = new GroupBox();
            txtEnteFinanciero = new TextBox();
            lblEnteFinanciero = new Label();
            txtLineaInvestigacion = new TextBox();
            lblLineaInvestigacion = new Label();
            txtGrupoInvestigacion = new TextBox();
            lblGrupoInvestigacion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblConvocatoria = new Label();
            lblEntidadesCooperantes = new Label();
            txtConvocatoria = new TextBox();
            txtEntidadesCooperantes = new TextBox();
            tbIngresoConvocatoria.SuspendLayout();
            tbDatosBasicos.SuspendLayout();
            gbDatosConvocatoria.SuspendLayout();
            SuspendLayout();
            // 
            // tbIngresoConvocatoria
            // 
            tbIngresoConvocatoria.Controls.Add(tbDatosBasicos);
            tbIngresoConvocatoria.Location = new Point(12, 12);
            tbIngresoConvocatoria.Name = "tbIngresoConvocatoria";
            tbIngresoConvocatoria.SelectedIndex = 0;
            tbIngresoConvocatoria.Size = new Size(776, 462);
            tbIngresoConvocatoria.TabIndex = 1;
            // 
            // tbDatosBasicos
            // 
            tbDatosBasicos.BackColor = Color.White;
            tbDatosBasicos.BackgroundImage = (Image)resources.GetObject("tbDatosBasicos.BackgroundImage");
            tbDatosBasicos.Controls.Add(gbDatosConvocatoria);
            tbDatosBasicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbDatosBasicos.Location = new Point(4, 24);
            tbDatosBasicos.Name = "tbDatosBasicos";
            tbDatosBasicos.Padding = new Padding(3);
            tbDatosBasicos.Size = new Size(768, 434);
            tbDatosBasicos.TabIndex = 0;
            tbDatosBasicos.Text = "Datos Proyecto";
            // 
            // gbDatosConvocatoria
            // 
            gbDatosConvocatoria.BackgroundImage = (Image)resources.GetObject("gbDatosConvocatoria.BackgroundImage");
            gbDatosConvocatoria.Controls.Add(txtEntidadesCooperantes);
            gbDatosConvocatoria.Controls.Add(txtConvocatoria);
            gbDatosConvocatoria.Controls.Add(lblEntidadesCooperantes);
            gbDatosConvocatoria.Controls.Add(lblConvocatoria);
            gbDatosConvocatoria.Controls.Add(txtEnteFinanciero);
            gbDatosConvocatoria.Controls.Add(lblEnteFinanciero);
            gbDatosConvocatoria.Controls.Add(txtLineaInvestigacion);
            gbDatosConvocatoria.Controls.Add(lblLineaInvestigacion);
            gbDatosConvocatoria.Controls.Add(txtGrupoInvestigacion);
            gbDatosConvocatoria.Controls.Add(lblGrupoInvestigacion);
            gbDatosConvocatoria.Controls.Add(txtNombre);
            gbDatosConvocatoria.Controls.Add(lblNombre);
            gbDatosConvocatoria.Location = new Point(5, 9);
            gbDatosConvocatoria.Name = "gbDatosConvocatoria";
            gbDatosConvocatoria.Size = new Size(758, 363);
            gbDatosConvocatoria.TabIndex = 0;
            gbDatosConvocatoria.TabStop = false;
            // 
            // txtEnteFinanciero
            // 
            txtEnteFinanciero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnteFinanciero.Location = new Point(187, 211);
            txtEnteFinanciero.MaxLength = 100;
            txtEnteFinanciero.Name = "txtEnteFinanciero";
            txtEnteFinanciero.Size = new Size(436, 29);
            txtEnteFinanciero.TabIndex = 7;
            // 
            // lblEnteFinanciero
            // 
            lblEnteFinanciero.AutoSize = true;
            lblEnteFinanciero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnteFinanciero.Location = new Point(31, 214);
            lblEnteFinanciero.Name = "lblEnteFinanciero";
            lblEnteFinanciero.Size = new Size(126, 21);
            lblEnteFinanciero.TabIndex = 6;
            lblEnteFinanciero.Text = "Ente financiero";
            // 
            // txtLineaInvestigacion
            // 
            txtLineaInvestigacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineaInvestigacion.Location = new Point(237, 157);
            txtLineaInvestigacion.MaxLength = 100;
            txtLineaInvestigacion.Name = "txtLineaInvestigacion";
            txtLineaInvestigacion.Size = new Size(386, 29);
            txtLineaInvestigacion.TabIndex = 5;
            // 
            // lblLineaInvestigacion
            // 
            lblLineaInvestigacion.AutoSize = true;
            lblLineaInvestigacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLineaInvestigacion.Location = new Point(31, 165);
            lblLineaInvestigacion.Name = "lblLineaInvestigacion";
            lblLineaInvestigacion.Size = new Size(181, 21);
            lblLineaInvestigacion.TabIndex = 4;
            lblLineaInvestigacion.Text = "Línea de investigación";
            // 
            // txtGrupoInvestigacion
            // 
            txtGrupoInvestigacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGrupoInvestigacion.Location = new Point(237, 99);
            txtGrupoInvestigacion.MaxLength = 100;
            txtGrupoInvestigacion.Name = "txtGrupoInvestigacion";
            txtGrupoInvestigacion.Size = new Size(386, 29);
            txtGrupoInvestigacion.TabIndex = 3;
            // 
            // lblGrupoInvestigacion
            // 
            lblGrupoInvestigacion.AutoSize = true;
            lblGrupoInvestigacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrupoInvestigacion.Location = new Point(31, 107);
            lblGrupoInvestigacion.Name = "lblGrupoInvestigacion";
            lblGrupoInvestigacion.Size = new Size(187, 21);
            lblGrupoInvestigacion.TabIndex = 2;
            lblGrupoInvestigacion.Text = "Grupo de investigación";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(187, 43);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(436, 29);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(31, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblConvocatoria
            // 
            lblConvocatoria.AutoSize = true;
            lblConvocatoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConvocatoria.Location = new Point(31, 269);
            lblConvocatoria.Name = "lblConvocatoria";
            lblConvocatoria.Size = new Size(112, 21);
            lblConvocatoria.TabIndex = 8;
            lblConvocatoria.Text = "Convocatoria";
            // 
            // lblEntidadesCooperantes
            // 
            lblEntidadesCooperantes.AutoSize = true;
            lblEntidadesCooperantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntidadesCooperantes.Location = new Point(31, 318);
            lblEntidadesCooperantes.Name = "lblEntidadesCooperantes";
            lblEntidadesCooperantes.Size = new Size(183, 21);
            lblEntidadesCooperantes.TabIndex = 9;
            lblEntidadesCooperantes.Text = "Entidades cooperantes";
            // 
            // txtConvocatoria
            // 
            txtConvocatoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtConvocatoria.Location = new Point(187, 261);
            txtConvocatoria.MaxLength = 100;
            txtConvocatoria.Name = "txtConvocatoria";
            txtConvocatoria.Size = new Size(436, 29);
            txtConvocatoria.TabIndex = 10;
            // 
            // txtEntidadesCooperantes
            // 
            txtEntidadesCooperantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEntidadesCooperantes.Location = new Point(237, 310);
            txtEntidadesCooperantes.MaxLength = 100;
            txtEntidadesCooperantes.Name = "txtEntidadesCooperantes";
            txtEntidadesCooperantes.Size = new Size(386, 29);
            txtEntidadesCooperantes.TabIndex = 11;
            // 
            // IngresoDatosProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbIngresoConvocatoria);
            Name = "IngresoDatosProyecto";
            Text = "IngresoDatosProyecto";
            tbIngresoConvocatoria.ResumeLayout(false);
            tbDatosBasicos.ResumeLayout(false);
            gbDatosConvocatoria.ResumeLayout(false);
            gbDatosConvocatoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbIngresoConvocatoria;
        private TabPage tbDatosBasicos;
        private GroupBox gbDatosConvocatoria;
        private TextBox txtEnteFinanciero;
        private Label lblEnteFinanciero;
        private TextBox txtLineaInvestigacion;
        private Label lblLineaInvestigacion;
        private TextBox txtGrupoInvestigacion;
        private Label lblGrupoInvestigacion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtEntidadesCooperantes;
        private TextBox txtConvocatoria;
        private Label lblEntidadesCooperantes;
        private Label lblConvocatoria;
    }
}