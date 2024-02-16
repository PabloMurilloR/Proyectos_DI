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
    public partial class Login : Form
    {
        private OleDbConnection ctn;
        IDbCommand cmd;
        IDataReader lector;

        public Login()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctn = new OleDbConnection();
                ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=..\\..\\recursos\\Television.mdb";
                ctn.Open();

                cmd = ctn.CreateCommand();
                cmd.CommandText = "select * from Usuarios";

                lector = cmd.ExecuteReader();
                bool encontrado = false;
                while (lector.Read())
                {
                    if (this.UsuarioTB.Text.Equals(lector.GetString(1)) && this.PassTB.Text.Equals(lector.GetString(2)))
                    {
                        encontrado = true;
                        Principal principal = new Principal();
                        principal.Show();
                        this.Hide();
                    }
                }
                lector.Close();

                if (!encontrado)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error al iniciar sesion",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ctn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
