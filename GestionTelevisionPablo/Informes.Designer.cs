namespace GestionTelevisionPablo
{
    partial class Informes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BuscarBT = new System.Windows.Forms.Button();
            this.SalirBT = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TituloCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuracionCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnioCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActoresCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuscarBT);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Fecha y Canal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Programación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(374, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Canal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(414, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // BuscarBT
            // 
            this.BuscarBT.ForeColor = System.Drawing.Color.Black;
            this.BuscarBT.Location = new System.Drawing.Point(636, 28);
            this.BuscarBT.Name = "BuscarBT";
            this.BuscarBT.Size = new System.Drawing.Size(75, 23);
            this.BuscarBT.TabIndex = 5;
            this.BuscarBT.Text = "Buscar";
            this.BuscarBT.UseVisualStyleBackColor = true;
            // 
            // SalirBT
            // 
            this.SalirBT.ForeColor = System.Drawing.Color.Black;
            this.SalirBT.Location = new System.Drawing.Point(649, 452);
            this.SalirBT.Name = "SalirBT";
            this.SalirBT.Size = new System.Drawing.Size(75, 23);
            this.SalirBT.TabIndex = 6;
            this.SalirBT.Text = "Salir >>";
            this.SalirBT.UseVisualStyleBackColor = true;
            this.SalirBT.Click += new System.EventHandler(this.SalirBT_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TituloCH,
            this.DuracionCH,
            this.AnioCH,
            this.ActoresCH});
            this.listView1.Location = new System.Drawing.Point(13, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(744, 354);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TituloCH
            // 
            this.TituloCH.Text = "Título";
            this.TituloCH.Width = 139;
            // 
            // DuracionCH
            // 
            this.DuracionCH.Text = "Duración";
            this.DuracionCH.Width = 133;
            // 
            // AnioCH
            // 
            this.AnioCH.Text = "Año Producción";
            this.AnioCH.Width = 91;
            // 
            // ActoresCH
            // 
            this.ActoresCH.Text = "Actores";
            this.ActoresCH.Width = 377;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 487);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SalirBT);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informes";
            this.Text = "Informes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarBT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalirBT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TituloCH;
        private System.Windows.Forms.ColumnHeader DuracionCH;
        private System.Windows.Forms.ColumnHeader AnioCH;
        private System.Windows.Forms.ColumnHeader ActoresCH;
    }
}