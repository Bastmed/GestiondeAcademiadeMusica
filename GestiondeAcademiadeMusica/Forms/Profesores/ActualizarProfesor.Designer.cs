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
            label5 = new Label();
            cmbEspecialidad = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            chkActivo = new CheckBox();
            label7 = new Label();
            txtTarifa = new TextBox();
            label6 = new Label();
            Guardar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 41);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 8;
            label5.Text = "Especialidad";
            label5.Click += label5_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "Canto", "Guitarra", "Piano", "Batería", "Violín" });
            cmbEspecialidad.Location = new Point(298, 92);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(151, 28);
            cmbEspecialidad.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 309);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 19;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 226);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 18;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 137);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 17;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 41);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 343);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(58, 263);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(58, 174);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(58, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 12;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(545, 208);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(18, 17);
            chkActivo.TabIndex = 23;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 174);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 22;
            label7.Text = "Activo";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(536, 92);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(125, 27);
            txtTarifa.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 41);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 20;
            label6.Text = "Tarifa";
            // 
            // Guardar
            // 
            Guardar.Location = new Point(536, 341);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(94, 29);
            Guardar.TabIndex = 24;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += btnGuardar_Click;
            // 
            // ActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Guardar);
            Controls.Add(chkActivo);
            Controls.Add(label7);
            Controls.Add(txtTarifa);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cmbEspecialidad);
            Controls.Add(label5);
            Name = "ActualizarProfesor";
            Text = "ActualizarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ComboBox cmbEspecialidad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private CheckBox chkActivo;
        private Label label7;
        private TextBox txtTarifa;
        private Label label6;
        private Button Guardar;
    }
}