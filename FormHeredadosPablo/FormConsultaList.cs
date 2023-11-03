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
    public partial class FormConsultaList : FormPrincipal
    {
        public FormConsultaList()
        {
            InitializeComponent();
        }

        private void FormConsultaList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CiudadCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.SmallImageList = ImagenesPequenas;
            listView1.LargeImageList = ImagenesGrandes;
            foreach (KeyValuePair<string, Usuario> item in usuarios)
            {
                if (item.Value.Ciudad.Equals(CiudadCB.Text))
                {
                    int imageindex = 0;
                    if (!item.Value.EsVip)
                    {
                        imageindex = 1;
                    }
                    listView1.Items.Add(new ListViewItem(new string[] {item.Value.Nombre, item.Value.Apellidos,
                        item.Value.Correo, item.Value.Comentario}, imageindex));
                    
                }
            }
        }

        private void FormConsultaList_Activated(object sender, EventArgs e)
        {
            ArrayList ciudades = new ArrayList();
            CiudadCB.Items.Clear();
            int contador = 0;

            foreach (KeyValuePair<string, Usuario> item in usuarios)
            {
                if (ciudades.Contains(item.Value.Ciudad))
                {
                    Console.WriteLine("Esa ciudad ya existe " + item.Value.Ciudad);
                }
                else if (!ciudades.Contains(item.Value.Ciudad))
                {

                    CiudadCB.Items.Add(item.Value.Ciudad);
                    ciudades.Add(item.Value.Ciudad);
                    CiudadCB.SelectedIndex = 0;
                }
                
            }

            VistaCB.Items.Clear();

            VistaCB.Items.Add("Detalles");
            VistaCB.SelectedIndex = 0;
            VistaCB.Items.Add("Iconos Grandes");
        }

        private void VistaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (VistaCB.SelectedIndex)
            {
                case 0:
                    listView1.View = View.Details;
                    break;
                case 1:
                    listView1.View = View.LargeIcon;
                    break;
            }
        }
    }
}
