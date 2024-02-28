namespace ExamenBibliotecaPablo
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
            this.CargaDatosLBL = new System.Windows.Forms.Label();
            this.CargarDatosBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroTB = new System.Windows.Forms.TextBox();
            this.filtrarBT = new System.Windows.Forms.Button();
            this.eliminarfiltroBT = new System.Windows.Forms.Button();
            this.editoresCB = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anioCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbnCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tituloRB = new System.Windows.Forms.RadioButton();
            this.anioRB = new System.Windows.Forms.RadioButton();
            this.isbnRB = new System.Windows.Forms.RadioButton();
            this.editoresRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CargaDatosLBL
            // 
            this.CargaDatosLBL.AutoSize = true;
            this.CargaDatosLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargaDatosLBL.ForeColor = System.Drawing.Color.Red;
            this.CargaDatosLBL.Location = new System.Drawing.Point(12, 14);
            this.CargaDatosLBL.Name = "CargaDatosLBL";
            this.CargaDatosLBL.Size = new System.Drawing.Size(163, 13);
            this.CargaDatosLBL.TabIndex = 0;
            this.CargaDatosLBL.Text = "Pulsa Cargar datos para empezar";
            // 
            // CargarDatosBT
            // 
            this.CargarDatosBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatosBT.Location = new System.Drawing.Point(48, 40);
            this.CargarDatosBT.Name = "CargarDatosBT";
            this.CargarDatosBT.Size = new System.Drawing.Size(80, 51);
            this.CargarDatosBT.TabIndex = 1;
            this.CargarDatosBT.Text = "Cargar datos";
            this.CargarDatosBT.UseVisualStyleBackColor = true;
            this.CargarDatosBT.Click += new System.EventHandler(this.CargarDatosBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto de búsqueda";
            // 
            // filtroTB
            // 
            this.filtroTB.Enabled = false;
            this.filtroTB.Location = new System.Drawing.Point(347, 43);
            this.filtroTB.Name = "filtroTB";
            this.filtroTB.Size = new System.Drawing.Size(313, 20);
            this.filtroTB.TabIndex = 6;
            // 
            // filtrarBT
            // 
            this.filtrarBT.Enabled = false;
            this.filtrarBT.Location = new System.Drawing.Point(675, 40);
            this.filtrarBT.Name = "filtrarBT";
            this.filtrarBT.Size = new System.Drawing.Size(75, 23);
            this.filtrarBT.TabIndex = 7;
            this.filtrarBT.Text = "Filtrar";
            this.filtrarBT.UseVisualStyleBackColor = true;
            this.filtrarBT.Click += new System.EventHandler(this.FiltrarBT_Click);
            // 
            // eliminarfiltroBT
            // 
            this.eliminarfiltroBT.Enabled = false;
            this.eliminarfiltroBT.Location = new System.Drawing.Point(772, 40);
            this.eliminarfiltroBT.Name = "eliminarfiltroBT";
            this.eliminarfiltroBT.Size = new System.Drawing.Size(75, 23);
            this.eliminarfiltroBT.TabIndex = 8;
            this.eliminarfiltroBT.Text = "Eliminar filtro";
            this.eliminarfiltroBT.UseVisualStyleBackColor = true;
            this.eliminarfiltroBT.Click += new System.EventHandler(this.EliminarfiltroBT_Click);
            // 
            // editoresCB
            // 
            this.editoresCB.Enabled = false;
            this.editoresCB.FormattingEnabled = true;
            this.editoresCB.Location = new System.Drawing.Point(347, 79);
            this.editoresCB.Name = "editoresCB";
            this.editoresCB.Size = new System.Drawing.Size(313, 21);
            this.editoresCB.Sorted = true;
            this.editoresCB.TabIndex = 10;
            this.editoresCB.SelectedIndexChanged += new System.EventHandler(this.EditoresCB_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaCH,
            this.anioCH,
            this.isbnCH});
            this.listView1.Location = new System.Drawing.Point(15, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(882, 339);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnaCH
            // 
            this.columnaCH.Text = "Titulo";
            this.columnaCH.Width = 655;
            // 
            // anioCH
            // 
            this.anioCH.Text = "Año";
            this.anioCH.Width = 54;
            // 
            // isbnCH
            // 
            this.isbnCH.Text = "ISBN";
            this.isbnCH.Width = 142;
            // 
            // tituloRB
            // 
            this.tituloRB.AutoSize = true;
            this.tituloRB.Enabled = false;
            this.tituloRB.Location = new System.Drawing.Point(184, 44);
            this.tituloRB.Name = "tituloRB";
            this.tituloRB.Size = new System.Drawing.Size(51, 17);
            this.tituloRB.TabIndex = 12;
            this.tituloRB.TabStop = true;
            this.tituloRB.Text = "Titulo";
            this.tituloRB.UseVisualStyleBackColor = true;
            this.tituloRB.CheckedChanged += new System.EventHandler(this.filtroTexto_CheckedChanged);
            // 
            // anioRB
            // 
            this.anioRB.AutoSize = true;
            this.anioRB.Enabled = false;
            this.anioRB.Location = new System.Drawing.Point(241, 44);
            this.anioRB.Name = "anioRB";
            this.anioRB.Size = new System.Drawing.Size(44, 17);
            this.anioRB.TabIndex = 13;
            this.anioRB.TabStop = true;
            this.anioRB.Text = "Año";
            this.anioRB.UseVisualStyleBackColor = true;
            this.anioRB.CheckedChanged += new System.EventHandler(this.filtroTexto_CheckedChanged);
            // 
            // isbnRB
            // 
            this.isbnRB.AutoSize = true;
            this.isbnRB.Enabled = false;
            this.isbnRB.Location = new System.Drawing.Point(291, 44);
            this.isbnRB.Name = "isbnRB";
            this.isbnRB.Size = new System.Drawing.Size(50, 17);
            this.isbnRB.TabIndex = 14;
            this.isbnRB.TabStop = true;
            this.isbnRB.Text = "ISBN";
            this.isbnRB.UseVisualStyleBackColor = true;
            this.isbnRB.CheckedChanged += new System.EventHandler(this.filtroTexto_CheckedChanged);
            // 
            // editoresRB
            // 
            this.editoresRB.AutoSize = true;
            this.editoresRB.Enabled = false;
            this.editoresRB.Location = new System.Drawing.Point(278, 80);
            this.editoresRB.Name = "editoresRB";
            this.editoresRB.Size = new System.Drawing.Size(63, 17);
            this.editoresRB.TabIndex = 15;
            this.editoresRB.TabStop = true;
            this.editoresRB.Text = "Editores";
            this.editoresRB.UseVisualStyleBackColor = true;
            this.editoresRB.CheckedChanged += new System.EventHandler(this.EditoresRB_CheckedChanged);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 462);
            this.Controls.Add(this.editoresRB);
            this.Controls.Add(this.isbnRB);
            this.Controls.Add(this.anioRB);
            this.Controls.Add(this.tituloRB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.editoresCB);
            this.Controls.Add(this.eliminarfiltroBT);
            this.Controls.Add(this.filtrarBT);
            this.Controls.Add(this.filtroTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CargarDatosBT);
            this.Controls.Add(this.CargaDatosLBL);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CargaDatosLBL;
        private System.Windows.Forms.Button CargarDatosBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroTB;
        private System.Windows.Forms.Button filtrarBT;
        private System.Windows.Forms.Button eliminarfiltroBT;
        private System.Windows.Forms.ComboBox editoresCB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnaCH;
        private System.Windows.Forms.ColumnHeader anioCH;
        private System.Windows.Forms.ColumnHeader isbnCH;
        private System.Windows.Forms.RadioButton tituloRB;
        private System.Windows.Forms.RadioButton anioRB;
        private System.Windows.Forms.RadioButton isbnRB;
        private System.Windows.Forms.RadioButton editoresRB;
    }
}