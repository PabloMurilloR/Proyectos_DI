using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTelevisionPablo
{
    public partial class Usuarios : Form
    {
        DataTable usuariosT;
        public Usuarios(DataTable usuariosT)
        {
            InitializeComponent();
            this.usuariosT = usuariosT;

            this.UsuarioCB.DataSource = usuariosT;
            this.UsuarioCB.DisplayMember = "Usuario";
            this.UsuarioCB.SelectedIndex = -1;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UsuarioCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow idUsuario = ((DataRowView)UsuarioCB.SelectedItem).Row;

                LoginTB.Text = idUsuario["Usuario"].ToString();
                PassTB.Text = idUsuario["Contraseña"].ToString();
                NombreTB.Text = idUsuario["Nombre"].ToString();
                ApellidoTB.Text = idUsuario["Apellidos"].ToString();
                EstadoCH.Checked = (bool)idUsuario["Estado"];
            }
            catch (NullReferenceException)
            {
                limpiar();
            }
            
        }

        private void limpiar()
        {
            LoginTB.Text = "";
            PassTB.Text = "";
            NombreTB.Text = "";
            ApellidoTB.Text = "";
            EstadoCH.Checked = false;
        }
    }
}
