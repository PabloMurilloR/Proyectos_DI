using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTelevisionPablo
{
    public partial class Usuarios : Form
    {
        OleDbDataAdapter daUsuarios;
        DataSet ds;
        DataTable usuariosT;
        int MaxIdUsuario = 0;
        public Usuarios(DataTable usuariosT, DataSet ds, OleDbDataAdapter daUsuarios)
        {
            InitializeComponent();
            this.usuariosT = usuariosT;

            this.UsuarioCB.DataSource = usuariosT;
            this.UsuarioCB.DisplayMember = "Usuario";
            this.UsuarioCB.SelectedIndex = -1;

            this.daUsuarios = daUsuarios;
            this.ds = ds;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UsuarioCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((DataRowView)UsuarioCB.SelectedItem != null)
            {
                DataRow idUsuario = ((DataRowView)UsuarioCB.SelectedItem).Row;

                LoginTB.Text = idUsuario["Usuario"].ToString();
                PassTB.Text = idUsuario["Contraseña"].ToString();
                NombreTB.Text = idUsuario["Nombre"].ToString();
                ApellidoTB.Text = idUsuario["Apellidos"].ToString();
                EstadoCH.Checked = (bool)idUsuario["Estado"];
            }
            else
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

        private void BorrarBT_Click(object sender, EventArgs e)
        {
            if ((DataRowView)UsuarioCB.SelectedItem != null)
            {
                ((DataRowView)UsuarioCB.SelectedItem).Row.Delete();

                MessageBox.Show("Usuario borrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
                UsuarioCB.SelectedIndex = -1;
                daUsuarios.Update(ds, "Usuarios");
            }
            else
            {
                MessageBox.Show("No ha seleccionado un usuario válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoBT_Click(object sender, EventArgs e)
        {
            bool usuarioExistente = false;

            foreach (DataRow registro in usuariosT.Rows)
            {
                int id = Convert.ToInt32(registro["IdUsuario"]);
                if (id>MaxIdUsuario)
                {
                    MaxIdUsuario = id;
                }
                if (registro["Usuario"].Equals(LoginTB.Text))
                {
                    MessageBox.Show("Usuario ya existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginTB.Text = "";
                    usuarioExistente = true;
                }
            }

            if (!HayCamposVacios() && !usuarioExistente)
            {
                DataRow nuevaFila = usuariosT.NewRow();
                MaxIdUsuario++;
                nuevaFila["IdUsuario"] = MaxIdUsuario;
                nuevaFila["Usuario"] = LoginTB.Text;
                nuevaFila["Contraseña"] = PassTB.Text;
                nuevaFila["Nombre"] = NombreTB.Text;
                nuevaFila["Apellidos"] = ApellidoTB.Text;
                nuevaFila["Estado"] = EstadoCH.Checked;

                usuariosT.Rows.Add(nuevaFila);

                MessageBox.Show("Usuario " + LoginTB.Text + " creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limpiar();
            UsuarioCB.SelectedIndex = -1;
            daUsuarios.Update(ds, "Usuarios");
        }

        private bool HayCamposVacios()
        {
            return LoginTB.Text.Equals("") || PassTB.Text.Equals("")
                || NombreTB.Text.Equals("") || ApellidoTB.Text.Equals("");
        }

        private void ModificarBT_Click(object sender, EventArgs e)
        {
            if (!HayCamposVacios())
            {
                DataRow filaModificar = ((DataRowView)UsuarioCB.SelectedItem).Row;
                filaModificar.BeginEdit();
                filaModificar["Usuario"] = LoginTB.Text;
                filaModificar["Contraseña"] = PassTB.Text;
                filaModificar["Nombre"] = NombreTB.Text;
                filaModificar["Apellidos"] = ApellidoTB.Text;
                filaModificar["Estado"] = EstadoCH.Checked;
                filaModificar.EndEdit();

                MessageBox.Show("Usuario "+LoginTB.Text+" modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
                UsuarioCB.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
