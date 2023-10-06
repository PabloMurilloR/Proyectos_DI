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
    public partial class Consulta : Form
    {
        ArrayList libros;
        ArrayList autores;
        ArrayList editoriales;
        ArrayList titulos;

        public Consulta(ArrayList libros)
        {
            InitializeComponent();
            this.libros = libros;
        }

        private void AutorRB_CheckedChanged(object sender, EventArgs e)
        {
            AutorEditorialLB.Items.Clear();

            autores = new ArrayList();

            foreach (Libro item in libros)
            {
                if (!autores.Contains(item.Autor))
                {
                    autores.Add(item.Autor);
                }
            }

            AutorEditorialLB.Items.AddRange(autores.ToArray());
        }

        private void EditorialRB_CheckedChanged(object sender, EventArgs e)
        {
            AutorEditorialLB.Items.Clear();

            editoriales = new ArrayList();

            foreach (Libro item in libros)
            {
                if (!editoriales.Contains(item.Editorial))
                {
                    editoriales.Add(item.Editorial);
                }
            }
            AutorEditorialLB.Items.AddRange(editoriales.ToArray());

        }

        private void AutorEditorialLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui hay que hacer que dependendiendo del autor/editorial que seleccionemos se cambien
            //los titulos en el listbox de la derecha
            titulos = new ArrayList();

            titulos.Clear();

            TituloLB.Items.Clear();

            if (AutorRB.Checked)
            {
                string autor = AutorEditorialLB.SelectedItem.ToString();
                foreach (Libro libro in libros)
                {
                    if (libro.Autor.Equals(autor))
                    {
                        titulos.Add(libro.Titulo);
                    }
                }
            } else if (EditorialRB.Checked)
            {
                string editorial = AutorEditorialLB.SelectedItem.ToString();
                foreach (Libro libro in libros)
                {
                    if (libro.Editorial.Equals(editorial))
                    {
                        titulos.Add(libro.Titulo);
                    }
                }
            }
            TituloLB.Items.AddRange(titulos.ToArray());
        }

        private void TituloLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string titulo = TituloLB.SelectedItem.ToString();
            foreach (Libro libro in libros)
            {
                if (libro.Titulo.Equals(titulo))
                {
                    FotoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                    FotoPB.ImageLocation = libro.RutaFoto;
                }
            }
        }
    }
}
