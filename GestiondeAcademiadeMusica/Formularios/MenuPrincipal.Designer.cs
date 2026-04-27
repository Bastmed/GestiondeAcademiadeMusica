namespace GestiondeAcademiadeMusica
{
    partial class MenuPrincipal
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
            components = new System.ComponentModel.Container();
            pnlMenuPrincipal = new Panel();
            pnlProfesores = new Panel();
            pnlInstrumentos = new Panel();
            btnProfesores = new Button();
            pnlAlumnos = new Panel();
            btnInstrumentos = new Button();
            btnAlumnos = new Button();
            pnlContenedor = new Panel();
            alumnoBindingSource = new BindingSource(components);
            pnlTop = new Panel();
            btnSalir = new Button();
            pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            pnlMenuPrincipal.Controls.Add(pnlProfesores);
            pnlMenuPrincipal.Controls.Add(pnlInstrumentos);
            pnlMenuPrincipal.Controls.Add(btnProfesores);
            pnlMenuPrincipal.Controls.Add(pnlAlumnos);
            pnlMenuPrincipal.Controls.Add(btnInstrumentos);
            pnlMenuPrincipal.Controls.Add(btnAlumnos);
            pnlMenuPrincipal.Dock = DockStyle.Left;
            pnlMenuPrincipal.Location = new Point(0, 0);
            pnlMenuPrincipal.Margin = new Padding(3, 4, 3, 4);
            pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            pnlMenuPrincipal.Size = new Size(176, 700);
            pnlMenuPrincipal.TabIndex = 1;
            // 
            // pnlProfesores
            // 
            pnlProfesores.BackColor = Color.DarkBlue;
            pnlProfesores.Location = new Point(0, 212);
            pnlProfesores.Margin = new Padding(3, 4, 3, 4);
            pnlProfesores.Name = "pnlProfesores";
            pnlProfesores.Size = new Size(11, 37);
            pnlProfesores.TabIndex = 4;
            // 
            // pnlInstrumentos
            // 
            pnlInstrumentos.BackColor = Color.DarkBlue;
            pnlInstrumentos.Location = new Point(0, 167);
            pnlInstrumentos.Margin = new Padding(3, 4, 3, 4);
            pnlInstrumentos.Name = "pnlInstrumentos";
            pnlInstrumentos.Size = new Size(11, 37);
            pnlInstrumentos.TabIndex = 4;
            // 
            // btnProfesores
            // 
            btnProfesores.FlatAppearance.BorderSize = 0;
            btnProfesores.FlatStyle = FlatStyle.Flat;
            btnProfesores.Location = new Point(14, 212);
            btnProfesores.Margin = new Padding(3, 4, 3, 4);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(162, 37);
            btnProfesores.TabIndex = 3;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // pnlAlumnos
            // 
            pnlAlumnos.BackColor = Color.DarkBlue;
            pnlAlumnos.Location = new Point(0, 121);
            pnlAlumnos.Margin = new Padding(3, 4, 3, 4);
            pnlAlumnos.Name = "pnlAlumnos";
            pnlAlumnos.Size = new Size(11, 37);
            pnlAlumnos.TabIndex = 2;
            // 
            // btnInstrumentos
            // 
            btnInstrumentos.FlatAppearance.BorderSize = 0;
            btnInstrumentos.FlatStyle = FlatStyle.Flat;
            btnInstrumentos.Location = new Point(14, 167);
            btnInstrumentos.Margin = new Padding(3, 4, 3, 4);
            btnInstrumentos.Name = "btnInstrumentos";
            btnInstrumentos.Size = new Size(162, 37);
            btnInstrumentos.TabIndex = 3;
            btnInstrumentos.Text = "Instrumentos";
            btnInstrumentos.UseVisualStyleBackColor = true;
            btnInstrumentos.Click += btnInstrumentos_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.FlatAppearance.BorderSize = 0;
            btnAlumnos.FlatStyle = FlatStyle.Flat;
            btnAlumnos.Location = new Point(14, 121);
            btnAlumnos.Margin = new Padding(3, 4, 3, 4);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(162, 37);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Location = new Point(176, 121);
            pnlContenedor.Margin = new Padding(3, 4, 3, 4);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1067, 575);
            pnlContenedor.TabIndex = 2;
            // 
            // alumnoBindingSource
            // 
            alumnoBindingSource.DataSource = typeof(Alumno);
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnSalir);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(176, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1067, 123);
            pnlTop.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(968, 51);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 700);
            Controls.Add(pnlTop);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenuPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            Text = "Form2";
            pnlMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource).EndInit();
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenuPrincipal;
        private Button btnAlumnos;
        private Panel pnlAlumnos;
        private Panel pnlProfesores;
        private Panel pnlInstrumentos;
        private Button btnProfesores;
        private Button btnInstrumentos;
        private Panel pnlContenedor;
        private Panel pnlTop;
        private BindingSource alumnoBindingSource;
        private Button btnSalir;
    }
}