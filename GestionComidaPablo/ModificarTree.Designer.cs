namespace Recuperacion1EvaPablo
{
    partial class ModificarTree
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.IdLB = new System.Windows.Forms.Label();
            this.PrecioLB = new System.Windows.Forms.Label();
            this.NombreLB = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.PrecioTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(237, 348);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // IdLB
            // 
            this.IdLB.AutoSize = true;
            this.IdLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLB.Location = new System.Drawing.Point(349, 100);
            this.IdLB.Name = "IdLB";
            this.IdLB.Size = new System.Drawing.Size(25, 20);
            this.IdLB.TabIndex = 1;
            this.IdLB.Text = "Id";
            // 
            // PrecioLB
            // 
            this.PrecioLB.AutoSize = true;
            this.PrecioLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLB.Location = new System.Drawing.Point(349, 197);
            this.PrecioLB.Name = "PrecioLB";
            this.PrecioLB.Size = new System.Drawing.Size(59, 20);
            this.PrecioLB.TabIndex = 2;
            this.PrecioLB.Text = "Precio";
            // 
            // NombreLB
            // 
            this.NombreLB.AutoSize = true;
            this.NombreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLB.Location = new System.Drawing.Point(349, 150);
            this.NombreLB.Name = "NombreLB";
            this.NombreLB.Size = new System.Drawing.Size(71, 20);
            this.NombreLB.TabIndex = 3;
            this.NombreLB.Text = "Nombre";
            // 
            // IdTB
            // 
            this.IdTB.Enabled = false;
            this.IdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(462, 100);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(169, 22);
            this.IdTB.TabIndex = 4;
            this.IdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NombreTB
            // 
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(462, 152);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(169, 22);
            this.NombreTB.TabIndex = 5;
            this.NombreTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(431, 296);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // PrecioTB
            // 
            this.PrecioTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTB.Location = new System.Drawing.Point(462, 199);
            this.PrecioTB.Name = "PrecioTB";
            this.PrecioTB.Size = new System.Drawing.Size(169, 22);
            this.PrecioTB.TabIndex = 8;
            this.PrecioTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModificarTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.PrecioTB);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.NombreTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.NombreLB);
            this.Controls.Add(this.PrecioLB);
            this.Controls.Add(this.IdLB);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarTree";
            this.Text = "ModificarTree";
            this.Activated += new System.EventHandler(this.ModificarTree_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label IdLB;
        private System.Windows.Forms.Label PrecioLB;
        private System.Windows.Forms.Label NombreLB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox PrecioTB;
    }
}