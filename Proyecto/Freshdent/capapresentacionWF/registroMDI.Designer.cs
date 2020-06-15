namespace capapresentacionWF
{
    partial class registroMDI
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ExpedienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EspecialidadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RecetaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CitaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpedienteMenu,
            this.MedicoMenu,
            this.ConsultaMenu,
            this.EspecialidadMenu,
            this.RecetaMenu,
            this.CitaMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.EspecialidadMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ExpedienteMenu
            // 
            this.ExpedienteMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExpedienteMenu.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpedienteMenu.ForeColor = System.Drawing.Color.White;
            this.ExpedienteMenu.Name = "ExpedienteMenu";
            this.ExpedienteMenu.Size = new System.Drawing.Size(94, 27);
            this.ExpedienteMenu.Text = "Expediente";
            this.ExpedienteMenu.Click += new System.EventHandler(this.ExpedienteMenu_Click);
            // 
            // MedicoMenu
            // 
            this.MedicoMenu.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.MedicoMenu.ForeColor = System.Drawing.Color.White;
            this.MedicoMenu.Name = "MedicoMenu";
            this.MedicoMenu.Size = new System.Drawing.Size(68, 27);
            this.MedicoMenu.Text = "Medico";
            this.MedicoMenu.Click += new System.EventHandler(this.MedicoMenu_Click);
            // 
            // ConsultaMenu
            // 
            this.ConsultaMenu.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.ConsultaMenu.ForeColor = System.Drawing.Color.White;
            this.ConsultaMenu.Name = "ConsultaMenu";
            this.ConsultaMenu.Size = new System.Drawing.Size(79, 27);
            this.ConsultaMenu.Text = "Consulta";
            this.ConsultaMenu.Click += new System.EventHandler(this.ConsultaMenu_Click);
            // 
            // EspecialidadMenu
            // 
            this.EspecialidadMenu.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.EspecialidadMenu.ForeColor = System.Drawing.Color.White;
            this.EspecialidadMenu.Name = "EspecialidadMenu";
            this.EspecialidadMenu.Size = new System.Drawing.Size(101, 27);
            this.EspecialidadMenu.Text = "Especialidad";
            this.EspecialidadMenu.Click += new System.EventHandler(this.EspecialidadMenu_Click);
            // 
            // RecetaMenu
            // 
            this.RecetaMenu.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.RecetaMenu.ForeColor = System.Drawing.Color.White;
            this.RecetaMenu.Name = "RecetaMenu";
            this.RecetaMenu.Size = new System.Drawing.Size(64, 27);
            this.RecetaMenu.Text = "Receta";
            this.RecetaMenu.Click += new System.EventHandler(this.RecetaMenu_Click);
            // 
            // CitaMenu
            // 
            this.CitaMenu.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.CitaMenu.ForeColor = System.Drawing.Color.White;
            this.CitaMenu.Name = "CitaMenu";
            this.CitaMenu.Size = new System.Drawing.Size(54, 27);
            this.CitaMenu.Text = "Citas";
            this.CitaMenu.Click += new System.EventHandler(this.CitaMenu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // registroMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::capapresentacionWF.Properties.Resources.logodental1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "registroMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registroMDI";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.registroMDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem EspecialidadMenu;
        private System.Windows.Forms.ToolStripMenuItem RecetaMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ExpedienteMenu;
        private System.Windows.Forms.ToolStripMenuItem MedicoMenu;
        private System.Windows.Forms.ToolStripMenuItem ConsultaMenu;
        private System.Windows.Forms.ToolStripMenuItem CitaMenu;
    }
}



