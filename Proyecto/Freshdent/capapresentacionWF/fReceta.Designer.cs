namespace CapaPresentacionReceta
{
    partial class fReceta
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
            this.tabReceta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxDescripcionReceta = new System.Windows.Forms.TextBox();
            this.labelDescripcionReceta = new System.Windows.Forms.Label();
            this.textBoxPresentacionReceta = new System.Windows.Forms.TextBox();
            this.labelPresentacionReceta = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxCantidadReceta = new System.Windows.Forms.TextBox();
            this.textBoxNombreReceta = new System.Windows.Forms.TextBox();
            this.textBoxIDReceta = new System.Windows.Forms.TextBox();
            this.labelCantidadReceta = new System.Windows.Forms.Label();
            this.labelNombreReceta = new System.Windows.Forms.Label();
            this.labelIDReceta = new System.Windows.Forms.Label();
            this.labelReceta = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewReceta = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.tabReceta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReceta
            // 
            this.tabReceta.Controls.Add(this.tabPage1);
            this.tabReceta.Controls.Add(this.tabPage2);
            this.tabReceta.Location = new System.Drawing.Point(0, 0);
            this.tabReceta.Name = "tabReceta";
            this.tabReceta.SelectedIndex = 0;
            this.tabReceta.Size = new System.Drawing.Size(945, 451);
            this.tabReceta.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImage = global::capapresentacionWF.Properties.Resources.logodental1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.buttonSalir);
            this.tabPage1.Controls.Add(this.textBoxDescripcionReceta);
            this.tabPage1.Controls.Add(this.labelDescripcionReceta);
            this.tabPage1.Controls.Add(this.textBoxPresentacionReceta);
            this.tabPage1.Controls.Add(this.labelPresentacionReceta);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxCantidadReceta);
            this.tabPage1.Controls.Add(this.textBoxNombreReceta);
            this.tabPage1.Controls.Add(this.textBoxIDReceta);
            this.tabPage1.Controls.Add(this.labelCantidadReceta);
            this.tabPage1.Controls.Add(this.labelNombreReceta);
            this.tabPage1.Controls.Add(this.labelIDReceta);
            this.tabPage1.Controls.Add(this.labelReceta);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(891, 6);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(27, 28);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "X";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxDescripcionReceta
            // 
            this.textBoxDescripcionReceta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxDescripcionReceta.Location = new System.Drawing.Point(330, 239);
            this.textBoxDescripcionReceta.Multiline = true;
            this.textBoxDescripcionReceta.Name = "textBoxDescripcionReceta";
            this.textBoxDescripcionReceta.Size = new System.Drawing.Size(334, 118);
            this.textBoxDescripcionReceta.TabIndex = 14;
            // 
            // labelDescripcionReceta
            // 
            this.labelDescripcionReceta.AutoSize = true;
            this.labelDescripcionReceta.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcionReceta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionReceta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDescripcionReceta.Location = new System.Drawing.Point(156, 211);
            this.labelDescripcionReceta.Name = "labelDescripcionReceta";
            this.labelDescripcionReceta.Size = new System.Drawing.Size(199, 25);
            this.labelDescripcionReceta.TabIndex = 13;
            this.labelDescripcionReceta.Text = "Recomendaciones";
            // 
            // textBoxPresentacionReceta
            // 
            this.textBoxPresentacionReceta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxPresentacionReceta.Location = new System.Drawing.Point(378, 154);
            this.textBoxPresentacionReceta.Multiline = true;
            this.textBoxPresentacionReceta.Name = "textBoxPresentacionReceta";
            this.textBoxPresentacionReceta.Size = new System.Drawing.Size(221, 25);
            this.textBoxPresentacionReceta.TabIndex = 12;
            // 
            // labelPresentacionReceta
            // 
            this.labelPresentacionReceta.AutoSize = true;
            this.labelPresentacionReceta.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentacionReceta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentacionReceta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPresentacionReceta.Location = new System.Drawing.Point(177, 154);
            this.labelPresentacionReceta.Name = "labelPresentacionReceta";
            this.labelPresentacionReceta.Size = new System.Drawing.Size(150, 25);
            this.labelPresentacionReceta.TabIndex = 10;
            this.labelPresentacionReceta.Text = "Presentacion";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(732, 365);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(142, 51);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxCantidadReceta
            // 
            this.textBoxCantidadReceta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxCantidadReceta.Location = new System.Drawing.Point(764, 116);
            this.textBoxCantidadReceta.Multiline = true;
            this.textBoxCantidadReceta.Name = "textBoxCantidadReceta";
            this.textBoxCantidadReceta.Size = new System.Drawing.Size(154, 30);
            this.textBoxCantidadReceta.TabIndex = 6;
            // 
            // textBoxNombreReceta
            // 
            this.textBoxNombreReceta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxNombreReceta.Location = new System.Drawing.Point(378, 102);
            this.textBoxNombreReceta.Multiline = true;
            this.textBoxNombreReceta.Name = "textBoxNombreReceta";
            this.textBoxNombreReceta.Size = new System.Drawing.Size(221, 25);
            this.textBoxNombreReceta.TabIndex = 5;
            // 
            // textBoxIDReceta
            // 
            this.textBoxIDReceta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDReceta.Location = new System.Drawing.Point(55, 24);
            this.textBoxIDReceta.Multiline = true;
            this.textBoxIDReceta.Name = "textBoxIDReceta";
            this.textBoxIDReceta.Size = new System.Drawing.Size(40, 33);
            this.textBoxIDReceta.TabIndex = 4;
            // 
            // labelCantidadReceta
            // 
            this.labelCantidadReceta.AutoSize = true;
            this.labelCantidadReceta.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidadReceta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadReceta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCantidadReceta.Location = new System.Drawing.Point(778, 79);
            this.labelCantidadReceta.Name = "labelCantidadReceta";
            this.labelCantidadReceta.Size = new System.Drawing.Size(107, 25);
            this.labelCantidadReceta.TabIndex = 3;
            this.labelCantidadReceta.Text = "Cantidad";
            // 
            // labelNombreReceta
            // 
            this.labelNombreReceta.AutoSize = true;
            this.labelNombreReceta.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreReceta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreReceta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreReceta.Location = new System.Drawing.Point(173, 102);
            this.labelNombreReceta.Name = "labelNombreReceta";
            this.labelNombreReceta.Size = new System.Drawing.Size(154, 25);
            this.labelNombreReceta.TabIndex = 2;
            this.labelNombreReceta.Text = "Medicamento";
            // 
            // labelIDReceta
            // 
            this.labelIDReceta.AutoSize = true;
            this.labelIDReceta.BackColor = System.Drawing.Color.Transparent;
            this.labelIDReceta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDReceta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDReceta.Location = new System.Drawing.Point(8, 27);
            this.labelIDReceta.Name = "labelIDReceta";
            this.labelIDReceta.Size = new System.Drawing.Size(41, 25);
            this.labelIDReceta.TabIndex = 1;
            this.labelIDReceta.Text = "ID";
            // 
            // labelReceta
            // 
            this.labelReceta.AutoSize = true;
            this.labelReceta.BackColor = System.Drawing.Color.Transparent;
            this.labelReceta.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceta.ForeColor = System.Drawing.Color.DimGray;
            this.labelReceta.Location = new System.Drawing.Point(433, 3);
            this.labelReceta.Name = "labelReceta";
            this.labelReceta.Size = new System.Drawing.Size(110, 38);
            this.labelReceta.TabIndex = 0;
            this.labelReceta.Text = "Receta";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridViewReceta);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(886, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewReceta
            // 
            this.dataGridViewReceta.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceta.GridColor = System.Drawing.Color.White;
            this.dataGridViewReceta.Location = new System.Drawing.Point(100, 104);
            this.dataGridViewReceta.Name = "dataGridViewReceta";
            this.dataGridViewReceta.Size = new System.Drawing.Size(750, 221);
            this.dataGridViewReceta.TabIndex = 11;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(759, 369);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(112, 34);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // fReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.tabReceta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.fReceta_Load);
            this.tabReceta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReceta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxPresentacionReceta;
        private System.Windows.Forms.Label labelPresentacionReceta;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxCantidadReceta;
        private System.Windows.Forms.TextBox textBoxNombreReceta;
        private System.Windows.Forms.TextBox textBoxIDReceta;
        private System.Windows.Forms.Label labelCantidadReceta;
        private System.Windows.Forms.Label labelNombreReceta;
        private System.Windows.Forms.Label labelIDReceta;
        private System.Windows.Forms.Label labelReceta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewReceta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxDescripcionReceta;
        private System.Windows.Forms.Label labelDescripcionReceta;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button button1;
    }
}

