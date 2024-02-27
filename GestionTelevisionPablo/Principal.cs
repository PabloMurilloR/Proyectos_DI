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
    public partial class Principal : Form
    {
        OleDbConnection ctn;
        OleDbCommand cmd;
        DataSet ds;
        OleDbCommandBuilder cb;
        OleDbDataAdapter daEmisiones;
        DataTable emisionesT;
        OleDbDataAdapter daEventos;
        DataTable eventosT;
        OleDbDataAdapter daPaisesProduccion;
        DataTable paisesproduccionT;
        OleDbDataAdapter daRatings;
        DataTable ratingsT;
        OleDbDataAdapter daSubgeneros;
        DataTable subgenerosT;
        OleDbDataAdapter daGeneros;
        DataTable generosT;
        OleDbDataAdapter daUsuarios;
        DataTable usuariosT;

        int MaxIdExmision;
        int MaxIdUsuario;

        public Principal()
        {
            InitializeComponent();
            try
            {
                ctn = new OleDbConnection();
                ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=..\\..\\recursos\\Television.mdb";
                ctn.Open();

                ds = new DataSet();

                #region Emisiones
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Emisiones";

                daEmisiones = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daEmisiones);
                daEmisiones.SelectCommand = cmd;

                daEmisiones.Fill(ds, "Emisiones");

                emisionesT = ds.Tables["Emisiones"];
                #endregion

                #region Eventos
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT e.idemision, c.nombrecanal as canal, e.fecha, FORMAT(e.hora, \"hh:mm:ss\") as hora, e.codificado " +
                    "FROM eventos e INNER JOIN canales c on (c.idcanal = e.idcanal)";

                daEventos = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daEventos);
                daEventos.SelectCommand = cmd;

                daEventos.Fill(ds, "Eventos");

                eventosT = ds.Tables["Eventos"];
                #endregion

                #region PaisesProduccion
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from PaisesProduccion";

                daPaisesProduccion = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daPaisesProduccion);
                daPaisesProduccion.SelectCommand = cmd;

                daPaisesProduccion.Fill(ds, "PaisesProduccion");

                paisesproduccionT = ds.Tables["PaisesProduccion"];
                #endregion
                
                #region Ratings
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Ratings";

                daRatings = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daRatings);
                daRatings.SelectCommand = cmd;

                daRatings.Fill(ds, "Ratings");

                ratingsT = ds.Tables["Ratings"];
                #endregion

                #region Subgeneros
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Subgeneros";

                daSubgeneros = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daSubgeneros);
                daSubgeneros.SelectCommand = cmd;

                daSubgeneros.Fill(ds, "Subgeneros");

                subgenerosT = ds.Tables["Subgeneros"];
                #endregion

                #region Generos
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Generos";

                daGeneros = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daGeneros);
                daGeneros.SelectCommand = cmd;

                daGeneros.Fill(ds, "Generos");

                generosT = ds.Tables["Generos"];
                #endregion

                #region Usuarios
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Usuarios";

                daUsuarios = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daUsuarios);
                daUsuarios.SelectCommand = cmd;

                daUsuarios.Fill(ds, "Usuarios");

                usuariosT = ds.Tables["Usuarios"];
                #endregion

                ctn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al conectar con la base de datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            daEmisiones.Update(ds, "Emisiones");
            daUsuarios.Update(ds, "Usuarios");
            ds.AcceptChanges();

            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ProgramacionYEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Programacion"))
                {
                    form = fForm;
                }
                else
                {
                    fForm.Hide();
                }
            }

            if (form == null)
            {
                form = new Programacion(emisionesT, paisesproduccionT, subgenerosT, generosT, ratingsT, eventosT, daEmisiones, ds);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Visible = true;
            }
        }

        private void MantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Usuarios"))
                {
                    form = fForm;
                }
                else
                {
                    fForm.Hide();
                }
            }

            if (form == null)
            {
                form = new Usuarios(usuariosT, ds, daUsuarios);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Visible = true;
            }
        }
    }
}
