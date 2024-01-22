namespace Recuperacion1EvaPablo
{
    partial class ProductosF
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
            this.ProductosLV = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ProductosLV
            // 
            this.ProductosLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.NombreProducto,
            this.Stock,
            this.Categoria});
            this.ProductosLV.Location = new System.Drawing.Point(239, 12);
            this.ProductosLV.Name = "ProductosLV";
            this.ProductosLV.Size = new System.Drawing.Size(549, 364);
            this.ProductosLV.TabIndex = 0;
            this.ProductosLV.UseCompatibleStateImageBehavior = false;
            this.ProductosLV.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 37;
            // 
            // NombreProducto
            // 
            this.NombreProducto.Text = "Nombre del producto";
            this.NombreProducto.Width = 206;
            // 
            // Stock
            // 
            this.Stock.Text = "Unidades";
            this.Stock.Width = 120;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 179;
            // 
            // ProductosF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.ProductosLV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductosF";
            this.Text = "ProductosF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductosLV;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader NombreProducto;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Categoria;
    }
}