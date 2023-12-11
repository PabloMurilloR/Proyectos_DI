namespace ExamenGestionHotelesPablo
{
    partial class Reserva
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            this.reservasLB = new System.Windows.Forms.ListView();
            this.clienteCM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaCM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoriaCM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriaLB = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservasLB
            // 
            this.reservasLB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clienteCM,
            this.fechaCM,
            this.categoriaCM});
            this.reservasLB.Location = new System.Drawing.Point(12, 168);
            this.reservasLB.Name = "reservasLB";
            this.reservasLB.Size = new System.Drawing.Size(776, 220);
            this.reservasLB.TabIndex = 8;
            this.reservasLB.UseCompatibleStateImageBehavior = false;
            this.reservasLB.View = System.Windows.Forms.View.Details;
            // 
            // clienteCM
            // 
            this.clienteCM.Text = "Cliente";
            this.clienteCM.Width = 238;
            // 
            // fechaCM
            // 
            this.fechaCM.Text = "Fecha";
            this.fechaCM.Width = 244;
            // 
            // categoriaCM
            // 
            this.categoriaCM.Text = "Categoria";
            this.categoriaCM.Width = 290;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoria";
            // 
            // CategoriaLB
            // 
            this.CategoriaLB.BackColor = System.Drawing.Color.DodgerBlue;
            this.CategoriaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLB.ForeColor = System.Drawing.Color.White;
            this.CategoriaLB.FormattingEnabled = true;
            this.CategoriaLB.Location = new System.Drawing.Point(299, 31);
            this.CategoriaLB.Name = "CategoriaLB";
            this.CategoriaLB.Size = new System.Drawing.Size(146, 108);
            this.CategoriaLB.TabIndex = 6;
            this.CategoriaLB.SelectedIndexChanged += new System.EventHandler(this.CategoriaLB_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarFiltroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // eliminarFiltroToolStripMenuItem
            // 
            this.eliminarFiltroToolStripMenuItem.Name = "eliminarFiltroToolStripMenuItem";
            this.eliminarFiltroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.eliminarFiltroToolStripMenuItem.Text = "Eliminar filtro";
            this.eliminarFiltroToolStripMenuItem.Click += new System.EventHandler(this.EliminarFiltroToolStripMenuItem_Click);
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.reservasLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriaLB);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reserva";
            this.Text = "Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView reservasLB;
        private System.Windows.Forms.ColumnHeader clienteCM;
        private System.Windows.Forms.ColumnHeader fechaCM;
        private System.Windows.Forms.ColumnHeader categoriaCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CategoriaLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarFiltroToolStripMenuItem;
    }
}