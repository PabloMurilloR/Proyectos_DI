namespace GestionEmpleadosConecPablo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalirB = new System.Windows.Forms.Button();
            this.DepartamentoLV = new System.Windows.Forms.ListView();
            this.LocalizacionLV = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Localización";
            // 
            // SalirB
            // 
            this.SalirB.BackColor = System.Drawing.Color.White;
            this.SalirB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalirB.Image = ((System.Drawing.Image)(resources.GetObject("SalirB.Image")));
            this.SalirB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalirB.Location = new System.Drawing.Point(648, 49);
            this.SalirB.Name = "SalirB";
            this.SalirB.Size = new System.Drawing.Size(101, 104);
            this.SalirB.TabIndex = 2;
            this.SalirB.Text = "Salir";
            this.SalirB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalirB.UseVisualStyleBackColor = false;
            // 
            // DepartamentoLV
            // 
            this.DepartamentoLV.BackColor = System.Drawing.Color.White;
            this.DepartamentoLV.Location = new System.Drawing.Point(90, 84);
            this.DepartamentoLV.Name = "DepartamentoLV";
            this.DepartamentoLV.Size = new System.Drawing.Size(143, 97);
            this.DepartamentoLV.TabIndex = 3;
            this.DepartamentoLV.UseCompatibleStateImageBehavior = false;
            // 
            // LocalizacionLV
            // 
            this.LocalizacionLV.BackColor = System.Drawing.Color.White;
            this.LocalizacionLV.Location = new System.Drawing.Point(431, 84);
            this.LocalizacionLV.Name = "LocalizacionLV";
            this.LocalizacionLV.Size = new System.Drawing.Size(143, 97);
            this.LocalizacionLV.TabIndex = 4;
            this.LocalizacionLV.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LocalizacionLV);
            this.Controls.Add(this.DepartamentoLV);
            this.Controls.Add(this.SalirB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión Empeados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SalirB;
        private System.Windows.Forms.ListView DepartamentoLV;
        private System.Windows.Forms.ListView LocalizacionLV;
        private System.Windows.Forms.Button button1;
    }
}

