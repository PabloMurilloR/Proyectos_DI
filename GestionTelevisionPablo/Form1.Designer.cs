namespace GestionTelevisionPablo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.AceptarBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelarBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.UsuarioTB.Location = new System.Drawing.Point(322, 124);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(140, 20);
            this.UsuarioTB.TabIndex = 0;
            // 
            // PassTB
            // 
            this.PassTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.PassTB.Location = new System.Drawing.Point(322, 178);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(140, 20);
            this.PassTB.TabIndex = 1;
            // 
            // AceptarBT
            // 
            this.AceptarBT.BackColor = System.Drawing.Color.Transparent;
            this.AceptarBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AceptarBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.AceptarBT.Location = new System.Drawing.Point(243, 231);
            this.AceptarBT.Name = "AceptarBT";
            this.AceptarBT.Size = new System.Drawing.Size(84, 30);
            this.AceptarBT.TabIndex = 2;
            this.AceptarBT.Text = "Aceptar";
            this.AceptarBT.UseVisualStyleBackColor = false;
            this.AceptarBT.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(214, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(214, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // CancelarBT
            // 
            this.CancelarBT.BackColor = System.Drawing.Color.Transparent;
            this.CancelarBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.CancelarBT.Location = new System.Drawing.Point(364, 231);
            this.CancelarBT.Name = "CancelarBT";
            this.CancelarBT.Size = new System.Drawing.Size(84, 30);
            this.CancelarBT.TabIndex = 5;
            this.CancelarBT.Text = "Cancelar";
            this.CancelarBT.UseVisualStyleBackColor = false;
            this.CancelarBT.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AceptarBT);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UsuarioTB);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button AceptarBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelarBT;
    }
}

