namespace GestiondeAcademiadeMusica.Forms
{
    partial class AgregarAlumno
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
            lblNombreAlumno = new Label();
            txtNombreAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            lblApellidoAlumno = new Label();
            lblFechaAlumno = new Label();
            dtpFechaAlumno = new DateTimePicker();
            txtTelefonoAlumno = new TextBox();
            lblTelefonoAlumno = new Label();
            txtEmailAlumno = new TextBox();
            lblEmailAlumno = new Label();
            btnEnviar = new Button();
            chkActivoAlumno = new CheckBox();
            lblActivoAlumno = new Label();
            lblInstrumento = new Label();
            cmbInstrumentoAgr = new ComboBox();
            SuspendLayout();
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(94, 98);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(54, 15);
            lblNombreAlumno.TabIndex = 0;
            lblNombreAlumno.Text = "Nombre:";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(94, 116);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(100, 23);
            txtNombreAlumno.TabIndex = 1;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(94, 177);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(100, 23);
            txtApellidoAlumno.TabIndex = 3;
            // 
            // lblApellidoAlumno
            // 
            lblApellidoAlumno.AutoSize = true;
            lblApellidoAlumno.Location = new Point(94, 159);
            lblApellidoAlumno.Name = "lblApellidoAlumno";
            lblApellidoAlumno.Size = new Size(54, 15);
            lblApellidoAlumno.TabIndex = 2;
            lblApellidoAlumno.Text = "Apellido:";
            // 
            // lblFechaAlumno
            // 
            lblFechaAlumno.AutoSize = true;
            lblFechaAlumno.Location = new Point(94, 220);
            lblFechaAlumno.Name = "lblFechaAlumno";
            lblFechaAlumno.Size = new Size(120, 15);
            lblFechaAlumno.TabIndex = 4;
            lblFechaAlumno.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaAlumno
            // 
            dtpFechaAlumno.Location = new Point(94, 238);
            dtpFechaAlumno.Name = "dtpFechaAlumno";
            dtpFechaAlumno.Size = new Size(234, 23);
            dtpFechaAlumno.TabIndex = 6;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(94, 302);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(100, 23);
            txtTelefonoAlumno.TabIndex = 8;
            // 
            // lblTelefonoAlumno
            // 
            lblTelefonoAlumno.AutoSize = true;
            lblTelefonoAlumno.Location = new Point(94, 284);
            lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            lblTelefonoAlumno.Size = new Size(55, 15);
            lblTelefonoAlumno.TabIndex = 7;
            lblTelefonoAlumno.Text = "Telefono:";
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.Location = new Point(416, 116);
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(100, 23);
            txtEmailAlumno.TabIndex = 10;
            // 
            // lblEmailAlumno
            // 
            lblEmailAlumno.AutoSize = true;
            lblEmailAlumno.Location = new Point(416, 98);
            lblEmailAlumno.Name = "lblEmailAlumno";
            lblEmailAlumno.Size = new Size(39, 15);
            lblEmailAlumno.TabIndex = 9;
            lblEmailAlumno.Text = "Email:";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(416, 356);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 13;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // chkActivoAlumno
            // 
            chkActivoAlumno.AutoSize = true;
            chkActivoAlumno.Location = new Point(421, 184);
            chkActivoAlumno.Name = "chkActivoAlumno";
            chkActivoAlumno.Size = new Size(60, 19);
            chkActivoAlumno.TabIndex = 14;
            chkActivoAlumno.Text = "Activo";
            chkActivoAlumno.UseVisualStyleBackColor = true;
            // 
            // lblActivoAlumno
            // 
            lblActivoAlumno.AutoSize = true;
            lblActivoAlumno.Location = new Point(416, 159);
            lblActivoAlumno.Name = "lblActivoAlumno";
            lblActivoAlumno.Size = new Size(88, 15);
            lblActivoAlumno.TabIndex = 15;
            lblActivoAlumno.Text = "Alumno activo:";
            // 
            // lblInstrumento
            // 
            lblInstrumento.AutoSize = true;
            lblInstrumento.Location = new Point(416, 238);
            lblInstrumento.Name = "lblInstrumento";
            lblInstrumento.Size = new Size(75, 15);
            lblInstrumento.TabIndex = 16;
            lblInstrumento.Text = "Instrumento:";
            // 
            // cmbInstrumentoAgr
            // 
            cmbInstrumentoAgr.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInstrumentoAgr.FormattingEnabled = true;
            cmbInstrumentoAgr.Location = new Point(416, 256);
            cmbInstrumentoAgr.Name = "cmbInstrumentoAgr";
            cmbInstrumentoAgr.Size = new Size(121, 23);
            cmbInstrumentoAgr.TabIndex = 17;
            // 
            // AgregarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbInstrumentoAgr);
            Controls.Add(lblInstrumento);
            Controls.Add(lblActivoAlumno);
            Controls.Add(chkActivoAlumno);
            Controls.Add(btnEnviar);
            Controls.Add(txtEmailAlumno);
            Controls.Add(lblEmailAlumno);
            Controls.Add(txtTelefonoAlumno);
            Controls.Add(lblTelefonoAlumno);
            Controls.Add(dtpFechaAlumno);
            Controls.Add(lblFechaAlumno);
            Controls.Add(txtApellidoAlumno);
            Controls.Add(lblApellidoAlumno);
            Controls.Add(txtNombreAlumno);
            Controls.Add(lblNombreAlumno);
            Name = "AgregarAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreAlumno;
        private TextBox txtNombreAlumno;
        private TextBox txtApellidoAlumno;
        private Label lblApellidoAlumno;
        private Label lblFechaAlumno;
        private DateTimePicker dtpFechaAlumno;
        private TextBox txtTelefonoAlumno;
        private Label lblTelefonoAlumno;
        private TextBox txtEmailAlumno;
        private Label lblEmailAlumno;
        private Button btnEnviar;
        private CheckBox chkActivoAlumno;
        private Label lblActivoAlumno;
        private Label lblInstrumento;
        private ComboBox cmbInstrumentoAgr;
    }
}