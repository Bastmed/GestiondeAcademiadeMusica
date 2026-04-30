namespace GestiondeAcademiadeMusica.Forms.Profesores
{
    partial class AgregarProfesor
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            lblNombreAgrPro = new Label();
            lblApellidoAgrPro = new Label();
            lblTelefonoAgrPro = new Label();
            lblEmailAgrPro = new Label();
            cmbEspecialidad = new ComboBox();
            lblEspecialidadAgrPro = new Label();
            lblTarifaAgrPro = new Label();
            txtTarifa = new TextBox();
            lblActivoAgrPro = new Label();
            chkActivo = new CheckBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 80);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(57, 140);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(110, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(57, 207);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 267);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblNombreAgrPro
            // 
            lblNombreAgrPro.AutoSize = true;
            lblNombreAgrPro.Location = new Point(60, 40);
            lblNombreAgrPro.Name = "lblNombreAgrPro";
            lblNombreAgrPro.Size = new Size(54, 15);
            lblNombreAgrPro.TabIndex = 4;
            lblNombreAgrPro.Text = "Nombre:";
            // 
            // lblApellidoAgrPro
            // 
            lblApellidoAgrPro.AutoSize = true;
            lblApellidoAgrPro.Location = new Point(59, 112);
            lblApellidoAgrPro.Name = "lblApellidoAgrPro";
            lblApellidoAgrPro.Size = new Size(54, 15);
            lblApellidoAgrPro.TabIndex = 5;
            lblApellidoAgrPro.Text = "Apellido:";
            // 
            // lblTelefonoAgrPro
            // 
            lblTelefonoAgrPro.AutoSize = true;
            lblTelefonoAgrPro.Location = new Point(57, 179);
            lblTelefonoAgrPro.Name = "lblTelefonoAgrPro";
            lblTelefonoAgrPro.Size = new Size(56, 15);
            lblTelefonoAgrPro.TabIndex = 6;
            lblTelefonoAgrPro.Text = "Telefono:";
            // 
            // lblEmailAgrPro
            // 
            lblEmailAgrPro.AutoSize = true;
            lblEmailAgrPro.Location = new Point(57, 242);
            lblEmailAgrPro.Name = "lblEmailAgrPro";
            lblEmailAgrPro.Size = new Size(39, 15);
            lblEmailAgrPro.TabIndex = 7;
            lblEmailAgrPro.Text = "Email:";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "Guitarra Clásica", "Guitarra Eléctrica", "Bajo Eléctrico", "Piano", "Violín", "Violoncello", "Contrabajo", "Flauta Traversa", "Clarinete", "Saxofón", "Trompeta", "Trombón", "Percusión Clásica", "Batería", "Arpa", "Canto Lírico", "Canto Popular", "Charango", "Quena", "Teoría Musical y Solfeo", "Composición", "Dirección Coral" });
            cmbEspecialidad.Location = new Point(254, 78);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(133, 23);
            cmbEspecialidad.TabIndex = 8;
            // 
            // lblEspecialidadAgrPro
            // 
            lblEspecialidadAgrPro.AutoSize = true;
            lblEspecialidadAgrPro.Location = new Point(254, 40);
            lblEspecialidadAgrPro.Name = "lblEspecialidadAgrPro";
            lblEspecialidadAgrPro.Size = new Size(75, 15);
            lblEspecialidadAgrPro.TabIndex = 9;
            lblEspecialidadAgrPro.Text = "Especialidad:";
            // 
            // lblTarifaAgrPro
            // 
            lblTarifaAgrPro.AutoSize = true;
            lblTarifaAgrPro.Location = new Point(455, 40);
            lblTarifaAgrPro.Name = "lblTarifaAgrPro";
            lblTarifaAgrPro.Size = new Size(39, 15);
            lblTarifaAgrPro.TabIndex = 10;
            lblTarifaAgrPro.Text = "Tarifa:";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(447, 79);
            txtTarifa.Margin = new Padding(3, 2, 3, 2);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(110, 23);
            txtTarifa.TabIndex = 11;
            // 
            // lblActivoAgrPro
            // 
            lblActivoAgrPro.AutoSize = true;
            lblActivoAgrPro.Location = new Point(447, 140);
            lblActivoAgrPro.Name = "lblActivoAgrPro";
            lblActivoAgrPro.Size = new Size(44, 15);
            lblActivoAgrPro.TabIndex = 12;
            lblActivoAgrPro.Text = "Activo:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(455, 166);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 13;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(447, 220);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 22);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // AgregarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnEnviar);
            Controls.Add(chkActivo);
            Controls.Add(lblActivoAgrPro);
            Controls.Add(txtTarifa);
            Controls.Add(lblTarifaAgrPro);
            Controls.Add(lblEspecialidadAgrPro);
            Controls.Add(cmbEspecialidad);
            Controls.Add(lblEmailAgrPro);
            Controls.Add(lblTelefonoAgrPro);
            Controls.Add(lblApellidoAgrPro);
            Controls.Add(lblNombreAgrPro);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbEspecialidad;
        private Label label5;
        private Label label6;
        private TextBox txtTarifa;
        private Label label7;
        private CheckBox chkActivo;
        private Button btnEnviar;
        private Label lblNombreAgrPro;
        private Label lblApellidoAgrPro;
        private Label lblTelefonoAgrPro;
        private Label lblEmailAgrPro;
        private Label lblEspecialidadAgrPro;
        private Label lblTarifaAgrPro;
        private Label lblActivoAgrPro;
    }
}