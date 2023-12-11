namespace ExamenGestionHotelesPablo
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.comentariosTB = new System.Windows.Forms.TextBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.apellidosTB = new System.Windows.Forms.TextBox();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.clientesCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.Borrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comentariosTB
            // 
            this.comentariosTB.Location = new System.Drawing.Point(529, 267);
            this.comentariosTB.Multiline = true;
            this.comentariosTB.Name = "comentariosTB";
            this.comentariosTB.Size = new System.Drawing.Size(193, 99);
            this.comentariosTB.TabIndex = 22;
            // 
            // telefonoTB
            // 
            this.telefonoTB.Location = new System.Drawing.Point(529, 213);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(193, 20);
            this.telefonoTB.TabIndex = 21;
            // 
            // apellidosTB
            // 
            this.apellidosTB.Location = new System.Drawing.Point(529, 154);
            this.apellidosTB.Name = "apellidosTB";
            this.apellidosTB.Size = new System.Drawing.Size(193, 20);
            this.apellidosTB.TabIndex = 20;
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(529, 92);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(193, 20);
            this.nombreTB.TabIndex = 19;
            // 
            // clientesCB
            // 
            this.clientesCB.FormattingEnabled = true;
            this.clientesCB.Location = new System.Drawing.Point(529, 43);
            this.clientesCB.Name = "clientesCB";
            this.clientesCB.Size = new System.Drawing.Size(193, 21);
            this.clientesCB.TabIndex = 18;
            this.clientesCB.SelectedIndexChanged += new System.EventHandler(this.ClientesCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Comentario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Guardar,
            this.Borrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Nuevo
            // 
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(46, 35);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(53, 35);
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(43, 35);
            this.Borrar.Text = "Borrar";
            this.Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comentariosTB);
            this.Controls.Add(this.telefonoTB);
            this.Controls.Add(this.apellidosTB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.clientesCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comentariosTB;
        private System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.TextBox apellidosTB;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.ComboBox clientesCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton Borrar;
    }
}