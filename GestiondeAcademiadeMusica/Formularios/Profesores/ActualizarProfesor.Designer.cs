namespace GestiondeAcademiadeMusica.Forms.Profesores
{
    partial class ActualizarProfesor
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
            lblEspecialidadActProfe = new Label();
            cmbEspecialidad = new ComboBox();
            lblEmailActProfe = new Label();
            lblTelefonoActProfe = new Label();
            lblApellidoActProfe = new Label();
            lblNombreActProfe = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            chkActivo = new CheckBox();
            label7 = new Label();
            txtTarifa = new TextBox();
            lblTarifaActProfe = new Label();
            Guardar = new Button();
            SuspendLayout();
            // 
            // lblEspecialidadActProfe
            // 
            lblEspecialidadActProfe.AutoSize = true;
            lblEspecialidadActProfe.Location = new Point(261, 31);
            lblEspecialidadActProfe.Name = "lblEspecialidadActProfe";
            lblEspecialidadActProfe.Size = new Size(75, 15);
            lblEspecialidadActProfe.TabIndex = 8;
            lblEspecialidadActProfe.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "Guitarra Clásica", "Guitarra Eléctrica", "Bajo Eléctrico", "Piano", "Violín", "Violoncello", "Contrabajo", "Flauta Traversa", "Clarinete", "Saxofón", "Trompeta", "Trombón", "Percusión Clásica", "Batería", "Arpa", "Canto Lírico", "Canto Popular", "Charango", "Quena", "Teoría Musical y Solfeo", "Composición", "Dirección Coral" });
            cmbEspecialidad.Location = new Point(261, 69);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(133, 23);
            cmbEspecialidad.TabIndex = 11;
            // 
            // lblEmailActProfe
            // 
            lblEmailActProfe.AutoSize = true;
            lblEmailActProfe.Location = new Point(51, 232);
            lblEmailActProfe.Name = "lblEmailActProfe";
            lblEmailActProfe.Size = new Size(39, 15);
            lblEmailActProfe.TabIndex = 19;
            lblEmailActProfe.Text = "Email:";
            // 
            // lblTelefonoActProfe
            // 
            lblTelefonoActProfe.AutoSize = true;
            lblTelefonoActProfe.Location = new Point(51, 170);
            lblTelefonoActProfe.Name = "lblTelefonoActProfe";
            lblTelefonoActProfe.Size = new Size(56, 15);
            lblTelefonoActProfe.TabIndex = 18;
            lblTelefonoActProfe.Text = "Telefono:";
            // 
            // lblApellidoActProfe
            // 
            lblApellidoActProfe.AutoSize = true;
            lblApellidoActProfe.Location = new Point(52, 103);
            lblApellidoActProfe.Name = "lblApellidoActProfe";
            lblApellidoActProfe.Size = new Size(54, 15);
            lblApellidoActProfe.TabIndex = 17;
            lblApellidoActProfe.Text = "Apellido:";
            // 
            // lblNombreActProfe
            // 
            lblNombreActProfe.AutoSize = true;
            lblNombreActProfe.Location = new Point(52, 31);
            lblNombreActProfe.Name = "lblNombreActProfe";
            lblNombreActProfe.Size = new Size(54, 15);
            lblNombreActProfe.TabIndex = 16;
            lblNombreActProfe.Text = "Nombre:";
            lblNombreActProfe.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 257);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(51, 197);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 23);
            txtTelefono.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(51, 130);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(110, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 70);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 12;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(477, 156);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 23;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 130);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 22;
            label7.Text = "Activo:";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(469, 69);
            txtTarifa.Margin = new Padding(3, 2, 3, 2);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(110, 23);
            txtTarifa.TabIndex = 21;
            // 
            // lblTarifaActProfe
            // 
            lblTarifaActProfe.AutoSize = true;
            lblTarifaActProfe.Location = new Point(477, 31);
            lblTarifaActProfe.Name = "lblTarifaActProfe";
            lblTarifaActProfe.Size = new Size(39, 15);
            lblTarifaActProfe.TabIndex = 20;
            lblTarifaActProfe.Text = "Tarifa:";
            lblTarifaActProfe.Click += lblTarifaActProfe_Click;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(469, 256);
            Guardar.Margin = new Padding(3, 2, 3, 2);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(82, 22);
            Guardar.TabIndex = 24;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += btnGuardar_Click;
            // 
            // ActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Guardar);
            Controls.Add(chkActivo);
            Controls.Add(label7);
            Controls.Add(txtTarifa);
            Controls.Add(lblTarifaActProfe);
            Controls.Add(lblEmailActProfe);
            Controls.Add(lblTelefonoActProfe);
            Controls.Add(lblApellidoActProfe);
            Controls.Add(lblNombreActProfe);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cmbEspecialidad);
            Controls.Add(lblEspecialidadActProfe);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ActualizarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActualizarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEspecialidadActProfe;
        private ComboBox cmbEspecialidad;
        private Label lblEmailActProfe;
        private Label lblTelefonoActProfe;
        private Label lblApellidoActProfe;
        private Label lblNombreActProfe;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private CheckBox chkActivo;
        private Label label7;
        private TextBox txtTarifa;
        private Label lblTarifaActProfe;
        private Button Guardar;
    }
}