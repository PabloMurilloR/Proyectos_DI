using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperacion1EvaPablo
{
    public partial class TiendaAlimentacion : Form
    {
        private SortedList<string, Producto> listaProductos = new SortedList<string, Producto>();

        public TiendaAlimentacion()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("ProductosF") == false)
            {
                ProductosF productof = new ProductosF(listaProductos);
                productof.MdiParent = this;
                productof.Dock = DockStyle.Fill;
                productof.Show();
            }
        }

        private void ModificarTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("MoficarTree") == false)
            {
                ModificarTree modificarTree = new ModificarTree(listaProductos);
                modificarTree.MdiParent = this;
                modificarTree.Dock = DockStyle.Fill;
                modificarTree.Show();
            }
        }

        private void CargarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "C:\\Temp\\Productos.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("Fichero no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string readText = File.ReadAllText(path);

                string[] lineas = File.ReadAllLines(path);

                listaProductos.Clear();
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');
                    Producto productoNuevo = new Producto(campos[0], campos[1], campos[2], campos[3]);
                    listaProductos.Add(productoNuevo.Id, productoNuevo);
                }
                MessageBox.Show("Datos cargados con éxito", "Confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                productosToolStripMenuItem.Enabled = true;
                modificarTreeToolStripMenuItem.Enabled = true;
            }
        }


        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Dispose();
            }
        }

        
        bool formIsOpen(string nombre_form)
        {
            foreach (var form_hijo in this.MdiChildren)
            {
                if (form_hijo.Text == nombre_form)
                {
                    form_hijo.BringToFront();
                    return true;
                }
            }
            return false;
        }

    }
}
