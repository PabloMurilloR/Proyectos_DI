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
    public partial class FormAlta : FormPrincipal
    {
        SortedList usuarios;

        public FormAlta(SortedList usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;
        }

        private void OpcionesTS(object sender, EventArgs e)
        {
            if (sender.ToString().Equals("Guardar"))
            {
                Usuario usuario = new Usuario(NombreTB.Text, ApellidosTB.Text, CiudadTB.Text, EmailTB.Text,
                    ComentarioTB.Text, VIPCB.Checked);
                if (usuarios.ContainsKey(EmailTB.Text))
                {
                    MessageBox.Show("Este correo ya esta en uso");
                    EmailTB.Text = "";
                } else
                {
                    usuarios.Add(EmailTB.Text, usuario);
                    limpiar();
                }
                
            }
            else if (sender.ToString().Equals("Actualizar"))
            {
                MessageBox.Show("actualizar");
            }
            else if (sender.ToString().Equals("Borrar"))
            {
                limpiar();
            }
        }
        public  void limpiar()
        {
            NombreTB.Text = "";
            ApellidosTB.Text = "";
            CiudadTB.Text = "";
            EmailTB.Text = "";
            ComentarioTB.Text = "";
            VIPCB.Checked = false;
        }s

    }
}
