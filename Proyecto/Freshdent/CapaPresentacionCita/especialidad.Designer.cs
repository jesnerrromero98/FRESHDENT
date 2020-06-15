namespace CapaPresentacionCita
{
    partial class especialidad
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
            this.dataGridViewEspecialidad = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarExpediente = new System.Windows.Forms.Label();
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
            this.tabEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tabEspecialidad.Name = "tabEspecialidad";
            this.tabEspecialidad.SelectedIndex = 0;
            this.tabEspecialidad.Size = new System.Drawing.Size(800, 451);
            this.tabEspecialidad.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.Location = new System.Drawing.Point(311, 327);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(141, 40);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDescpEspecialidad
            // 
            this.textBoxDescpEspecialidad.Location = new System.Drawing.Point(359, 200);
            this.textBoxDescpEspecialidad.Multiline = true;
            this.textBoxDescpEspecialidad.Name = "textBoxDescpEspecialidad";
            this.textBoxDescpEspecialidad.Size = new System.Drawing.Size(250, 84);
            this.textBoxDescpEspecialidad.TabIndex = 6;
            // 
            // textBoxNombreEspecialidad
            // 
            this.textBoxNombreEspecialidad.Location = new System.Drawing.Point(359, 148);
            this.textBoxNombreEspecialidad.Multiline = true;
            this.textBoxNombreEspecialidad.Name = "textBoxNombreEspecialidad";
            this.textBoxNombreEspecialidad.Size = new System.Drawing.Size(154, 20);
            this.textBoxNombreEspecialidad.TabIndex = 5;
            // 
            // textBoxIDEspecialidad
            // 
            this.textBoxIDEspecialidad.Location = new System.Drawing.Point(242, 90);
            this.textBoxIDEspecialidad.Name = "textBoxIDEspecialidad";
            this.textBoxIDEspecialidad.Size = new System.Drawing.Size(132, 20);
            this.textBoxIDEspecialidad.TabIndex = 4;
            // 
            // labelDescpEspecialidad
            // 
            this.labelDescpEspecialidad.AutoSize = true;
            this.labelDescpEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescpEspecialidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDescpEspecialidad.Location = new System.Drawing.Point(157, 200);
            this.labelDescpEspecialidad.Name = "labelDescpEspecialidad";
            this.labelDescpEspecialidad.Size = new System.Drawing.Size(139, 25);
            this.labelDescpEspecialidad.TabIndex = 3;
            this.labelDescpEspecialidad.Text = "Descripción";
            // 
            // labelNombreEspecialidad
            // 
            this.labelNombreEspecialidad.AutoSize = true;
            this.labelNombreEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEspecialidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreEspecialidad.Location = new System.Drawing.Point(156, 142);
            this.labelNombreEspecialidad.Name = "labelNombreEspecialidad";
            this.labelNombreEspecialidad.Size = new System.Drawing.Size(94, 25);
            this.labelNombreEspecialidad.TabIndex = 2;
            this.labelNombreEspecialidad.Text = "Nombre";
            // 
            // labelIDEspecialidad
            // 
            this.labelIDEspecialidad.AutoSize = true;
            this.labelIDEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDEspecialidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIDEspecialidad.Location = new System.Drawing.Point(157, 85);
            this.labelIDEspecialidad.Name = "labelIDEspecialidad";
            this.labelIDEspecialidad.Size = new System.Drawing.Size(41, 25);
            this.labelIDEspecialidad.TabIndex = 1;
            this.labelIDEspecialidad.Text = "ID";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEspecialidad.Location = new System.Drawing.Point(304, 20);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(188, 38);
            this.labelEspecialidad.TabIndex = 0;
            this.labelEspecialidad.Text = "Especialidad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewEspecialidad);
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
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEspecialidad
            // 
            this.dataGridViewEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialidad.Location = new System.Drawing.Point(108, 143);
            this.dataGridViewEspecialidad.Name = "dataGridViewEspecialidad";
            this.dataGridViewEspecialidad.Size = new System.Drawing.Size(580, 227);
            this.dataGridViewEspecialidad.TabIndex = 11;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(613, 54);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(505, 54);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(398, 54);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(162, 54);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(191, 24);
            this.textBoxBuscar.TabIndex = 7;
            // 
            // labelBuscarExpediente
            // 
            this.labelBuscarExpediente.AutoSize = true;
            this.labelBuscarExpediente.Location = new System.Drawing.Point(105, 57);
            this.labelBuscarExpediente.Name = "labelBuscarExpediente";
            this.labelBuscarExpediente.Size = new System.Drawing.Size(40, 13);
            this.labelBuscarExpediente.TabIndex = 6;
            this.labelBuscarExpediente.Text = "Buscar";
            // 
            // especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEspecialidad);
            this.Name = "especialidad";
            this.Text = "especialidad";
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
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxDescpEspecialidad;
        private System.Windows.Forms.TextBox textBoxNombreEspecialidad;
        private System.Windows.Forms.TextBox textBoxIDEspecialidad;
        private System.Windows.Forms.Label labelDescpEspecialidad;
        private System.Windows.Forms.Label labelNombreEspecialidad;
        private System.Windows.Forms.Label labelIDEspecialidad;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewEspecialidad;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscarExpediente;
    }
}