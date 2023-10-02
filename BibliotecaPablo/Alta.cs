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
                //openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
                //openFileDialog.Title = "Seleccionar Imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    Imagen.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TituloTB.Text) || string.IsNullOrEmpty(AutorTB.Text) || string.IsNullOrEmpty(EditorialTB.Text))
            {
                MessageBox.Show("Por favor rellena todos los campos");
            } else
            {
                Libro libroNuevo = new Libro(TituloTB.Text, AutorTB.Text, EditorialTB.Text, NuevoCB.Checked);
                MessageBox.Show("Libro guardado con éxito");
                TituloTB.Text = "";
                AutorTB.Text = "";
                EditorialTB.Text = "";
                NuevoCB.Checked = false;
                Imagen.Image = null;

            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TituloTB.Text = "";
            AutorTB.Text = "";
            EditorialTB.Text = "";
            NuevoCB.Checked = false;
        }
    }
}
