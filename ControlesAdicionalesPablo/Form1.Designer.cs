namespace ControlesAdicionalesPablo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.CodigoPostalTB1 = new System.Windows.Forms.MaskedTextBox();
            this.NIFTB1 = new System.Windows.Forms.MaskedTextBox();
            this.DireccionTB1 = new System.Windows.Forms.TextBox();
            this.ApellidosTB1 = new System.Windows.Forms.TextBox();
            this.NombreTB1 = new System.Windows.Forms.TextBox();
            this.FechaNacTB1 = new System.Windows.Forms.MaskedTextBox();
            this.idCliente = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pedidos = new System.Windows.Forms.TabPage();
            this.PedidosTB = new System.Windows.Forms.TextBox();
            this.ApellidosTB2 = new System.Windows.Forms.TextBox();
            this.NombreTB2 = new System.Windows.Forms.TextBox();
            this.NIFTB2 = new System.Windows.Forms.TextBox();
            this.idPedido = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PedidosLB = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.TabControl1.SuspendLayout();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente)).BeginInit();
            this.Pedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Clientes);
            this.TabControl1.Controls.Add(this.Pedidos);
            this.TabControl1.Location = new System.Drawing.Point(0, 27);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(801, 391);
            this.TabControl1.TabIndex = 0;
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.CodigoPostalTB1);
            this.Clientes.Controls.Add(this.NIFTB1);
            this.Clientes.Controls.Add(this.DireccionTB1);
            this.Clientes.Controls.Add(this.ApellidosTB1);
            this.Clientes.Controls.Add(this.NombreTB1);
            this.Clientes.Controls.Add(this.FechaNacTB1);
            this.Clientes.Controls.Add(this.idCliente);
            this.Clientes.Controls.Add(this.progressBar1);
            this.Clientes.Controls.Add(this.label7);
            this.Clientes.Controls.Add(this.label6);
            this.Clientes.Controls.Add(this.label5);
            this.Clientes.Controls.Add(this.label4);
            this.Clientes.Controls.Add(this.label3);
            this.Clientes.Controls.Add(this.label2);
            this.Clientes.Controls.Add(this.label1);
            this.Clientes.Location = new System.Drawing.Point(4, 22);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(793, 365);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // CodigoPostalTB1
            // 
            this.CodigoPostalTB1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.CodigoPostalTB1.Location = new System.Drawing.Point(291, 273);
            this.CodigoPostalTB1.Mask = "00000";
            this.CodigoPostalTB1.Name = "CodigoPostalTB1";
            this.CodigoPostalTB1.Size = new System.Drawing.Size(44, 20);
            this.CodigoPostalTB1.TabIndex = 22;
            this.CodigoPostalTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NIFTB1
            // 
            this.NIFTB1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.NIFTB1.Location = new System.Drawing.Point(266, 210);
            this.NIFTB1.Mask = "00000000L";
            this.NIFTB1.Name = "NIFTB1";
            this.NIFTB1.Size = new System.Drawing.Size(69, 20);
            this.NIFTB1.TabIndex = 21;
            this.NIFTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DireccionTB1
            // 
            this.DireccionTB1.Location = new System.Drawing.Point(215, 239);
            this.DireccionTB1.Name = "DireccionTB1";
            this.DireccionTB1.Size = new System.Drawing.Size(120, 20);
            this.DireccionTB1.TabIndex = 20;
            // 
            // ApellidosTB1
            // 
            this.ApellidosTB1.Location = new System.Drawing.Point(215, 143);
            this.ApellidosTB1.Name = "ApellidosTB1";
            this.ApellidosTB1.Size = new System.Drawing.Size(120, 20);
            this.ApellidosTB1.TabIndex = 18;
            // 
            // NombreTB1
            // 
            this.NombreTB1.Location = new System.Drawing.Point(215, 109);
            this.NombreTB1.Name = "NombreTB1";
            this.NombreTB1.Size = new System.Drawing.Size(120, 20);
            this.NombreTB1.TabIndex = 17;
            // 
            // FechaNacTB1
            // 
            this.FechaNacTB1.Location = new System.Drawing.Point(266, 177);
            this.FechaNacTB1.Mask = "00/00/0000";
            this.FechaNacTB1.Name = "FechaNacTB1";
            this.FechaNacTB1.Size = new System.Drawing.Size(69, 20);
            this.FechaNacTB1.TabIndex = 16;
            this.FechaNacTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FechaNacTB1.ValidatingType = typeof(System.DateTime);
            // 
            // idCliente
            // 
            this.idCliente.Location = new System.Drawing.Point(291, 79);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(44, 20);
            this.idCliente.TabIndex = 15;
            this.idCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 401);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(797, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Código Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // Pedidos
            // 
            this.Pedidos.Controls.Add(this.PedidosTB);
            this.Pedidos.Controls.Add(this.ApellidosTB2);
            this.Pedidos.Controls.Add(this.NombreTB2);
            this.Pedidos.Controls.Add(this.NIFTB2);
            this.Pedidos.Controls.Add(this.idPedido);
            this.Pedidos.Controls.Add(this.label11);
            this.Pedidos.Controls.Add(this.label12);
            this.Pedidos.Controls.Add(this.label13);
            this.Pedidos.Controls.Add(this.label14);
            this.Pedidos.Controls.Add(this.label15);
            this.Pedidos.Controls.Add(this.linkLabel1);
            this.Pedidos.Controls.Add(this.PedidosLB);
            this.Pedidos.Controls.Add(this.label8);
            this.Pedidos.Location = new System.Drawing.Point(4, 22);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.Pedidos.Size = new System.Drawing.Size(793, 355);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "Pedidos";
            this.Pedidos.UseVisualStyleBackColor = true;
            // 
            // PedidosTB
            // 
            this.PedidosTB.Location = new System.Drawing.Point(487, 218);
            this.PedidosTB.Multiline = true;
            this.PedidosTB.Name = "PedidosTB";
            this.PedidosTB.Size = new System.Drawing.Size(120, 81);
            this.PedidosTB.TabIndex = 38;
            // 
            // ApellidosTB2
            // 
            this.ApellidosTB2.Location = new System.Drawing.Point(487, 185);
            this.ApellidosTB2.Name = "ApellidosTB2";
            this.ApellidosTB2.Size = new System.Drawing.Size(120, 20);
            this.ApellidosTB2.TabIndex = 37;
            // 
            // NombreTB2
            // 
            this.NombreTB2.Location = new System.Drawing.Point(487, 151);
            this.NombreTB2.Name = "NombreTB2";
            this.NombreTB2.Size = new System.Drawing.Size(120, 20);
            this.NombreTB2.TabIndex = 33;
            // 
            // NIFTB2
            // 
            this.NIFTB2.Location = new System.Drawing.Point(487, 117);
            this.NIFTB2.Name = "NIFTB2";
            this.NIFTB2.Size = new System.Drawing.Size(120, 20);
            this.NIFTB2.TabIndex = 32;
            // 
            // idPedido
            // 
            this.idPedido.Location = new System.Drawing.Point(563, 87);
            this.idPedido.Name = "idPedido";
            this.idPedido.Size = new System.Drawing.Size(44, 20);
            this.idPedido.TabIndex = 30;
            this.idPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Pedido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Apellidos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "NIF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(335, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Pedido";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(47, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Descripción productos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // PedidosLB
            // 
            this.PedidosLB.FormattingEnabled = true;
            this.PedidosLB.Location = new System.Drawing.Point(47, 119);
            this.PedidosLB.Name = "PedidosLB";
            this.PedidosLB.Size = new System.Drawing.Size(165, 134);
            this.PedidosLB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bicicletas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.personalizarToolStripMenuItem.Text = "Personalizar";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(-1, 414);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(801, 38);
            this.progressBar2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Controles adicionales";
            this.TabControl1.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente)).EndInit();
            this.Pedidos.ResumeLayout(false);
            this.Pedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.TabPage Pedidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox FechaNacTB1;
        private System.Windows.Forms.NumericUpDown idCliente;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox DireccionTB1;
        private System.Windows.Forms.TextBox ApellidosTB1;
        private System.Windows.Forms.TextBox NombreTB1;
        private System.Windows.Forms.MaskedTextBox CodigoPostalTB1;
        private System.Windows.Forms.MaskedTextBox NIFTB1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox PedidosLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NombreTB2;
        private System.Windows.Forms.TextBox NIFTB2;
        private System.Windows.Forms.NumericUpDown idPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PedidosTB;
        private System.Windows.Forms.TextBox ApellidosTB2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

