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
    public partial class ModificarTree : Form
    {
        private SortedList<string, Producto> listaproductos = new SortedList<string, Producto>();

        public ModificarTree(SortedList<string, Producto> listaproductos)
        {
            InitializeComponent();
            this.listaproductos = listaproductos;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (e.Node.Level == 1)
            {
                string key = e.Node.Text;
                foreach (KeyValuePair<string, Producto> item in listaproductos)
                {
                    if (item.Value.Nombre.Equals(key))
                    {
                        IdTB.Text = item.Value.Id;
                        NombreTB.Text = item.Value.Nombre;
                        PrecioTB.Text = item.Value.Precio.ToString();
                    }
                }
            }
            
            
        }

        private void ModificarTree_Activated(object sender, EventArgs e)
        {
            cargarTV();
        }

        public void limpiar()
        {
            IdTB.Text = "";
            NombreTB.Text = "";
            PrecioTB.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if(IdTB.Text == "")
            {
                MessageBox.Show("Selecciona un producto", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if(NombreTB.Text != "" && PrecioTB.Text != "")
            {
                bool conversion = true;
                int precio = 0;

                try
                {
                     precio = Int32.Parse(PrecioTB.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Introduce un valor númerico en el precio", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conversion = false;
                }
                if (conversion)
                {
                    listaproductos[IdTB.Text].Nombre = NombreTB.Text;
                    listaproductos[IdTB.Text].Precio = precio;
                    MessageBox.Show("Producto modificado con éxito " + NombreTB.Text, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargarTV();
                }
                

            }
            else
            {
                MessageBox.Show("Rellena todos los campos", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarTV()
        {
            treeView1.Nodes.Clear();

            SortedList<string, ArrayList> categorias = new SortedList<string, ArrayList>();
            foreach (KeyValuePair<string, Producto> item in listaproductos)
            {
                string key = item.Value.Categoria;
                if (!categorias.ContainsKey(key))
                {
                    ArrayList arrTemp = new ArrayList();
                    arrTemp.Add(item.Value);
                    categorias.Add(key, arrTemp);
                }
                else
                {
                    categorias[key].Add(item.Value);
                }

            }
            foreach (KeyValuePair<string, ArrayList> item in categorias)
            {
                TreeNode padre = new TreeNode(item.Key);

                treeView1.Nodes.Add(padre);

                foreach (Producto u in item.Value)
                {
                    TreeNode hijo = new TreeNode(u.Nombre);
                    padre.Nodes.Add(hijo);
                }
            }
        }
    }
}
