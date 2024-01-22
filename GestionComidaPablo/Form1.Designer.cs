namespace Recuperacion1EvaPablo
{
    partial class TiendaAlimentacion
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
            this.AutorLB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutorLB
            // 
            this.AutorLB.AutoSize = true;
            this.AutorLB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AutorLB.Enabled = false;
            this.AutorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorLB.Location = new System.Drawing.Point(12, 423);
            this.AutorLB.Name = "AutorLB";
            this.AutorLB.Size = new System.Drawing.Size(226, 18);
            this.AutorLB.TabIndex = 1;
            this.AutorLB.Text = "Autor: Pablo Murillo Retuerta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.modificarTreeToolStripMenuItem,
            this.cargarDocumentoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Enabled = false;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // modificarTreeToolStripMenuItem
            // 
            this.modificarTreeToolStripMenuItem.Enabled = false;
            this.modificarTreeToolStripMenuItem.Name = "modificarTreeToolStripMenuItem";
            this.modificarTreeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.modificarTreeToolStripMenuItem.Text = "Modificar Tree";
            this.modificarTreeToolStripMenuItem.Click += new System.EventHandler(this.ModificarTreeToolStripMenuItem_Click);
            // 
            // cargarDocumentoToolStripMenuItem
            // 
            this.cargarDocumentoToolStripMenuItem.Name = "cargarDocumentoToolStripMenuItem";
            this.cargarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.cargarDocumentoToolStripMenuItem.Text = "Cargar producto";
            this.cargarDocumentoToolStripMenuItem.Click += new System.EventHandler(this.CargarDocumentoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // TiendaAlimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AutorLB);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TiendaAlimentacion";
            this.Text = "Tienda de alimentacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AutorLB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

