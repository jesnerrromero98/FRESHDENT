namespace CapaPresentacionExpediente
{
    partial class fExpediente
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
            this.tabExpediente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDepartamentoExpediente = new System.Windows.Forms.TextBox();
            this.textBoxMunicipioExpediente = new System.Windows.Forms.TextBox();
            this.textBoxTelefono_CelularExpediente = new System.Windows.Forms.TextBox();
            this.textBoxFecha_NacimientoExpediente = new System.Windows.Forms.TextBox();
            this.textBoxApellidoExpediente = new System.Windows.Forms.TextBox();
            this.textBoxNombreExpediente = new System.Windows.Forms.TextBox();
            this.textBoxCedulaExpediente = new System.Windows.Forms.TextBox();
            this.textBoxIDExpediente = new System.Windows.Forms.TextBox();
            this.labelDepartamentoExpediente = new System.Windows.Forms.Label();
            this.labelMunicipioExpediente = new System.Windows.Forms.Label();
            this.labelTelefono_CelularExpediente = new System.Windows.Forms.Label();
            this.labelFecha_NacimientoExpediente = new System.Windows.Forms.Label();
            this.labelApellidosExpediente = new System.Windows.Forms.Label();
            this.labelNombreExpediente = new System.Windows.Forms.Label();
            this.labelCedulaExpediente = new System.Windows.Forms.Label();
            this.labelIDExpediente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarExpediente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabExpediente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabExpediente
            // 
            this.tabExpediente.Controls.Add(this.tabPage1);
            this.tabExpediente.Controls.Add(this.tabPage2);
            this.tabExpediente.Location = new System.Drawing.Point(0, 1);
            this.tabExpediente.Name = "tabExpediente";
            this.tabExpediente.SelectedIndex = 0;
            this.tabExpediente.Size = new System.Drawing.Size(800, 451);
            this.tabExpediente.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxDepartamentoExpediente);
            this.tabPage1.Controls.Add(this.textBoxMunicipioExpediente);
            this.tabPage1.Controls.Add(this.textBoxTelefono_CelularExpediente);
            this.tabPage1.Controls.Add(this.textBoxFecha_NacimientoExpediente);
            this.tabPage1.Controls.Add(this.textBoxApellidoExpediente);
            this.tabPage1.Controls.Add(this.textBoxNombreExpediente);
            this.tabPage1.Controls.Add(this.textBoxCedulaExpediente);
            this.tabPage1.Controls.Add(this.textBoxIDExpediente);
            this.tabPage1.Controls.Add(this.labelDepartamentoExpediente);
            this.tabPage1.Controls.Add(this.labelMunicipioExpediente);
            this.tabPage1.Controls.Add(this.labelTelefono_CelularExpediente);
            this.tabPage1.Controls.Add(this.labelFecha_NacimientoExpediente);
            this.tabPage1.Controls.Add(this.labelApellidosExpediente);
            this.tabPage1.Controls.Add(this.labelNombreExpediente);
            this.tabPage1.Controls.Add(this.labelCedulaExpediente);
            this.tabPage1.Controls.Add(this.labelIDExpediente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(311, 348);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 40);
            this.buttonGuardar.TabIndex = 35;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDepartamentoExpediente
            // 
            this.textBoxDepartamentoExpediente.Location = new System.Drawing.Point(599, 277);
            this.textBoxDepartamentoExpediente.Multiline = true;
            this.textBoxDepartamentoExpediente.Name = "textBoxDepartamentoExpediente";
            this.textBoxDepartamentoExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxDepartamentoExpediente.TabIndex = 34;
            // 
            // textBoxMunicipioExpediente
            // 
            this.textBoxMunicipioExpediente.Location = new System.Drawing.Point(599, 215);
            this.textBoxMunicipioExpediente.Multiline = true;
            this.textBoxMunicipioExpediente.Name = "textBoxMunicipioExpediente";
            this.textBoxMunicipioExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxMunicipioExpediente.TabIndex = 33;
            // 
            // textBoxTelefono_CelularExpediente
            // 
            this.textBoxTelefono_CelularExpediente.Location = new System.Drawing.Point(599, 153);
            this.textBoxTelefono_CelularExpediente.Multiline = true;
            this.textBoxTelefono_CelularExpediente.Name = "textBoxTelefono_CelularExpediente";
            this.textBoxTelefono_CelularExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxTelefono_CelularExpediente.TabIndex = 32;
            // 
            // textBoxFecha_NacimientoExpediente
            // 
            this.textBoxFecha_NacimientoExpediente.Location = new System.Drawing.Point(599, 87);
            this.textBoxFecha_NacimientoExpediente.Multiline = true;
            this.textBoxFecha_NacimientoExpediente.Name = "textBoxFecha_NacimientoExpediente";
            this.textBoxFecha_NacimientoExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxFecha_NacimientoExpediente.TabIndex = 31;
            // 
            // textBoxApellidoExpediente
            // 
            this.textBoxApellidoExpediente.Location = new System.Drawing.Point(149, 275);
            this.textBoxApellidoExpediente.Multiline = true;
            this.textBoxApellidoExpediente.Name = "textBoxApellidoExpediente";
            this.textBoxApellidoExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxApellidoExpediente.TabIndex = 30;
            // 
            // textBoxNombreExpediente
            // 
            this.textBoxNombreExpediente.Location = new System.Drawing.Point(149, 216);
            this.textBoxNombreExpediente.Multiline = true;
            this.textBoxNombreExpediente.Name = "textBoxNombreExpediente";
            this.textBoxNombreExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxNombreExpediente.TabIndex = 29;
            // 
            // textBoxCedulaExpediente
            // 
            this.textBoxCedulaExpediente.Location = new System.Drawing.Point(149, 153);
            this.textBoxCedulaExpediente.Multiline = true;
            this.textBoxCedulaExpediente.Name = "textBoxCedulaExpediente";
            this.textBoxCedulaExpediente.Size = new System.Drawing.Size(159, 20);
            this.textBoxCedulaExpediente.TabIndex = 28;
            // 
            // textBoxIDExpediente
            // 
            this.textBoxIDExpediente.Location = new System.Drawing.Point(80, 90);
            this.textBoxIDExpediente.Multiline = true;
            this.textBoxIDExpediente.Name = "textBoxIDExpediente";
            this.textBoxIDExpediente.Size = new System.Drawing.Size(126, 20);
            this.textBoxIDExpediente.TabIndex = 27;
            // 
            // labelDepartamentoExpediente
            // 
            this.labelDepartamentoExpediente.AutoSize = true;
            this.labelDepartamentoExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamentoExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDepartamentoExpediente.Location = new System.Drawing.Point(352, 270);
            this.labelDepartamentoExpediente.Name = "labelDepartamentoExpediente";
            this.labelDepartamentoExpediente.Size = new System.Drawing.Size(160, 25);
            this.labelDepartamentoExpediente.TabIndex = 26;
            this.labelDepartamentoExpediente.Text = "Departamento";
            // 
            // labelMunicipioExpediente
            // 
            this.labelMunicipioExpediente.AutoSize = true;
            this.labelMunicipioExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipioExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMunicipioExpediente.Location = new System.Drawing.Point(352, 210);
            this.labelMunicipioExpediente.Name = "labelMunicipioExpediente";
            this.labelMunicipioExpediente.Size = new System.Drawing.Size(125, 25);
            this.labelMunicipioExpediente.TabIndex = 25;
            this.labelMunicipioExpediente.Text = "Municipio";
            // 
            // labelTelefono_CelularExpediente
            // 
            this.labelTelefono_CelularExpediente.AutoSize = true;
            this.labelTelefono_CelularExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono_CelularExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTelefono_CelularExpediente.Location = new System.Drawing.Point(352, 148);
            this.labelTelefono_CelularExpediente.Name = "labelTelefono_CelularExpediente";
            this.labelTelefono_CelularExpediente.Size = new System.Drawing.Size(203, 25);
            this.labelTelefono_CelularExpediente.TabIndex = 24;
            this.labelTelefono_CelularExpediente.Text = "Telefono_Celular";
            // 
            // labelFecha_NacimientoExpediente
            // 
            this.labelFecha_NacimientoExpediente.AutoSize = true;
            this.labelFecha_NacimientoExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha_NacimientoExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFecha_NacimientoExpediente.Location = new System.Drawing.Point(352, 90);
            this.labelFecha_NacimientoExpediente.Name = "labelFecha_NacimientoExpediente";
            this.labelFecha_NacimientoExpediente.Size = new System.Drawing.Size(217, 25);
            this.labelFecha_NacimientoExpediente.TabIndex = 23;
            this.labelFecha_NacimientoExpediente.Text = "Fecha_Nacimiento";
            // 
            // labelApellidosExpediente
            // 
            this.labelApellidosExpediente.AutoSize = true;
            this.labelApellidosExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidosExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelApellidosExpediente.Location = new System.Drawing.Point(18, 270);
            this.labelApellidosExpediente.Name = "labelApellidosExpediente";
            this.labelApellidosExpediente.Size = new System.Drawing.Size(115, 25);
            this.labelApellidosExpediente.TabIndex = 22;
            this.labelApellidosExpediente.Text = "Apellidos";
            // 
            // labelNombreExpediente
            // 
            this.labelNombreExpediente.AutoSize = true;
            this.labelNombreExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreExpediente.Location = new System.Drawing.Point(18, 211);
            this.labelNombreExpediente.Name = "labelNombreExpediente";
            this.labelNombreExpediente.Size = new System.Drawing.Size(103, 25);
            this.labelNombreExpediente.TabIndex = 21;
            this.labelNombreExpediente.Text = "Nombres";
            // 
            // labelCedulaExpediente
            // 
            this.labelCedulaExpediente.AutoSize = true;
            this.labelCedulaExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedulaExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCedulaExpediente.Location = new System.Drawing.Point(18, 148);
            this.labelCedulaExpediente.Name = "labelCedulaExpediente";
            this.labelCedulaExpediente.Size = new System.Drawing.Size(85, 25);
            this.labelCedulaExpediente.TabIndex = 20;
            this.labelCedulaExpediente.Text = "Cedula";
            // 
            // labelIDExpediente
            // 
            this.labelIDExpediente.AutoSize = true;
            this.labelIDExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIDExpediente.Location = new System.Drawing.Point(18, 85);
            this.labelIDExpediente.Name = "labelIDExpediente";
            this.labelIDExpediente.Size = new System.Drawing.Size(41, 25);
            this.labelIDExpediente.TabIndex = 19;
            this.labelIDExpediente.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(290, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Expediente";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscarExpediente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminar.Location = new System.Drawing.Point(312, 359);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(151, 46);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditar.Location = new System.Drawing.Point(550, 46);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(117, 37);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Location = new System.Drawing.Point(353, 46);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(128, 37);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(141, 53);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(191, 24);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscarExpediente
            // 
            this.labelBuscarExpediente.AutoSize = true;
            this.labelBuscarExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarExpediente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBuscarExpediente.Location = new System.Drawing.Point(29, 52);
            this.labelBuscarExpediente.Name = "labelBuscarExpediente";
            this.labelBuscarExpediente.Size = new System.Drawing.Size(86, 25);
            this.labelBuscarExpediente.TabIndex = 0;
            this.labelBuscarExpediente.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 180);
            this.dataGridView1.TabIndex = 5;
            // 
            // fExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabExpediente);
            this.Name = "fExpediente";
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.fExpediente_Load);
            this.tabExpediente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExpediente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxDepartamentoExpediente;
        private System.Windows.Forms.TextBox textBoxMunicipioExpediente;
        private System.Windows.Forms.TextBox textBoxTelefono_CelularExpediente;
        private System.Windows.Forms.TextBox textBoxFecha_NacimientoExpediente;
        private System.Windows.Forms.TextBox textBoxApellidoExpediente;
        private System.Windows.Forms.TextBox textBoxNombreExpediente;
        private System.Windows.Forms.TextBox textBoxCedulaExpediente;
        private System.Windows.Forms.TextBox textBoxIDExpediente;
        private System.Windows.Forms.Label labelDepartamentoExpediente;
        private System.Windows.Forms.Label labelMunicipioExpediente;
        private System.Windows.Forms.Label labelTelefono_CelularExpediente;
        private System.Windows.Forms.Label labelFecha_NacimientoExpediente;
        private System.Windows.Forms.Label labelApellidosExpediente;
        private System.Windows.Forms.Label labelNombreExpediente;
        private System.Windows.Forms.Label labelCedulaExpediente;
        private System.Windows.Forms.Label labelIDExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscarExpediente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

