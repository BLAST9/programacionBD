namespace capaPresentacion
{
    partial class fRecursos
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRecursos = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabDetalle = new System.Windows.Forms.TabPage();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewRecursos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsal = new System.Windows.Forms.Button();
            this.tabRecursos.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tabDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRecursos
            // 
            this.tabRecursos.Controls.Add(this.tabNuevo);
            this.tabRecursos.Controls.Add(this.tabDetalle);
            this.tabRecursos.Location = new System.Drawing.Point(7, 2);
            this.tabRecursos.Name = "tabRecursos";
            this.tabRecursos.SelectedIndex = 0;
            this.tabRecursos.Size = new System.Drawing.Size(790, 436);
            this.tabRecursos.TabIndex = 0;
            // 
            // tabNuevo
            // 
            this.tabNuevo.BackColor = System.Drawing.Color.White;
            this.tabNuevo.Controls.Add(this.buttonsal);
            this.tabNuevo.Controls.Add(this.textBoxDescripcion);
            this.tabNuevo.Controls.Add(this.textBoxNombre);
            this.tabNuevo.Controls.Add(this.textBoxCodigo);
            this.tabNuevo.Controls.Add(this.label6);
            this.tabNuevo.Controls.Add(this.label7);
            this.tabNuevo.Controls.Add(this.label8);
            this.tabNuevo.Controls.Add(this.lblId);
            this.tabNuevo.Controls.Add(this.buttonGuardar);
            this.tabNuevo.Controls.Add(this.textBoxId);
            this.tabNuevo.Controls.Add(this.label10);
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(782, 410);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Nuevo";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(171, 216);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(528, 26);
            this.textBoxDescripcion.TabIndex = 39;
            this.textBoxDescripcion.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(535, 160);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(164, 26);
            this.textBoxNombre.TabIndex = 38;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(171, 158);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(164, 26);
            this.textBoxCodigo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(56, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(433, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(56, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Direccion";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblId.Location = new System.Drawing.Point(56, 82);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "Id";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonGuardar.Location = new System.Drawing.Point(273, 306);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(114, 31);
            this.buttonGuardar.TabIndex = 32;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(171, 85);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(164, 26);
            this.textBoxId.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(268, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "Registrar Recursos";
            // 
            // tabDetalle
            // 
            this.tabDetalle.BackColor = System.Drawing.Color.White;
            this.tabDetalle.Controls.Add(this.buttonSalir);
            this.tabDetalle.Controls.Add(this.buttonEliminar);
            this.tabDetalle.Controls.Add(this.buttonEditar);
            this.tabDetalle.Controls.Add(this.dataGridViewRecursos);
            this.tabDetalle.Controls.Add(this.label2);
            this.tabDetalle.Controls.Add(this.buttonBuscar);
            this.tabDetalle.Controls.Add(this.textBoxBuscar);
            this.tabDetalle.Controls.Add(this.label1);
            this.tabDetalle.Location = new System.Drawing.Point(4, 22);
            this.tabDetalle.Name = "tabDetalle";
            this.tabDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalle.Size = new System.Drawing.Size(782, 410);
            this.tabDetalle.TabIndex = 1;
            this.tabDetalle.Text = "Detalle";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSalir.Location = new System.Drawing.Point(627, 93);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(94, 31);
            this.buttonSalir.TabIndex = 23;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEliminar.Location = new System.Drawing.Point(527, 93);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 31);
            this.buttonEliminar.TabIndex = 22;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEditar.Location = new System.Drawing.Point(427, 93);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 31);
            this.buttonEditar.TabIndex = 21;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewRecursos
            // 
            this.dataGridViewRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRecursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecursos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecursos.Location = new System.Drawing.Point(55, 154);
            this.dataGridViewRecursos.Name = "dataGridViewRecursos";
            this.dataGridViewRecursos.Size = new System.Drawing.Size(666, 234);
            this.dataGridViewRecursos.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonBuscar.Location = new System.Drawing.Point(327, 93);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 31);
            this.buttonBuscar.TabIndex = 18;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(135, 95);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(186, 26);
            this.textBoxBuscar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(267, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registrar Recursos";
            // 
            // buttonsal
            // 
            this.buttonsal.BackColor = System.Drawing.Color.Transparent;
            this.buttonsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonsal.Location = new System.Drawing.Point(406, 306);
            this.buttonsal.Name = "buttonsal";
            this.buttonsal.Size = new System.Drawing.Size(114, 31);
            this.buttonsal.TabIndex = 40;
            this.buttonsal.Text = "Salir";
            this.buttonsal.UseVisualStyleBackColor = false;
            this.buttonsal.Click += new System.EventHandler(this.buttonsal_Click);
            // 
            // fRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabRecursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRecursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fRecursos_Load);
            this.tabRecursos.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tabNuevo.PerformLayout();
            this.tabDetalle.ResumeLayout(false);
            this.tabDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRecursos;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TabPage tabDetalle;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewRecursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsal;
    }
}

