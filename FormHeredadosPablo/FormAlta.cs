using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormHeredadosPablo
{
    public partial class FormAlta : FormPrincipal
    {

        public FormAlta()
        {
            InitializeComponent();
        }

        private void OpcionesTS(object sender, EventArgs e)
        {
            string opcion = sender.ToString();

            switch (opcion)
            {
                case "Guardar":
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
                            MessageBox.Show("Este correo ya está en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EmailTB.Text = "";
                        }
                        else
                        {
                            usuarios.Add(EmailTB.Text, usuario);
                            limpiar();
                            rellenarLB();
                        }
                    }
                    break;
                case "Actualizar":
                    if (ClientesLB.SelectedItem == null)
                    {
                        MessageBox.Show("No has selecionado nada", "Error");
                    }
                    else
                    {
                        usuarios.Remove(EmailTB.Text);
                        Usuario usuario2 = new Usuario(NombreTB.Text, ApellidosTB.Text, CiudadTB.Text, EmailTB.Text,
                        ComentarioTB.Text, VIPCB.Checked);
                        usuarios.Add(EmailTB.Text, usuario2);
                        limpiar();
                        rellenarLB();
                    }
                    break;
                case "Borrar":
                    if (ClientesLB.SelectedItem == null)
                    {
                        MessageBox.Show("No has selecionado nada", "Error");
                    }
                    else if (usuarios.ContainsKey(ClientesLB.SelectedItem.ToString()))
                    {
                        usuarios.Remove(EmailTB.Text);
                        rellenarLB();
                        limpiar();
                    }
                    break;
                default:
                    break;
            }
        }

        public void limpiar()
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
            string seleccion = ClientesLB.SelectedItem.ToString();
            Usuario usuario = usuarios[seleccion];
            NombreTB.Text = usuario.Nombre;
            ApellidosTB.Text = usuario.Apellidos;
            CiudadTB.Text = usuario.Ciudad;
            EmailTB.Text = usuario.Correo;
            ComentarioTB.Text = usuario.Comentario;
            VIPCB.Checked = usuario.EsVip;
        }

        private void FormAlta_DoubleClick(object sender, EventArgs e)
        {
            limpiar();
        }

        private void FormAlta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void rellenarLB()
        {

            ClientesLB.Items.Clear();
            foreach (KeyValuePair<String, Usuario> item in usuarios)
            {
                ClientesLB.Items.Add(item.Value.Correo);
            }

        }
    }
}
