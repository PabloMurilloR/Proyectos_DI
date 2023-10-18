namespace FormHeredadosPablo
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaMS = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaListaMS = new System.Windows.Forms.ToolStripMenuItem();
            this.conultraTreeMS = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaMS,
            this.consultaListaMS,
            this.conultraTreeMS,
            this.salirMS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaMS
            // 
            this.altaMS.Name = "altaMS";
            this.altaMS.Size = new System.Drawing.Size(40, 20);
            this.altaMS.Text = "Alta";
            this.altaMS.Click += new System.EventHandler(this.OpcionMS);
            // 
            // consultaListaMS
            // 
            this.consultaListaMS.Name = "consultaListaMS";
            this.consultaListaMS.Size = new System.Drawing.Size(90, 20);
            this.consultaListaMS.Text = "Consulta lista";
            this.consultaListaMS.Click += new System.EventHandler(this.OpcionMS);
            // 
            // conultraTreeMS
            // 
            this.conultraTreeMS.Name = "conultraTreeMS";
            this.conultraTreeMS.Size = new System.Drawing.Size(89, 20);
            this.conultraTreeMS.Text = "Consulta tree";
            this.conultraTreeMS.Click += new System.EventHandler(this.OpcionMS);
            // 
            // salirMS
            // 
            this.salirMS.Name = "salirMS";
            this.salirMS.Size = new System.Drawing.Size(41, 20);
            this.salirMS.Text = "Salir";
            this.salirMS.Click += new System.EventHandler(this.OpcionMS);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Formularios Heredados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaMS;
        private System.Windows.Forms.ToolStripMenuItem consultaListaMS;
        private System.Windows.Forms.ToolStripMenuItem conultraTreeMS;
        private System.Windows.Forms.ToolStripMenuItem salirMS;
    }
}

