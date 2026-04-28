namespace GestiondeAcademiadeMusica.Forms
{
    partial class AgregarInstrumento
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
            txtNombreInstrumento = new TextBox();
            lblNombreInstrumento = new Label();
            lblCategoriaInstrumento = new Label();
            cmbCategoriaInstrumento = new ComboBox();
            txtMarcaInstrumento = new TextBox();
            lblMarcaInstrumento = new Label();
            lblEstadoInstrumento = new Label();
            cmbEstadoInstrumento = new ComboBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtNombreInstrumento
            // 
            txtNombreInstrumento.Location = new Point(97, 121);
            txtNombreInstrumento.Name = "txtNombreInstrumento";
            txtNombreInstrumento.Size = new Size(100, 23);
            txtNombreInstrumento.TabIndex = 3;
            // 
            // lblNombreInstrumento
            // 
            lblNombreInstrumento.AutoSize = true;
            lblNombreInstrumento.Location = new Point(97, 103);
            lblNombreInstrumento.Name = "lblNombreInstrumento";
            lblNombreInstrumento.Size = new Size(54, 15);
            lblNombreInstrumento.TabIndex = 2;
            lblNombreInstrumento.Text = "Nombre:";
            // 
            // lblCategoriaInstrumento
            // 
            lblCategoriaInstrumento.AutoSize = true;
            lblCategoriaInstrumento.Location = new Point(97, 163);
            lblCategoriaInstrumento.Name = "lblCategoriaInstrumento";
            lblCategoriaInstrumento.Size = new Size(61, 15);
            lblCategoriaInstrumento.TabIndex = 4;
            lblCategoriaInstrumento.Text = "Categoria:";
            // 
            // cmbCategoriaInstrumento
            // 
            cmbCategoriaInstrumento.FormattingEnabled = true;
            cmbCategoriaInstrumento.Items.AddRange(new object[] { "Cuerda Frotada", "Cuerda Pulsada", "Cuerda Percutida", "Viento Madera", "Viento Metal", "Percusión", "Teclas", "Electrónico", "Folclórico" });
            cmbCategoriaInstrumento.Location = new Point(97, 181);
            cmbCategoriaInstrumento.Name = "cmbCategoriaInstrumento";
            cmbCategoriaInstrumento.Size = new Size(121, 23);
            cmbCategoriaInstrumento.TabIndex = 6;
            // 
            // txtMarcaInstrumento
            // 
            txtMarcaInstrumento.Location = new Point(97, 248);
            txtMarcaInstrumento.Name = "txtMarcaInstrumento";
            txtMarcaInstrumento.Size = new Size(100, 23);
            txtMarcaInstrumento.TabIndex = 8;
            // 
            // lblMarcaInstrumento
            // 
            lblMarcaInstrumento.AutoSize = true;
            lblMarcaInstrumento.Location = new Point(97, 230);
            lblMarcaInstrumento.Name = "lblMarcaInstrumento";
            lblMarcaInstrumento.Size = new Size(43, 15);
            lblMarcaInstrumento.TabIndex = 7;
            lblMarcaInstrumento.Text = "Marca:";
            // 
            // lblEstadoInstrumento
            // 
            lblEstadoInstrumento.AutoSize = true;
            lblEstadoInstrumento.Location = new Point(368, 102);
            lblEstadoInstrumento.Name = "lblEstadoInstrumento";
            lblEstadoInstrumento.Size = new Size(132, 15);
            lblEstadoInstrumento.TabIndex = 11;
            lblEstadoInstrumento.Text = "Estado del instrumento:";
            // 
            // cmbEstadoInstrumento
            // 
            cmbEstadoInstrumento.FormattingEnabled = true;
            cmbEstadoInstrumento.Items.AddRange(new object[] { "Disponible", "En uso", "En mantenimiento", "Deteriorado", "De baja" });
            cmbEstadoInstrumento.Location = new Point(368, 134);
            cmbEstadoInstrumento.Name = "cmbEstadoInstrumento";
            cmbEstadoInstrumento.Size = new Size(132, 23);
            cmbEstadoInstrumento.TabIndex = 12;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(425, 248);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // AgregarInstrumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(cmbEstadoInstrumento);
            Controls.Add(lblEstadoInstrumento);
            Controls.Add(txtMarcaInstrumento);
            Controls.Add(lblMarcaInstrumento);
            Controls.Add(cmbCategoriaInstrumento);
            Controls.Add(lblCategoriaInstrumento);
            Controls.Add(txtNombreInstrumento);
            Controls.Add(lblNombreInstrumento);
            Name = "AgregarInstrumento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioInstrumentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreInstrumento;
        private Label lblNombreInstrumento;
        private Label lblCategoriaInstrumento;
        private ComboBox cmbCategoriaInstrumento;
        private TextBox txtMarcaInstrumento;
        private Label lblMarcaInstrumento;
        private Label lblEstadoInstrumento;
        private ComboBox cmbEstadoInstrumento;
        private Button btnEnviar;
    }
}