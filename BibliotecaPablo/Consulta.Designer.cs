namespace BibliotecaPablo
{
    partial class Consulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FotoPB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditorialRB = new System.Windows.Forms.RadioButton();
            this.AutorRB = new System.Windows.Forms.RadioButton();
            this.TituloLB = new System.Windows.Forms.ListBox();
            this.AutorEditorialLB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor/Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foto portada";
            // 
            // FotoPB
            // 
            this.FotoPB.BackColor = System.Drawing.Color.White;
            this.FotoPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoPB.Location = new System.Drawing.Point(459, 233);
            this.FotoPB.Name = "FotoPB";
            this.FotoPB.Size = new System.Drawing.Size(125, 184);
            this.FotoPB.TabIndex = 4;
            this.FotoPB.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditorialRB);
            this.groupBox1.Controls.Add(this.AutorRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de consulta";
            // 
            // EditorialRB
            // 
            this.EditorialRB.AutoSize = true;
            this.EditorialRB.Location = new System.Drawing.Point(17, 55);
            this.EditorialRB.Name = "EditorialRB";
            this.EditorialRB.Size = new System.Drawing.Size(84, 24);
            this.EditorialRB.TabIndex = 1;
            this.EditorialRB.TabStop = true;
            this.EditorialRB.Text = "Editorial";
            this.EditorialRB.UseVisualStyleBackColor = true;
            this.EditorialRB.CheckedChanged += new System.EventHandler(this.EditorialRB_CheckedChanged);
            // 
            // AutorRB
            // 
            this.AutorRB.AutoSize = true;
            this.AutorRB.Location = new System.Drawing.Point(17, 25);
            this.AutorRB.Name = "AutorRB";
            this.AutorRB.Size = new System.Drawing.Size(66, 24);
            this.AutorRB.TabIndex = 0;
            this.AutorRB.TabStop = true;
            this.AutorRB.Text = "Autor";
            this.AutorRB.UseVisualStyleBackColor = true;
            this.AutorRB.CheckedChanged += new System.EventHandler(this.AutorRB_CheckedChanged);
            // 
            // TituloLB
            // 
            this.TituloLB.FormattingEnabled = true;
            this.TituloLB.ItemHeight = 15;
            this.TituloLB.Location = new System.Drawing.Point(33, 233);
            this.TituloLB.Name = "TituloLB";
            this.TituloLB.Size = new System.Drawing.Size(120, 184);
            this.TituloLB.TabIndex = 8;
            this.TituloLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TituloLB_MouseDoubleClick);
            // 
            // AutorEditorialLB
            // 
            this.AutorEditorialLB.FormattingEnabled = true;
            this.AutorEditorialLB.ItemHeight = 15;
            this.AutorEditorialLB.Location = new System.Drawing.Point(246, 233);
            this.AutorEditorialLB.Name = "AutorEditorialLB";
            this.AutorEditorialLB.Size = new System.Drawing.Size(130, 184);
            this.AutorEditorialLB.TabIndex = 9;
            this.AutorEditorialLB.SelectedIndexChanged += new System.EventHandler(this.AutorEditorialLB_SelectedIndexChanged);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(631, 446);
            this.ControlBox = false;
            this.Controls.Add(this.AutorEditorialLB);
            this.Controls.Add(this.TituloLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FotoPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Click += new System.EventHandler(this.Consulta_Click);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox FotoPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EditorialRB;
        private System.Windows.Forms.RadioButton AutorRB;
        private System.Windows.Forms.ListBox TituloLB;
        private System.Windows.Forms.ListBox AutorEditorialLB;
    }
}