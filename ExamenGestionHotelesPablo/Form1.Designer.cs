namespace ExamenGestionHotelesPablo
{
    partial class Form1
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
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheroReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.ficheroToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.ReservasToolStripMenuItem_Click);
            // 
            // ficheroToolStripMenuItem
            // 
            this.ficheroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheroClientesToolStripMenuItem,
            this.ficheroReservasToolStripMenuItem});
            this.ficheroToolStripMenuItem.Name = "ficheroToolStripMenuItem";
            this.ficheroToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ficheroToolStripMenuItem.Text = "Fichero";
            // 
            // ficheroClientesToolStripMenuItem
            // 
            this.ficheroClientesToolStripMenuItem.Name = "ficheroClientesToolStripMenuItem";
            this.ficheroClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ficheroClientesToolStripMenuItem.Text = "Fichero Clientes";
            this.ficheroClientesToolStripMenuItem.Click += new System.EventHandler(this.FicheroClientesToolStripMenuItem_Click);
            // 
            // ficheroReservasToolStripMenuItem
            // 
            this.ficheroReservasToolStripMenuItem.Name = "ficheroReservasToolStripMenuItem";
            this.ficheroReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ficheroReservasToolStripMenuItem.Text = "Fichero Reservas";
            this.ficheroReservasToolStripMenuItem.Click += new System.EventHandler(this.FicheroReservasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestion Hoteles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheroReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

