namespace BibliotecaPablo
{
    partial class Alta
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.Editorial = new System.Windows.Forms.Label();
            this.Nuevo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.CargarFoto = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TituloAlta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(81, 125);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(37, 15);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Titulo";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(81, 158);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(35, 15);
            this.Autor.TabIndex = 1;
            this.Autor.Text = "Autor";
            // 
            // Editorial
            // 
            this.Editorial.AutoSize = true;
            this.Editorial.Location = new System.Drawing.Point(81, 188);
            this.Editorial.Name = "Editorial";
            this.Editorial.Size = new System.Drawing.Size(52, 15);
            this.Editorial.TabIndex = 2;
            this.Editorial.Text = "Editorial";
            // 
            // Nuevo
            // 
            this.Nuevo.AutoSize = true;
            this.Nuevo.Location = new System.Drawing.Point(81, 218);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(42, 15);
            this.Nuevo.TabIndex = 3;
            this.Nuevo.Text = "Nuevo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 21);
            this.textBox3.TabIndex = 6;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(84, 274);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(87, 27);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(271, 274);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(87, 27);
            this.Limpiar.TabIndex = 9;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // CargarFoto
            // 
            this.CargarFoto.Location = new System.Drawing.Point(466, 274);
            this.CargarFoto.Name = "CargarFoto";
            this.CargarFoto.Size = new System.Drawing.Size(87, 27);
            this.CargarFoto.TabIndex = 10;
            this.CargarFoto.Text = "Cargar Foto";
            this.CargarFoto.UseVisualStyleBackColor = true;
            this.CargarFoto.Click += new System.EventHandler(this.CargarFoto_Click);
            // 
            // Imagen
            // 
            this.Imagen.BackColor = System.Drawing.Color.White;
            this.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imagen.Location = new System.Drawing.Point(466, 125);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(87, 115);
            this.Imagen.TabIndex = 11;
            this.Imagen.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 218);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TituloAlta
            // 
            this.TituloAlta.AutoSize = true;
            this.TituloAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloAlta.Location = new System.Drawing.Point(252, 54);
            this.TituloAlta.Name = "TituloAlta";
            this.TituloAlta.Size = new System.Drawing.Size(118, 24);
            this.TituloAlta.TabIndex = 13;
            this.TituloAlta.Text = "Alta de libros";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 446);
            this.ControlBox = false;
            this.Controls.Add(this.TituloAlta);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.CargarFoto);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Editorial);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label Editorial;
        private System.Windows.Forms.Label Nuevo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button CargarFoto;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label TituloAlta;
    }
}