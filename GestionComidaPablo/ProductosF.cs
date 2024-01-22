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

namespace Recuperacion1EvaPablo
{
    public partial class ProductosF : Form
    {
        private SortedList<string, Producto> listaproductos = new SortedList<string, Producto>();
        List<CheckBox> arrayCB = new List<CheckBox>();

        public ProductosF(SortedList<string, Producto> listaproductos)
        {
            InitializeComponent();
            this.listaproductos = listaproductos;
            cargarProductos();
            cargarProductosCB();
        }

        private void cargarProductos()
        {
            ProductosLV.Items.Clear();

            foreach (KeyValuePair<string, Producto> item in listaproductos)
            {
                ProductosLV.Items.Add(new ListViewItem(new String[] { item.Value.Id, item.Value.Nombre,
                    item.Value.Stock, item.Value.Categoria }));

            }
        }

        private void cargarProductosCB()
        {
            int altura = 12;
            ArrayList categorias = new ArrayList();
            foreach (KeyValuePair<string, Producto> item in listaproductos)
            {
                Producto p = new Producto(item.Value.Id, item.Value.Nombre, item.Value.Stock, item.Value.Categoria);
                if (!categorias.Contains(p.Categoria))
                {
                    categorias.Add(p.Categoria);
                }
            }
            foreach (string item in categorias)
            {
                int id = 0;
                CheckBox cb = new CheckBox();
                cb.Location = new Point(12, altura);
                cb.Name = item;
                cb.Text = item;
                cb.Size = new Size(120, 17);
                altura += 25;
                id++;
                this.Controls.Add(cb);
            }
        }
    }
}
