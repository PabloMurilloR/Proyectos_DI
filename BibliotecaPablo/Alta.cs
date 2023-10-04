using System;
using System.Collections;
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
        ArrayList libros;
        string rutaImagenSeleccionada;
        public Alta(ArrayList libros)
        {
            InitializeComponent();
            this.libros = libros;
        }

        private void CargarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar Imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = openFileDialog.FileName;

                    Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    Imagen.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (TituloTB.Text.Equals("") || AutorTB.Text.Equals("") || EditorialTB.Text.Equals("") || Imagen.Image == null)
            {
                MessageBox.Show("Por favor rellena todos los campos");
            } else
            {
                Libro libroNuevo = new Libro(TituloTB.Text, AutorTB.Text, EditorialTB.Text, NuevoCB.Checked,
                                            rutaImagenSeleccionada);
                libros.Add(libroNuevo);
                MessageBox.Show("Libro guardado con éxito");
                limpiar();
                

            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            TituloTB.Text = "";
            AutorTB.Text = "";
            EditorialTB.Text = "";
            NuevoCB.Checked = false;
            Imagen.Image = null;
        }
    }
}
