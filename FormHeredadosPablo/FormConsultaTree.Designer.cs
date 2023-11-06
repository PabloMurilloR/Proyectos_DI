namespace FormHeredadosPablo
{
    partial class FormConsultaTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaTree));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComentarioTV = new System.Windows.Forms.TextBox();
            this.EmailTV = new System.Windows.Forms.TextBox();
            this.CiudadTV = new System.Windows.Forms.TextBox();
            this.ApellidosTV = new System.Windows.Forms.TextBox();
            this.NombreTV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(29, 176);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(280, 251);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ComentarioTV
            // 
            this.ComentarioTV.Location = new System.Drawing.Point(468, 260);
            this.ComentarioTV.Multiline = true;
            this.ComentarioTV.Name = "ComentarioTV";
            this.ComentarioTV.Size = new System.Drawing.Size(271, 49);
            this.ComentarioTV.TabIndex = 25;
            // 
            // EmailTV
            // 
            this.EmailTV.Location = new System.Drawing.Point(468, 225);
            this.EmailTV.Name = "EmailTV";
            this.EmailTV.Size = new System.Drawing.Size(271, 20);
            this.EmailTV.TabIndex = 24;
            // 
            // CiudadTV
            // 
            this.CiudadTV.Location = new System.Drawing.Point(468, 192);
            this.CiudadTV.Name = "CiudadTV";
            this.CiudadTV.Size = new System.Drawing.Size(271, 20);
            this.CiudadTV.TabIndex = 23;
            // 
            // ApellidosTV
            // 
            this.ApellidosTV.Location = new System.Drawing.Point(468, 158);
            this.ApellidosTV.Name = "ApellidosTV";
            this.ApellidosTV.Size = new System.Drawing.Size(271, 20);
            this.ApellidosTV.TabIndex = 22;
            // 
            // NombreTV
            // 
            this.NombreTV.Location = new System.Drawing.Point(468, 122);
            this.NombreTV.Name = "NombreTV";
            this.NombreTV.Size = new System.Drawing.Size(271, 20);
            this.NombreTV.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Comentario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mundo.png");
            this.imageList1.Images.SetKeyName(1, "vip.png");
            this.imageList1.Images.SetKeyName(2, "usuario.png");
            // 
            // FormConsultaTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComentarioTV);
            this.Controls.Add(this.EmailTV);
            this.Controls.Add(this.CiudadTV);
            this.Controls.Add(this.ApellidosTV);
            this.Controls.Add(this.NombreTV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormConsultaTree";
            this.Text = "FormConsultaTree";
            this.Activated += new System.EventHandler(this.FormConsultaTree_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConsultaTree_FormClosed);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.NombreTV, 0);
            this.Controls.SetChildIndex(this.ApellidosTV, 0);
            this.Controls.SetChildIndex(this.CiudadTV, 0);
            this.Controls.SetChildIndex(this.EmailTV, 0);
            this.Controls.SetChildIndex(this.ComentarioTV, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox ComentarioTV;
        private System.Windows.Forms.TextBox EmailTV;
        private System.Windows.Forms.TextBox CiudadTV;
        private System.Windows.Forms.TextBox ApellidosTV;
        private System.Windows.Forms.TextBox NombreTV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}