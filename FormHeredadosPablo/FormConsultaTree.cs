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

namespace FormHeredadosPablo
{
    public partial class FormConsultaTree : FormPrincipal
    {
        public FormConsultaTree()
        {
            InitializeComponent();
        }

        private void FormConsultaTree_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormConsultaTree_Activated(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            SortedList<string, ArrayList> ciudades = new SortedList<string, ArrayList>();
            
            foreach (KeyValuePair<string, Usuario> item in usuarios)
            {
                string key = item.Value.Ciudad;
                if (!ciudades.ContainsKey(key))
                {
                    ArrayList arrTemp = new ArrayList();
                    arrTemp.Add(item.Value);
                    ciudades.Add(key, arrTemp);
                }
                else
                {
                    ciudades[key].Add(item.Value);
                }

            }
            foreach (KeyValuePair<string, ArrayList> item in ciudades)
            {
                TreeNode padre = new TreeNode(item.Key);
                padre.ImageIndex = 0;

                treeView1.Nodes.Add(padre);

                foreach (Usuario u in item.Value)
                {
                    TreeNode hijo = new TreeNode(u.Correo);
                    if (u.EsVip)
                    {
                        hijo.ImageIndex = 1;
                    }
                    else
                    {
                        hijo.ImageIndex = 2;
                    }
                    padre.Nodes.Add(hijo);
                }
            }
        }

        public void limpiar()
        {
            NombreTV.Text = "";
            ApellidosTV.Text = "";
            CiudadTV.Text = "";
            EmailTV.Text = "";
            ComentarioTV.Text = "";
        }
    }
}
