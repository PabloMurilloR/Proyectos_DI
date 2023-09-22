namespace TriviaPablo
{
    partial class Form1
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
            this.MenuOpciones = new System.Windows.Forms.MenuStrip();
            this.partidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreCapitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombrePaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.múltiplesOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirRespuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Opcion1 = new System.Windows.Forms.Label();
            this.Pregunta = new System.Windows.Forms.TextBox();
            this.Opcion2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Respuesta1 = new System.Windows.Forms.TextBox();
            this.Respuesta2 = new System.Windows.Forms.TextBox();
            this.Respuesta3 = new System.Windows.Forms.TextBox();
            this.Respuesta4 = new System.Windows.Forms.TextBox();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.PorcentajeAcierto = new System.Windows.Forms.TextBox();
            this.MenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.MenuOpciones.Location = new System.Drawing.Point(0, 0);
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(303, 24);
            this.MenuOpciones.TabIndex = 0;
            this.MenuOpciones.Text = "menuStrip1";
            this.MenuOpciones.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuOpciones_ItemClicked);
            // 
            // partidaToolStripMenuItem
            // 
            this.partidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            this.partidaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.partidaToolStripMenuItem.Text = "&Partida";
            this.partidaToolStripMenuItem.Click += new System.EventHandler(this.PartidaToolStripMenuItem_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreCapitalesToolStripMenuItem,
            this.nombrePaisesToolStripMenuItem,
            this.toolStripSeparator2,
            this.múltiplesOpcionesToolStripMenuItem,
            this.escribirRespuestaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.OpcionesToolStripMenuItem_Click);
            // 
            // nombreCapitalesToolStripMenuItem
            // 
            this.nombreCapitalesToolStripMenuItem.Checked = true;
            this.nombreCapitalesToolStripMenuItem.CheckOnClick = true;
            this.nombreCapitalesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nombreCapitalesToolStripMenuItem.Name = "nombreCapitalesToolStripMenuItem";
            this.nombreCapitalesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nombreCapitalesToolStripMenuItem.Text = "Nombre Capitales";
            this.nombreCapitalesToolStripMenuItem.Click += new System.EventHandler(this.NombreCapitalesToolStripMenuItem_Click);
            // 
            // nombrePaisesToolStripMenuItem
            // 
            this.nombrePaisesToolStripMenuItem.CheckOnClick = true;
            this.nombrePaisesToolStripMenuItem.Name = "nombrePaisesToolStripMenuItem";
            this.nombrePaisesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nombrePaisesToolStripMenuItem.Text = "Nombre Paises";
            this.nombrePaisesToolStripMenuItem.Click += new System.EventHandler(this.NombrePaisesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // múltiplesOpcionesToolStripMenuItem
            // 
            this.múltiplesOpcionesToolStripMenuItem.Checked = true;
            this.múltiplesOpcionesToolStripMenuItem.CheckOnClick = true;
            this.múltiplesOpcionesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.múltiplesOpcionesToolStripMenuItem.Name = "múltiplesOpcionesToolStripMenuItem";
            this.múltiplesOpcionesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.múltiplesOpcionesToolStripMenuItem.Text = "Múltiples opciones";
            this.múltiplesOpcionesToolStripMenuItem.Click += new System.EventHandler(this.MúltiplesOpcionesToolStripMenuItem_Click);
            // 
            // escribirRespuestaToolStripMenuItem
            // 
            this.escribirRespuestaToolStripMenuItem.CheckOnClick = true;
            this.escribirRespuestaToolStripMenuItem.Name = "escribirRespuestaToolStripMenuItem";
            this.escribirRespuestaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.escribirRespuestaToolStripMenuItem.Text = "Escribir respuesta";
            this.escribirRespuestaToolStripMenuItem.Click += new System.EventHandler(this.EscribirRespuestaToolStripMenuItem_Click);
            // 
            // Opcion1
            // 
            this.Opcion1.AutoSize = true;
            this.Opcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion1.Location = new System.Drawing.Point(12, 29);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(38, 16);
            this.Opcion1.TabIndex = 1;
            this.Opcion1.Text = "Pais:";
            // 
            // Pregunta
            // 
            this.Pregunta.Enabled = false;
            this.Pregunta.Location = new System.Drawing.Point(12, 57);
            this.Pregunta.Multiline = true;
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(279, 41);
            this.Pregunta.TabIndex = 2;
            this.Pregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Opcion2
            // 
            this.Opcion2.AutoSize = true;
            this.Opcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion2.Location = new System.Drawing.Point(12, 115);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(53, 16);
            this.Opcion2.TabIndex = 3;
            this.Opcion2.Text = "Capital:";
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.Color.Yellow;
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultado.Enabled = false;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.Purple;
            this.Resultado.Location = new System.Drawing.Point(188, 113);
            this.Resultado.Name = "Resultado";
            this.Resultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Resultado.Size = new System.Drawing.Size(103, 22);
            this.Resultado.TabIndex = 4;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Respuesta1
            // 
            this.Respuesta1.Location = new System.Drawing.Point(12, 157);
            this.Respuesta1.Multiline = true;
            this.Respuesta1.Name = "Respuesta1";
            this.Respuesta1.ReadOnly = true;
            this.Respuesta1.Size = new System.Drawing.Size(279, 41);
            this.Respuesta1.TabIndex = 5;
            this.Respuesta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Respuesta1.Click += new System.EventHandler(this.Respuesta1_Click);
            this.Respuesta1.TextChanged += new System.EventHandler(this.Respuesta1_TextChanged);
            // 
            // Respuesta2
            // 
            this.Respuesta2.Location = new System.Drawing.Point(12, 204);
            this.Respuesta2.Multiline = true;
            this.Respuesta2.Name = "Respuesta2";
            this.Respuesta2.ReadOnly = true;
            this.Respuesta2.Size = new System.Drawing.Size(279, 41);
            this.Respuesta2.TabIndex = 6;
            this.Respuesta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Respuesta2.Click += new System.EventHandler(this.Respuesta2_Click);
            // 
            // Respuesta3
            // 
            this.Respuesta3.Location = new System.Drawing.Point(12, 251);
            this.Respuesta3.Multiline = true;
            this.Respuesta3.Name = "Respuesta3";
            this.Respuesta3.ReadOnly = true;
            this.Respuesta3.Size = new System.Drawing.Size(279, 41);
            this.Respuesta3.TabIndex = 7;
            this.Respuesta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Respuesta3.Click += new System.EventHandler(this.Respuesta3_Click);
            // 
            // Respuesta4
            // 
            this.Respuesta4.Location = new System.Drawing.Point(12, 298);
            this.Respuesta4.Multiline = true;
            this.Respuesta4.Name = "Respuesta4";
            this.Respuesta4.ReadOnly = true;
            this.Respuesta4.Size = new System.Drawing.Size(279, 41);
            this.Respuesta4.TabIndex = 8;
            this.Respuesta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Respuesta4.Click += new System.EventHandler(this.Respuesta4_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(15, 355);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(115, 37);
            this.Siguiente.TabIndex = 9;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(15, 398);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(115, 37);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // PorcentajeAcierto
            // 
            this.PorcentajeAcierto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PorcentajeAcierto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PorcentajeAcierto.Enabled = false;
            this.PorcentajeAcierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcentajeAcierto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PorcentajeAcierto.Location = new System.Drawing.Point(213, 385);
            this.PorcentajeAcierto.Name = "PorcentajeAcierto";
            this.PorcentajeAcierto.Size = new System.Drawing.Size(65, 22);
            this.PorcentajeAcierto.TabIndex = 11;
            this.PorcentajeAcierto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.PorcentajeAcierto);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Respuesta4);
            this.Controls.Add(this.Respuesta3);
            this.Controls.Add(this.Respuesta2);
            this.Controls.Add(this.Respuesta1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.Opcion1);
            this.Controls.Add(this.MenuOpciones);
            this.MainMenuStrip = this.MenuOpciones;
            this.Name = "Form1";
            this.Text = "Trivia";
            this.MenuOpciones.ResumeLayout(false);
            this.MenuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreCapitalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombrePaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem múltiplesOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirRespuestaToolStripMenuItem;
        private System.Windows.Forms.Label Opcion1;
        private System.Windows.Forms.TextBox Pregunta;
        private System.Windows.Forms.Label Opcion2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox Respuesta1;
        private System.Windows.Forms.TextBox Respuesta2;
        private System.Windows.Forms.TextBox Respuesta3;
        private System.Windows.Forms.TextBox Respuesta4;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox PorcentajeAcierto;
    }
}

