namespace GestionTelevisionPablo
{
    partial class Usuarios
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
            this.GbFind = new System.Windows.Forms.GroupBox();
            this.LblLog1 = new System.Windows.Forms.Label();
            this.UsuarioCB = new System.Windows.Forms.ComboBox();
            this.GbData = new System.Windows.Forms.GroupBox();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.EstadoCH = new System.Windows.Forms.CheckBox();
            this.LblState = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblSur = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLog2 = new System.Windows.Forms.Label();
            this.NuevoBT = new System.Windows.Forms.Button();
            this.ModificarBT = new System.Windows.Forms.Button();
            this.BorrarBT = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GbFind.SuspendLayout();
            this.GbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFind
            // 
            this.GbFind.Controls.Add(this.LblLog1);
            this.GbFind.Controls.Add(this.UsuarioCB);
            this.GbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFind.ForeColor = System.Drawing.Color.Blue;
            this.GbFind.Location = new System.Drawing.Point(40, 20);
            this.GbFind.Name = "GbFind";
            this.GbFind.Size = new System.Drawing.Size(700, 100);
            this.GbFind.TabIndex = 0;
            this.GbFind.TabStop = false;
            this.GbFind.Text = "Buscar";
            // 
            // LblLog1
            // 
            this.LblLog1.AutoSize = true;
            this.LblLog1.ForeColor = System.Drawing.Color.Black;
            this.LblLog1.Location = new System.Drawing.Point(50, 45);
            this.LblLog1.Name = "LblLog1";
            this.LblLog1.Size = new System.Drawing.Size(48, 18);
            this.LblLog1.TabIndex = 1;
            this.LblLog1.Text = "Login:";
            // 
            // UsuarioCB
            // 
            this.UsuarioCB.FormattingEnabled = true;
            this.UsuarioCB.Location = new System.Drawing.Point(200, 42);
            this.UsuarioCB.Name = "UsuarioCB";
            this.UsuarioCB.Size = new System.Drawing.Size(400, 26);
            this.UsuarioCB.TabIndex = 0;
            this.UsuarioCB.SelectedIndexChanged += new System.EventHandler(this.UsuarioCB_SelectedIndexChanged);
            // 
            // GbData
            // 
            this.GbData.Controls.Add(this.ApellidoTB);
            this.GbData.Controls.Add(this.NombreTB);
            this.GbData.Controls.Add(this.PassTB);
            this.GbData.Controls.Add(this.LoginTB);
            this.GbData.Controls.Add(this.EstadoCH);
            this.GbData.Controls.Add(this.LblState);
            this.GbData.Controls.Add(this.LblPass);
            this.GbData.Controls.Add(this.LblSur);
            this.GbData.Controls.Add(this.LblName);
            this.GbData.Controls.Add(this.LblLog2);
            this.GbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbData.ForeColor = System.Drawing.Color.Blue;
            this.GbData.Location = new System.Drawing.Point(40, 150);
            this.GbData.Name = "GbData";
            this.GbData.Size = new System.Drawing.Size(700, 250);
            this.GbData.TabIndex = 1;
            this.GbData.TabStop = false;
            this.GbData.Text = "Datos del Usuario";
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(120, 197);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(535, 24);
            this.ApellidoTB.TabIndex = 11;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(120, 122);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(309, 24);
            this.NombreTB.TabIndex = 10;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(455, 47);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(200, 24);
            this.PassTB.TabIndex = 9;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(120, 47);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(200, 24);
            this.LoginTB.TabIndex = 8;
            // 
            // EstadoCH
            // 
            this.EstadoCH.AutoSize = true;
            this.EstadoCH.Location = new System.Drawing.Point(579, 129);
            this.EstadoCH.Name = "EstadoCH";
            this.EstadoCH.Size = new System.Drawing.Size(15, 14);
            this.EstadoCH.TabIndex = 7;
            this.EstadoCH.UseVisualStyleBackColor = true;
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.ForeColor = System.Drawing.Color.Black;
            this.LblState.Location = new System.Drawing.Point(600, 125);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(55, 18);
            this.LblState.TabIndex = 6;
            this.LblState.Text = "Estado";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.ForeColor = System.Drawing.Color.Black;
            this.LblPass.Location = new System.Drawing.Point(350, 50);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(79, 18);
            this.LblPass.TabIndex = 5;
            this.LblPass.Text = "Password:";
            // 
            // LblSur
            // 
            this.LblSur.AutoSize = true;
            this.LblSur.ForeColor = System.Drawing.Color.Black;
            this.LblSur.Location = new System.Drawing.Point(50, 200);
            this.LblSur.Name = "LblSur";
            this.LblSur.Size = new System.Drawing.Size(63, 18);
            this.LblSur.TabIndex = 4;
            this.LblSur.Text = "Apellido:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.ForeColor = System.Drawing.Color.Black;
            this.LblName.Location = new System.Drawing.Point(50, 125);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(66, 18);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Nombre:";
            // 
            // LblLog2
            // 
            this.LblLog2.AutoSize = true;
            this.LblLog2.ForeColor = System.Drawing.Color.Black;
            this.LblLog2.Location = new System.Drawing.Point(50, 50);
            this.LblLog2.Name = "LblLog2";
            this.LblLog2.Size = new System.Drawing.Size(48, 18);
            this.LblLog2.TabIndex = 2;
            this.LblLog2.Text = "Login:";
            // 
            // NuevoBT
            // 
            this.NuevoBT.Location = new System.Drawing.Point(40, 421);
            this.NuevoBT.Name = "NuevoBT";
            this.NuevoBT.Size = new System.Drawing.Size(75, 23);
            this.NuevoBT.TabIndex = 2;
            this.NuevoBT.Text = "Nuevo";
            this.NuevoBT.UseVisualStyleBackColor = true;
            // 
            // ModificarBT
            // 
            this.ModificarBT.Location = new System.Drawing.Point(142, 421);
            this.ModificarBT.Name = "ModificarBT";
            this.ModificarBT.Size = new System.Drawing.Size(75, 23);
            this.ModificarBT.TabIndex = 3;
            this.ModificarBT.Text = "Modificar";
            this.ModificarBT.UseVisualStyleBackColor = true;
            // 
            // BorrarBT
            // 
            this.BorrarBT.Location = new System.Drawing.Point(240, 421);
            this.BorrarBT.Name = "BorrarBT";
            this.BorrarBT.Size = new System.Drawing.Size(75, 23);
            this.BorrarBT.TabIndex = 4;
            this.BorrarBT.Text = "Borrar";
            this.BorrarBT.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(665, 421);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Cancelar";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 487);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BorrarBT);
            this.Controls.Add(this.ModificarBT);
            this.Controls.Add(this.NuevoBT);
            this.Controls.Add(this.GbData);
            this.Controls.Add(this.GbFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento de Usuarios";
            this.GbFind.ResumeLayout(false);
            this.GbFind.PerformLayout();
            this.GbData.ResumeLayout(false);
            this.GbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbFind;
        private System.Windows.Forms.GroupBox GbData;
        private System.Windows.Forms.Button NuevoBT;
        private System.Windows.Forms.Button ModificarBT;
        private System.Windows.Forms.Button BorrarBT;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ComboBox UsuarioCB;
        private System.Windows.Forms.Label LblLog1;
        private System.Windows.Forms.CheckBox EstadoCH;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblSur;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLog2;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox PassTB;
    }
}