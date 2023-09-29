using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPablo
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void CargarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar Imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                    Imagen.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
    }
}
