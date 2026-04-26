namespace GestiondeAcademiadeMusica.Forms.Alumnos
{
    partial class ActulizarAlumno
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
            lblActivoAlumno = new Label();
            chkActivoAlumno = new CheckBox();
            txtEmailAlumno = new TextBox();
            lblEmailAlumno = new Label();
            txtTelefonoAlumno = new TextBox();
            lblTelefonoAlumno = new Label();
            dtpFechaAlumno = new DateTimePicker();
            lblFechaAlumno = new Label();
            txtApellidoAlumno = new TextBox();
            lblApellidoAlumno = new Label();
            txtNombreAlumno = new TextBox();
            lblNombreAlumno = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblActivoAlumno
            // 
            lblActivoAlumno.AutoSize = true;
            lblActivoAlumno.Location = new Point(417, 162);
            lblActivoAlumno.Name = "lblActivoAlumno";
            lblActivoAlumno.Size = new Size(88, 15);
            lblActivoAlumno.TabIndex = 27;
            lblActivoAlumno.Text = "Alumno activo:";
            // 
            // chkActivoAlumno
            // 
            chkActivoAlumno.AutoSize = true;
            chkActivoAlumno.Location = new Point(422, 187);
            chkActivoAlumno.Name = "chkActivoAlumno";
            chkActivoAlumno.Size = new Size(60, 19);
            chkActivoAlumno.TabIndex = 26;
            chkActivoAlumno.Text = "Activo";
            chkActivoAlumno.UseVisualStyleBackColor = true;
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.Location = new Point(417, 119);
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(100, 23);
            txtEmailAlumno.TabIndex = 25;
            // 
            // lblEmailAlumno
            // 
            lblEmailAlumno.AutoSize = true;
            lblEmailAlumno.Location = new Point(417, 101);
            lblEmailAlumno.Name = "lblEmailAlumno";
            lblEmailAlumno.Size = new Size(39, 15);
            lblEmailAlumno.TabIndex = 24;
            lblEmailAlumno.Text = "Email:";
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(95, 305);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(100, 23);
            txtTelefonoAlumno.TabIndex = 23;
            // 
            // lblTelefonoAlumno
            // 
            lblTelefonoAlumno.AutoSize = true;
            lblTelefonoAlumno.Location = new Point(95, 287);
            lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            lblTelefonoAlumno.Size = new Size(55, 15);
            lblTelefonoAlumno.TabIndex = 22;
            lblTelefonoAlumno.Text = "Telefono:";
            // 
            // dtpFechaAlumno
            // 
            dtpFechaAlumno.Location = new Point(95, 241);
            dtpFechaAlumno.Name = "dtpFechaAlumno";
            dtpFechaAlumno.Size = new Size(234, 23);
            dtpFechaAlumno.TabIndex = 21;
            // 
            // lblFechaAlumno
            // 
            lblFechaAlumno.AutoSize = true;
            lblFechaAlumno.Location = new Point(95, 223);
            lblFechaAlumno.Name = "lblFechaAlumno";
            lblFechaAlumno.Size = new Size(120, 15);
            lblFechaAlumno.TabIndex = 20;
            lblFechaAlumno.Text = "Fecha de nacimiento:";
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(95, 180);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(100, 23);
            txtApellidoAlumno.TabIndex = 19;
            // 
            // lblApellidoAlumno
            // 
            lblApellidoAlumno.AutoSize = true;
            lblApellidoAlumno.Location = new Point(95, 162);
            lblApellidoAlumno.Name = "lblApellidoAlumno";
            lblApellidoAlumno.Size = new Size(54, 15);
            lblApellidoAlumno.TabIndex = 18;
            lblApellidoAlumno.Text = "Apellido:";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(95, 119);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(100, 23);
            txtNombreAlumno.TabIndex = 17;
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(95, 101);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(54, 15);
            lblNombreAlumno.TabIndex = 16;
            lblNombreAlumno.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(430, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ActulizarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(lblActivoAlumno);
            Controls.Add(chkActivoAlumno);
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
            Name = "ActulizarAlumno";
            Text = "ActulizarAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblActivoAlumno;
        private CheckBox chkActivoAlumno;
        private TextBox txtEmailAlumno;
        private Label lblEmailAlumno;
        private TextBox txtTelefonoAlumno;
        private Label lblTelefonoAlumno;
        private DateTimePicker dtpFechaAlumno;
        private Label lblFechaAlumno;
        private TextBox txtApellidoAlumno;
        private Label lblApellidoAlumno;
        private TextBox txtNombreAlumno;
        private Label lblNombreAlumno;
        private Button btnGuardar;
    }
}