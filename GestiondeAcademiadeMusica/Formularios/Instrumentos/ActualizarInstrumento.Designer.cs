namespace GestiondeAcademiadeMusica.Forms.Instrumentos
{
    partial class ActualizarInstrumento
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
            btnGuardar = new Button();
            cmbEstadoInstrumento = new ComboBox();
            lblEstadoInstrumento = new Label();
            txtMarcaInstrumento = new TextBox();
            lblMarcaInstrumento = new Label();
            cmbCategoriaInstrumento = new ComboBox();
            lblCategoriaInstrumento = new Label();
            txtNombreInstrumento = new TextBox();
            lblNombreInstrumento = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(420, 248);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEstadoInstrumento
            // 
            cmbEstadoInstrumento.FormattingEnabled = true;
            cmbEstadoInstrumento.Items.AddRange(new object[] { "Disponible", "En uso", "En mantenimiento", "Deteriorado", "De baja" });
            cmbEstadoInstrumento.Location = new Point(363, 121);
            cmbEstadoInstrumento.Name = "cmbEstadoInstrumento";
            cmbEstadoInstrumento.Size = new Size(132, 23);
            cmbEstadoInstrumento.TabIndex = 24;
            // 
            // lblEstadoInstrumento
            // 
            lblEstadoInstrumento.AutoSize = true;
            lblEstadoInstrumento.Location = new Point(363, 103);
            lblEstadoInstrumento.Name = "lblEstadoInstrumento";
            lblEstadoInstrumento.Size = new Size(132, 15);
            lblEstadoInstrumento.TabIndex = 23;
            lblEstadoInstrumento.Text = "Estado del instrumento:";
            // 
            // txtMarcaInstrumento
            // 
            txtMarcaInstrumento.Location = new Point(92, 248);
            txtMarcaInstrumento.Name = "txtMarcaInstrumento";
            txtMarcaInstrumento.Size = new Size(100, 23);
            txtMarcaInstrumento.TabIndex = 20;
            // 
            // lblMarcaInstrumento
            // 
            lblMarcaInstrumento.AutoSize = true;
            lblMarcaInstrumento.Location = new Point(92, 230);
            lblMarcaInstrumento.Name = "lblMarcaInstrumento";
            lblMarcaInstrumento.Size = new Size(43, 15);
            lblMarcaInstrumento.TabIndex = 19;
            lblMarcaInstrumento.Text = "Marca:";
            // 
            // cmbCategoriaInstrumento
            // 
            cmbCategoriaInstrumento.FormattingEnabled = true;
            cmbCategoriaInstrumento.Items.AddRange(new object[] { "Cuerda Frotada", "Cuerda Pulsada", "Cuerda Percutida", "Viento Madera", "Viento Metal", "Percusión", "Teclas", "Electrónico", "Folclórico" });
            cmbCategoriaInstrumento.Location = new Point(92, 181);
            cmbCategoriaInstrumento.Name = "cmbCategoriaInstrumento";
            cmbCategoriaInstrumento.Size = new Size(121, 23);
            cmbCategoriaInstrumento.TabIndex = 18;
            // 
            // lblCategoriaInstrumento
            // 
            lblCategoriaInstrumento.AutoSize = true;
            lblCategoriaInstrumento.Location = new Point(92, 163);
            lblCategoriaInstrumento.Name = "lblCategoriaInstrumento";
            lblCategoriaInstrumento.Size = new Size(61, 15);
            lblCategoriaInstrumento.TabIndex = 17;
            lblCategoriaInstrumento.Text = "Categoria:";
            // 
            // txtNombreInstrumento
            // 
            txtNombreInstrumento.Location = new Point(92, 121);
            txtNombreInstrumento.Name = "txtNombreInstrumento";
            txtNombreInstrumento.Size = new Size(100, 23);
            txtNombreInstrumento.TabIndex = 16;
            // 
            // lblNombreInstrumento
            // 
            lblNombreInstrumento.AutoSize = true;
            lblNombreInstrumento.Location = new Point(92, 103);
            lblNombreInstrumento.Name = "lblNombreInstrumento";
            lblNombreInstrumento.Size = new Size(54, 15);
            lblNombreInstrumento.TabIndex = 15;
            lblNombreInstrumento.Text = "Nombre:";
            // 
            // ActualizarInstrumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstadoInstrumento);
            Controls.Add(lblEstadoInstrumento);
            Controls.Add(txtMarcaInstrumento);
            Controls.Add(lblMarcaInstrumento);
            Controls.Add(cmbCategoriaInstrumento);
            Controls.Add(lblCategoriaInstrumento);
            Controls.Add(txtNombreInstrumento);
            Controls.Add(lblNombreInstrumento);
            Name = "ActualizarInstrumento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActualizarInstrumento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private ComboBox cmbEstadoInstrumento;
        private Label lblEstadoInstrumento;
        private TextBox txtMarcaInstrumento;
        private Label lblMarcaInstrumento;
        private ComboBox cmbCategoriaInstrumento;
        private Label lblCategoriaInstrumento;
        private TextBox txtNombreInstrumento;
        private Label lblNombreInstrumento;
    }
}