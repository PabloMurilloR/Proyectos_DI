using System;
using System.Collections;
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
        ArrayList ArUsuarios; 

        public FormAlta()
        {
            InitializeComponent();
        }

        private void OpcionesTS(object sender, EventArgs e)
        {
            ArUsuarios = new ArrayList();
            if (sender.ToString().Equals("Guardar"))
            {
                Usuario usuario = new Usuario(NombreTB.Text, ApellidosTB.Text, CiudadTB.Text, EmailTB.Text,
                    ComentarioTB.Text, VIPCB.Checked);
                if (NombreTB.Text.Equals("") || ApellidosTB.Text.Equals("") || CiudadTB.Text.Equals("") 
                    || EmailTB.Text.Equals(""))
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    if (usuarios.ContainsKey(EmailTB.Text))
                    {
                        MessageBox.Show("Este correo ya esta en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EmailTB.Text = "";
                    }
                    else
                    {
                        usuarios.Add(EmailTB.Text, usuario);
                        limpiar();
                        ArUsuarios.Add(usuario.Nombre + ", " + usuario.Correo);
                        ClientesLB.Items.AddRange(ArUsuarios.ToArray());
                    }
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
        }

        private void ClientesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = ClientesLB.SelectedItem.ToString().Substring(ClientesLB.SelectedItem.ToString().IndexOf(',')+2);
            Usuario usuario = usuarios[seleccion];
            NombreTB.Text = usuario.Nombre;
            ApellidosTB.Text = usuario.Apellidos;
            CiudadTB.Text = usuario.Ciudad;
            EmailTB.Text = usuario.Correo;
            ComentarioTB.Text = usuario.Comentario;
            VIPCB.Checked = usuario.EsVip;
        }
    }
}
