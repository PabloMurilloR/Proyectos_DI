namespace GestionTelevisionPablo
{
    partial class Programacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarBT = new System.Windows.Forms.Button();
            this.titulotraducidoCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ContenidosTP = new System.Windows.Forms.TabPage();
            this.BorrarBT = new System.Windows.Forms.Button();
            this.ModoficarBT = new System.Windows.Forms.Button();
            this.NuevoBT = new System.Windows.Forms.Button();
            this.sinopsisTB = new System.Windows.Forms.TextBox();
            this.directorTB = new System.Windows.Forms.TextBox();
            this.actoresTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.duracionTB = new System.Windows.Forms.TextBox();
            this.anioTB = new System.Windows.Forms.TextBox();
            this.subgeneroCB = new System.Windows.Forms.ComboBox();
            this.ratingCB = new System.Windows.Forms.ComboBox();
            this.generoCB = new System.Windows.Forms.ComboBox();
            this.ppCB = new System.Windows.Forms.ComboBox();
            this.tituloCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventosTP = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SalirProg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ContenidosTP.SuspendLayout();
            this.EventosTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuscarBT);
            this.groupBox1.Controls.Add(this.titulotraducidoCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Título / Descripción";
            // 
            // BuscarBT
            // 
            this.BuscarBT.Location = new System.Drawing.Point(654, 28);
            this.BuscarBT.Name = "BuscarBT";
            this.BuscarBT.Size = new System.Drawing.Size(85, 23);
            this.BuscarBT.TabIndex = 2;
            this.BuscarBT.Text = "Buscar";
            this.BuscarBT.UseVisualStyleBackColor = true;
            this.BuscarBT.Click += new System.EventHandler(this.BuscarBT_Click);
            // 
            // titulotraducidoCB
            // 
            this.titulotraducidoCB.FormattingEnabled = true;
            this.titulotraducidoCB.Location = new System.Drawing.Point(108, 30);
            this.titulotraducidoCB.Name = "titulotraducidoCB";
            this.titulotraducidoCB.Size = new System.Drawing.Size(540, 21);
            this.titulotraducidoCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título traducido";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ContenidosTP);
            this.tabControl1.Controls.Add(this.EventosTP);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(13, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // ContenidosTP
            // 
            this.ContenidosTP.Controls.Add(this.BorrarBT);
            this.ContenidosTP.Controls.Add(this.ModoficarBT);
            this.ContenidosTP.Controls.Add(this.NuevoBT);
            this.ContenidosTP.Controls.Add(this.sinopsisTB);
            this.ContenidosTP.Controls.Add(this.directorTB);
            this.ContenidosTP.Controls.Add(this.actoresTB);
            this.ContenidosTP.Controls.Add(this.label12);
            this.ContenidosTP.Controls.Add(this.duracionTB);
            this.ContenidosTP.Controls.Add(this.anioTB);
            this.ContenidosTP.Controls.Add(this.subgeneroCB);
            this.ContenidosTP.Controls.Add(this.ratingCB);
            this.ContenidosTP.Controls.Add(this.generoCB);
            this.ContenidosTP.Controls.Add(this.ppCB);
            this.ContenidosTP.Controls.Add(this.tituloCB);
            this.ContenidosTP.Controls.Add(this.label11);
            this.ContenidosTP.Controls.Add(this.label10);
            this.ContenidosTP.Controls.Add(this.label9);
            this.ContenidosTP.Controls.Add(this.label8);
            this.ContenidosTP.Controls.Add(this.label7);
            this.ContenidosTP.Controls.Add(this.label6);
            this.ContenidosTP.Controls.Add(this.label5);
            this.ContenidosTP.Controls.Add(this.label4);
            this.ContenidosTP.Controls.Add(this.label3);
            this.ContenidosTP.Controls.Add(this.label2);
            this.ContenidosTP.Location = new System.Drawing.Point(4, 22);
            this.ContenidosTP.Name = "ContenidosTP";
            this.ContenidosTP.Padding = new System.Windows.Forms.Padding(3);
            this.ContenidosTP.Size = new System.Drawing.Size(736, 335);
            this.ContenidosTP.TabIndex = 0;
            this.ContenidosTP.Text = "Contenidos";
            this.ContenidosTP.UseVisualStyleBackColor = true;
            // 
            // BorrarBT
            // 
            this.BorrarBT.Location = new System.Drawing.Point(632, 306);
            this.BorrarBT.Name = "BorrarBT";
            this.BorrarBT.Size = new System.Drawing.Size(75, 23);
            this.BorrarBT.TabIndex = 23;
            this.BorrarBT.Text = "Borrar";
            this.BorrarBT.UseVisualStyleBackColor = true;
            // 
            // ModoficarBT
            // 
            this.ModoficarBT.Location = new System.Drawing.Point(551, 306);
            this.ModoficarBT.Name = "ModoficarBT";
            this.ModoficarBT.Size = new System.Drawing.Size(75, 23);
            this.ModoficarBT.TabIndex = 22;
            this.ModoficarBT.Text = "Modificar";
            this.ModoficarBT.UseVisualStyleBackColor = true;
            // 
            // NuevoBT
            // 
            this.NuevoBT.Location = new System.Drawing.Point(468, 306);
            this.NuevoBT.Name = "NuevoBT";
            this.NuevoBT.Size = new System.Drawing.Size(75, 23);
            this.NuevoBT.TabIndex = 21;
            this.NuevoBT.Text = "Nuevo";
            this.NuevoBT.UseVisualStyleBackColor = true;
            // 
            // sinopsisTB
            // 
            this.sinopsisTB.Location = new System.Drawing.Point(18, 241);
            this.sinopsisTB.Multiline = true;
            this.sinopsisTB.Name = "sinopsisTB";
            this.sinopsisTB.Size = new System.Drawing.Size(689, 63);
            this.sinopsisTB.TabIndex = 20;
            // 
            // directorTB
            // 
            this.directorTB.Location = new System.Drawing.Point(64, 191);
            this.directorTB.Name = "directorTB";
            this.directorTB.Size = new System.Drawing.Size(643, 20);
            this.directorTB.TabIndex = 19;
            // 
            // actoresTB
            // 
            this.actoresTB.Location = new System.Drawing.Point(64, 161);
            this.actoresTB.Name = "actoresTB";
            this.actoresTB.Size = new System.Drawing.Size(643, 20);
            this.actoresTB.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(656, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "hh:mm:ss";
            // 
            // duracionTB
            // 
            this.duracionTB.Location = new System.Drawing.Point(468, 122);
            this.duracionTB.Name = "duracionTB";
            this.duracionTB.Size = new System.Drawing.Size(182, 20);
            this.duracionTB.TabIndex = 16;
            // 
            // anioTB
            // 
            this.anioTB.Location = new System.Drawing.Point(468, 61);
            this.anioTB.Name = "anioTB";
            this.anioTB.Size = new System.Drawing.Size(239, 20);
            this.anioTB.TabIndex = 15;
            // 
            // subgeneroCB
            // 
            this.subgeneroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subgeneroCB.FormattingEnabled = true;
            this.subgeneroCB.Location = new System.Drawing.Point(468, 91);
            this.subgeneroCB.Name = "subgeneroCB";
            this.subgeneroCB.Size = new System.Drawing.Size(239, 21);
            this.subgeneroCB.TabIndex = 14;
            // 
            // ratingCB
            // 
            this.ratingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingCB.FormattingEnabled = true;
            this.ratingCB.Location = new System.Drawing.Point(105, 121);
            this.ratingCB.Name = "ratingCB";
            this.ratingCB.Size = new System.Drawing.Size(239, 21);
            this.ratingCB.TabIndex = 13;
            // 
            // generoCB
            // 
            this.generoCB.Enabled = false;
            this.generoCB.FormattingEnabled = true;
            this.generoCB.Location = new System.Drawing.Point(105, 91);
            this.generoCB.Name = "generoCB";
            this.generoCB.Size = new System.Drawing.Size(239, 21);
            this.generoCB.TabIndex = 12;
            // 
            // ppCB
            // 
            this.ppCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ppCB.FormattingEnabled = true;
            this.ppCB.Location = new System.Drawing.Point(105, 61);
            this.ppCB.Name = "ppCB";
            this.ppCB.Size = new System.Drawing.Size(239, 21);
            this.ppCB.TabIndex = 11;
            // 
            // tituloCB
            // 
            this.tituloCB.FormattingEnabled = true;
            this.tituloCB.Location = new System.Drawing.Point(56, 19);
            this.tituloCB.Name = "tituloCB";
            this.tituloCB.Size = new System.Drawing.Size(651, 21);
            this.tituloCB.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Duración";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Subgénero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Año Producción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sinopsis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Actores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pais Producción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título";
            // 
            // EventosTP
            // 
            this.EventosTP.Controls.Add(this.dataGridView1);
            this.EventosTP.Location = new System.Drawing.Point(4, 22);
            this.EventosTP.Name = "EventosTP";
            this.EventosTP.Padding = new System.Windows.Forms.Padding(3);
            this.EventosTP.Size = new System.Drawing.Size(736, 335);
            this.EventosTP.TabIndex = 1;
            this.EventosTP.Text = "Eventos";
            this.EventosTP.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // SalirProg
            // 
            this.SalirProg.Location = new System.Drawing.Point(682, 461);
            this.SalirProg.Name = "SalirProg";
            this.SalirProg.Size = new System.Drawing.Size(75, 23);
            this.SalirProg.TabIndex = 2;
            this.SalirProg.Text = "Salir >>";
            this.SalirProg.UseVisualStyleBackColor = true;
            this.SalirProg.Click += new System.EventHandler(this.SalirProg_Click);
            // 
            // Programacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 487);
            this.Controls.Add(this.SalirProg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Programacion";
            this.Text = "Programacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ContenidosTP.ResumeLayout(false);
            this.ContenidosTP.PerformLayout();
            this.EventosTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarBT;
        private System.Windows.Forms.ComboBox titulotraducidoCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ContenidosTP;
        private System.Windows.Forms.TabPage EventosTP;
        private System.Windows.Forms.Button SalirProg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox ratingCB;
        private System.Windows.Forms.ComboBox generoCB;
        private System.Windows.Forms.ComboBox ppCB;
        private System.Windows.Forms.ComboBox tituloCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sinopsisTB;
        private System.Windows.Forms.TextBox directorTB;
        private System.Windows.Forms.TextBox actoresTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox duracionTB;
        private System.Windows.Forms.TextBox anioTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BorrarBT;
        private System.Windows.Forms.Button ModoficarBT;
        private System.Windows.Forms.Button NuevoBT;
        private System.Windows.Forms.ComboBox subgeneroCB;
    }
}