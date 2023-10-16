namespace FormHeredadosPablo
{
    partial class FormAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.Actualizar = new System.Windows.Forms.ToolStripButton();
            this.Borrar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientesLB = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.ApellidosTB = new System.Windows.Forms.TextBox();
            this.CiudadTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.ComentarioTB = new System.Windows.Forms.TextBox();
            this.VIPCB = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guardar,
            this.Actualizar,
            this.Borrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 56);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Guardar
            // 
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(53, 53);
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.Click += new System.EventHandler(this.OpcionesTS);
            // 
            // Actualizar
            // 
            this.Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar.Image")));
            this.Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(63, 53);
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Actualizar.Click += new System.EventHandler(this.OpcionesTS);
            // 
            // Borrar
            // 
            this.Borrar.Image = global::FormHeredadosPablo.Properties.Resources.borrar;
            this.Borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(43, 53);
            this.Borrar.Text = "Borrar";
            this.Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Borrar.Click += new System.EventHandler(this.OpcionesTS);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes";
            // 
            // ClientesLB
            // 
            this.ClientesLB.FormattingEnabled = true;
            this.ClientesLB.Location = new System.Drawing.Point(34, 159);
            this.ClientesLB.Name = "ClientesLB";
            this.ClientesLB.Size = new System.Drawing.Size(194, 251);
            this.ClientesLB.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Comentario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "VIP";
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(452, 212);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(266, 20);
            this.NombreTB.TabIndex = 11;
            // 
            // ApellidosTB
            // 
            this.ApellidosTB.Location = new System.Drawing.Point(452, 248);
            this.ApellidosTB.Name = "ApellidosTB";
            this.ApellidosTB.Size = new System.Drawing.Size(266, 20);
            this.ApellidosTB.TabIndex = 12;
            // 
            // CiudadTB
            // 
            this.CiudadTB.Location = new System.Drawing.Point(452, 282);
            this.CiudadTB.Name = "CiudadTB";
            this.CiudadTB.Size = new System.Drawing.Size(266, 20);
            this.CiudadTB.TabIndex = 13;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(452, 315);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(266, 20);
            this.EmailTB.TabIndex = 14;
            // 
            // ComentarioTB
            // 
            this.ComentarioTB.Location = new System.Drawing.Point(452, 350);
            this.ComentarioTB.Multiline = true;
            this.ComentarioTB.Name = "ComentarioTB";
            this.ComentarioTB.Size = new System.Drawing.Size(266, 47);
            this.ComentarioTB.TabIndex = 15;
            // 
            // VIPCB
            // 
            this.VIPCB.AutoSize = true;
            this.VIPCB.Location = new System.Drawing.Point(452, 408);
            this.VIPCB.Name = "VIPCB";
            this.VIPCB.Size = new System.Drawing.Size(15, 14);
            this.VIPCB.TabIndex = 16;
            this.VIPCB.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VIPCB);
            this.Controls.Add(this.ComentarioTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.CiudadTB);
            this.Controls.Add(this.ApellidosTB);
            this.Controls.Add(this.NombreTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientesLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ClientesLB, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.NombreTB, 0);
            this.Controls.SetChildIndex(this.ApellidosTB, 0);
            this.Controls.SetChildIndex(this.CiudadTB, 0);
            this.Controls.SetChildIndex(this.EmailTB, 0);
            this.Controls.SetChildIndex(this.ComentarioTB, 0);
            this.Controls.SetChildIndex(this.VIPCB, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton Actualizar;
        private System.Windows.Forms.ToolStripButton Borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ClientesLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox ApellidosTB;
        private System.Windows.Forms.TextBox CiudadTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox ComentarioTB;
        private System.Windows.Forms.CheckBox VIPCB;
    }
}