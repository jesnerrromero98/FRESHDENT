namespace CapaPresentacionEspecialidad
{
    partial class fEspecialidad
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
            this.tabEspecialidad = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDescpEspecialidad = new System.Windows.Forms.TextBox();
            this.textBoxNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.textBoxIDEspecialidad = new System.Windows.Forms.TextBox();
            this.labelDescpEspecialidad = new System.Windows.Forms.Label();
            this.labelNombreEspecialidad = new System.Windows.Forms.Label();
            this.labelIDEspecialidad = new System.Windows.Forms.Label();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eliminar = new System.Windows.Forms.Button();
            this.dataGridViewEspecialidad = new System.Windows.Forms.DataGridView();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarExpediente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.tabEspecialidad.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEspecialidad
            // 
            this.tabEspecialidad.Controls.Add(this.tabPage1);
            this.tabEspecialidad.Controls.Add(this.tabPage2);
            this.tabEspecialidad.Location = new System.Drawing.Point(1, 1);
            this.tabEspecialidad.Name = "tabEspecialidad";
            this.tabEspecialidad.SelectedIndex = 0;
            this.tabEspecialidad.Size = new System.Drawing.Size(930, 451);
            this.tabEspecialidad.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImage = global::capapresentacionWF.Properties.Resources.logodental1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.buttonSalir);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxDescpEspecialidad);
            this.tabPage1.Controls.Add(this.textBoxNombreEspecialidad);
            this.tabPage1.Controls.Add(this.textBoxIDEspecialidad);
            this.tabPage1.Controls.Add(this.labelDescpEspecialidad);
            this.tabPage1.Controls.Add(this.labelNombreEspecialidad);
            this.tabPage1.Controls.Add(this.labelIDEspecialidad);
            this.tabPage1.Controls.Add(this.labelEspecialidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(725, 365);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(142, 51);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDescpEspecialidad
            // 
            this.textBoxDescpEspecialidad.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxDescpEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescpEspecialidad.Location = new System.Drawing.Point(333, 212);
            this.textBoxDescpEspecialidad.Multiline = true;
            this.textBoxDescpEspecialidad.Name = "textBoxDescpEspecialidad";
            this.textBoxDescpEspecialidad.Size = new System.Drawing.Size(318, 116);
            this.textBoxDescpEspecialidad.TabIndex = 6;
            // 
            // textBoxNombreEspecialidad
            // 
            this.textBoxNombreEspecialidad.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxNombreEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEspecialidad.Location = new System.Drawing.Point(392, 114);
            this.textBoxNombreEspecialidad.Multiline = true;
            this.textBoxNombreEspecialidad.Name = "textBoxNombreEspecialidad";
            this.textBoxNombreEspecialidad.Size = new System.Drawing.Size(212, 25);
            this.textBoxNombreEspecialidad.TabIndex = 5;
            // 
            // textBoxIDEspecialidad
            // 
            this.textBoxIDEspecialidad.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDEspecialidad.Location = new System.Drawing.Point(133, 49);
            this.textBoxIDEspecialidad.Multiline = true;
            this.textBoxIDEspecialidad.Name = "textBoxIDEspecialidad";
            this.textBoxIDEspecialidad.Size = new System.Drawing.Size(55, 25);
            this.textBoxIDEspecialidad.TabIndex = 4;
            // 
            // labelDescpEspecialidad
            // 
            this.labelDescpEspecialidad.AutoSize = true;
            this.labelDescpEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.labelDescpEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescpEspecialidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDescpEspecialidad.Location = new System.Drawing.Point(206, 184);
            this.labelDescpEspecialidad.Name = "labelDescpEspecialidad";
            this.labelDescpEspecialidad.Size = new System.Drawing.Size(139, 25);
            this.labelDescpEspecialidad.TabIndex = 3;
            this.labelDescpEspecialidad.Text = "Descripción";
            // 
            // labelNombreEspecialidad
            // 
            this.labelNombreEspecialidad.AutoSize = true;
            this.labelNombreEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEspecialidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreEspecialidad.Location = new System.Drawing.Point(251, 114);
            this.labelNombreEspecialidad.Name = "labelNombreEspecialidad";
            this.labelNombreEspecialidad.Size = new System.Drawing.Size(94, 25);
            this.labelNombreEspecialidad.TabIndex = 2;
            this.labelNombreEspecialidad.Text = "Nombre";
            // 
            // labelIDEspecialidad
            // 
            this.labelIDEspecialidad.AutoSize = true;
            this.labelIDEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.labelIDEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDEspecialidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDEspecialidad.Location = new System.Drawing.Point(86, 49);
            this.labelIDEspecialidad.Name = "labelIDEspecialidad";
            this.labelIDEspecialidad.Size = new System.Drawing.Size(41, 25);
            this.labelIDEspecialidad.TabIndex = 1;
            this.labelIDEspecialidad.Text = "ID";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.labelEspecialidad.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidad.ForeColor = System.Drawing.Color.DimGray;
            this.labelEspecialidad.Location = new System.Drawing.Point(398, 3);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(188, 38);
            this.labelEspecialidad.TabIndex = 0;
            this.labelEspecialidad.Text = "Especialidad";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.eliminar);
            this.tabPage2.Controls.Add(this.dataGridViewEspecialidad);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscarExpediente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.eliminar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.eliminar.ForeColor = System.Drawing.Color.White;
            this.eliminar.Location = new System.Drawing.Point(769, 366);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(112, 38);
            this.eliminar.TabIndex = 13;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // dataGridViewEspecialidad
            // 
            this.dataGridViewEspecialidad.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialidad.GridColor = System.Drawing.Color.White;
            this.dataGridViewEspecialidad.Location = new System.Drawing.Point(84, 127);
            this.dataGridViewEspecialidad.Name = "dataGridViewEspecialidad";
            this.dataGridViewEspecialidad.Size = new System.Drawing.Size(750, 221);
            this.dataGridViewEspecialidad.TabIndex = 11;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEditar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(689, 8);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 34);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonBuscar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(593, 8);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 34);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxBuscar.Location = new System.Drawing.Point(302, 76);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(369, 27);
            this.textBoxBuscar.TabIndex = 7;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscarExpediente
            // 
            this.labelBuscarExpediente.AutoSize = true;
            this.labelBuscarExpediente.BackColor = System.Drawing.Color.Transparent;
            this.labelBuscarExpediente.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelBuscarExpediente.Location = new System.Drawing.Point(188, 76);
            this.labelBuscarExpediente.Name = "labelBuscarExpediente";
            this.labelBuscarExpediente.Size = new System.Drawing.Size(96, 29);
            this.labelBuscarExpediente.TabIndex = 6;
            this.labelBuscarExpediente.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(882, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(878, 6);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(27, 28);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "X";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // fEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(934, 451);
            this.Controls.Add(this.tabEspecialidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.fEspecialidad_Load);
            this.tabEspecialidad.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEspecialidad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxDescpEspecialidad;
        private System.Windows.Forms.TextBox textBoxNombreEspecialidad;
        private System.Windows.Forms.TextBox textBoxIDEspecialidad;
        private System.Windows.Forms.Label labelDescpEspecialidad;
        private System.Windows.Forms.Label labelNombreEspecialidad;
        private System.Windows.Forms.Label labelIDEspecialidad;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.DataGridView dataGridViewEspecialidad;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscarExpediente;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSalir;
    }
}

