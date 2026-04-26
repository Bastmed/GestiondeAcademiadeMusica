namespace GestiondeAcademiadeMusica.Forms.UserControls
{
    partial class Uc_Instrumentos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvInstrumentos = new DataGridView();
            idInstrumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioMensualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instrumentoBindingSource1 = new BindingSource(components);
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            profesorBindingSource = new BindingSource(components);
            instrumentoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvInstrumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instrumentoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instrumentoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvInstrumentos
            // 
            dgvInstrumentos.AllowUserToOrderColumns = true;
            dgvInstrumentos.AutoGenerateColumns = false;
            dgvInstrumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstrumentos.Columns.AddRange(new DataGridViewColumn[] { idInstrumentoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, precioMensualDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dgvInstrumentos.DataSource = instrumentoBindingSource1;
            dgvInstrumentos.Location = new Point(3, 34);
            dgvInstrumentos.Name = "dgvInstrumentos";
            dgvInstrumentos.Size = new Size(843, 218);
            dgvInstrumentos.TabIndex = 2;
            // 
            // idInstrumentoDataGridViewTextBoxColumn
            // 
            idInstrumentoDataGridViewTextBoxColumn.DataPropertyName = "IdInstrumento";
            idInstrumentoDataGridViewTextBoxColumn.HeaderText = "IdInstrumento";
            idInstrumentoDataGridViewTextBoxColumn.Name = "idInstrumentoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // precioMensualDataGridViewTextBoxColumn
            // 
            precioMensualDataGridViewTextBoxColumn.DataPropertyName = "PrecioMensual";
            precioMensualDataGridViewTextBoxColumn.HeaderText = "PrecioMensual";
            precioMensualDataGridViewTextBoxColumn.Name = "precioMensualDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // instrumentoBindingSource1
            // 
            instrumentoBindingSource1.DataSource = typeof(Instrumento);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(852, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(852, 95);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(852, 66);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // profesorBindingSource
            // 
            profesorBindingSource.DataSource = typeof(Profesor);
            // 
            // instrumentoBindingSource
            // 
            instrumentoBindingSource.DataSource = typeof(Instrumento);
            // 
            // Uc_Instrumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvInstrumentos);
            Name = "Uc_Instrumentos";
            Size = new Size(934, 431);
            ((System.ComponentModel.ISupportInitialize)dgvInstrumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)instrumentoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)instrumentoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInstrumentos;
        private BindingSource instrumentoBindingSource;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnActualizar;
        private BindingSource profesorBindingSource;
        private DataGridViewTextBoxColumn idInstrumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioMensualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private BindingSource instrumentoBindingSource1;
    }
}
