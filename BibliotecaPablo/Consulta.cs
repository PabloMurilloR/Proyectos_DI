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

        public Consulta(ArrayList libros)
        {
            InitializeComponent();
            this.libros = libros;
        }

        private void AutorRB_CheckedChanged(object sender, EventArgs e)
        {
            ArrayList autores = new ArrayList();

            AutorEditorialLB.Items.Clear();

            foreach (Libro item in libros)
            {
                autores.Add(item.Autor);
            }

            AutorEditorialLB.Items.AddRange(autores.ToArray());
        }

        private void EditorialRB_CheckedChanged(object sender, EventArgs e)
        {
            ArrayList editoriales = new ArrayList();

            AutorEditorialLB.Items.Clear();

            foreach (Libro item in libros)
            {
                editoriales.Add(item.Editorial);
            }
            AutorEditorialLB.Items.AddRange(editoriales.ToArray());

        }

        private void AutorEditorialLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui hay que hacer que dependendiendo del autor/editorial que seleccionemos se cambien
            //los titulos en el listbox de la derecha
        }
    }
}
