namespace ArkanoidPablo
{
    partial class Arkanoid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid));
            this.timerPelota = new System.Windows.Forms.Timer(this.components);
            this.barra = new System.Windows.Forms.PictureBox();
            this.barra1 = new System.Windows.Forms.PictureBox();
            this.pelota = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerBarra = new System.Windows.Forms.Timer(this.components);
            this.vida3 = new System.Windows.Forms.PictureBox();
            this.vida2 = new System.Windows.Forms.PictureBox();
            this.vida1 = new System.Windows.Forms.PictureBox();
            this.bloquesImg = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPelota
            // 
            this.timerPelota.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.Transparent;
            this.barra.Image = ((System.Drawing.Image)(resources.GetObject("barra.Image")));
            this.barra.Location = new System.Drawing.Point(182, 419);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(94, 25);
            this.barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barra.TabIndex = 1;
            this.barra.TabStop = false;
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.barra1.ErrorImage = null;
            this.barra1.Image = ((System.Drawing.Image)(resources.GetObject("barra1.Image")));
            this.barra1.Location = new System.Drawing.Point(192, 418);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(79, 21);
            this.barra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barra1.TabIndex = 27;
            this.barra1.TabStop = false;
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.Color.Transparent;
            this.pelota.Image = ((System.Drawing.Image)(resources.GetObject("pelota.Image")));
            this.pelota.Location = new System.Drawing.Point(222, 397);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(20, 21);
            this.pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pelota.TabIndex = 28;
            this.pelota.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 37);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // timerBarra
            // 
            this.timerBarra.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // vida3
            // 
            this.vida3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vida3.Image = ((System.Drawing.Image)(resources.GetObject("vida3.Image")));
            this.vida3.Location = new System.Drawing.Point(12, 462);
            this.vida3.Name = "vida3";
            this.vida3.Size = new System.Drawing.Size(25, 25);
            this.vida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vida3.TabIndex = 60;
            this.vida3.TabStop = false;
            // 
            // vida2
            // 
            this.vida2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vida2.Image = ((System.Drawing.Image)(resources.GetObject("vida2.Image")));
            this.vida2.Location = new System.Drawing.Point(43, 462);
            this.vida2.Name = "vida2";
            this.vida2.Size = new System.Drawing.Size(25, 25);
            this.vida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vida2.TabIndex = 61;
            this.vida2.TabStop = false;
            // 
            // vida1
            // 
            this.vida1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vida1.Image = ((System.Drawing.Image)(resources.GetObject("vida1.Image")));
            this.vida1.Location = new System.Drawing.Point(74, 462);
            this.vida1.Name = "vida1";
            this.vida1.Size = new System.Drawing.Size(25, 25);
            this.vida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vida1.TabIndex = 62;
            this.vida1.TabStop = false;
            // 
            // bloquesImg
            // 
            this.bloquesImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bloquesImg.ImageStream")));
            this.bloquesImg.TransparentColor = System.Drawing.Color.Transparent;
            this.bloquesImg.Images.SetKeyName(0, "bAmarillo.png");
            this.bloquesImg.Images.SetKeyName(1, "bAzulC.png");
            this.bloquesImg.Images.SetKeyName(2, "bAzulO.png");
            this.bloquesImg.Images.SetKeyName(3, "bGris.png");
            this.bloquesImg.Images.SetKeyName(4, "bMarron.png");
            this.bloquesImg.Images.SetKeyName(5, "bMorado.png");
            this.bloquesImg.Images.SetKeyName(6, "bNaranja.png");
            this.bloquesImg.Images.SetKeyName(7, "bRojo.png");
            this.bloquesImg.Images.SetKeyName(8, "bVerdeC.png");
            this.bloquesImg.Images.SetKeyName(9, "bVerdeO.png");
            // 
            // Arkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 491);
            this.Controls.Add(this.vida1);
            this.Controls.Add(this.vida2);
            this.Controls.Add(this.vida3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pelota);
            this.Controls.Add(this.barra1);
            this.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Arkanoid";
            this.Text = "Arkanoid";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerPelota;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox barra;
        private System.Windows.Forms.PictureBox barra1;
        private System.Windows.Forms.PictureBox pelota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerBarra;
        private System.Windows.Forms.PictureBox vida3;
        private System.Windows.Forms.PictureBox vida2;
        private System.Windows.Forms.PictureBox vida1;
        private System.Windows.Forms.ImageList bloquesImg;
    }
}

