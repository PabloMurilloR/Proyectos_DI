namespace FormHeredadosPablo
{
    partial class FormConsultaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CiudadCB = new System.Windows.Forms.ComboBox();
            this.VistaCB = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NombreCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApellidosCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComentarioCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImagenesPequenas = new System.Windows.Forms.ImageList(this.components);
            this.ImagenesGrandes = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vista";
            // 
            // CiudadCB
            // 
            this.CiudadCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.CiudadCB.FormattingEnabled = true;
            this.CiudadCB.Location = new System.Drawing.Point(215, 113);
            this.CiudadCB.Name = "CiudadCB";
            this.CiudadCB.Size = new System.Drawing.Size(270, 21);
            this.CiudadCB.TabIndex = 4;
            this.CiudadCB.SelectedIndexChanged += new System.EventHandler(this.CiudadCB_SelectedIndexChanged);
            // 
            // VistaCB
            // 
            this.VistaCB.FormattingEnabled = true;
            this.VistaCB.Items.AddRange(new object[] {
            "Iconos pequeños",
            "Iconos grandes"});
            this.VistaCB.Location = new System.Drawing.Point(554, 113);
            this.VistaCB.Name = "VistaCB";
            this.VistaCB.Size = new System.Drawing.Size(143, 21);
            this.VistaCB.TabIndex = 5;
            this.VistaCB.SelectedIndexChanged += new System.EventHandler(this.VistaCB_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreCH,
            this.ApellidosCH,
            this.EmailCH,
            this.ComentarioCH});
            this.listView1.Location = new System.Drawing.Point(25, 187);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 251);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NombreCH
            // 
            this.NombreCH.Text = "Nombre";
            this.NombreCH.Width = 111;
            // 
            // ApellidosCH
            // 
            this.ApellidosCH.Text = "Apellidos";
            this.ApellidosCH.Width = 154;
            // 
            // EmailCH
            // 
            this.EmailCH.Text = "Email";
            this.EmailCH.Width = 176;
            // 
            // ComentarioCH
            // 
            this.ComentarioCH.Text = "Comentario";
            this.ComentarioCH.Width = 301;
            // 
            // ImagenesPequenas
            // 
            this.ImagenesPequenas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagenesPequenas.ImageStream")));
            this.ImagenesPequenas.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagenesPequenas.Images.SetKeyName(0, "vip.png");
            this.ImagenesPequenas.Images.SetKeyName(1, "usuario.png");
            // 
            // ImagenesGrandes
            // 
            this.ImagenesGrandes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagenesGrandes.ImageStream")));
            this.ImagenesGrandes.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagenesGrandes.Images.SetKeyName(0, "vip.png");
            this.ImagenesGrandes.Images.SetKeyName(1, "usuario.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FormConsultaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.VistaCB);
            this.Controls.Add(this.CiudadCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormConsultaList";
            this.Text = "FormConsultaList";
            this.Activated += new System.EventHandler(this.FormConsultaList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConsultaList_FormClosed);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CiudadCB, 0);
            this.Controls.SetChildIndex(this.VistaCB, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CiudadCB;
        private System.Windows.Forms.ComboBox VistaCB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NombreCH;
        private System.Windows.Forms.ColumnHeader ApellidosCH;
        private System.Windows.Forms.ColumnHeader EmailCH;
        private System.Windows.Forms.ColumnHeader ComentarioCH;
        private System.Windows.Forms.ImageList ImagenesPequenas;
        private System.Windows.Forms.ImageList ImagenesGrandes;
    }
}