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
        OleDbDataAdapter daEmisiones;
        DataTable emisionesT;
        OleDbDataAdapter daEventos;
        DataTable eventosT;
        OleDbDataAdapter daCanales;
        DataTable canalesT;
        OleDbDataAdapter daPaisesProduccion;
        DataTable paisesproduccionT;
        OleDbDataAdapter daRatings;
        DataTable ratingsT;
        OleDbDataAdapter daSubgeneros;
        DataTable subgenerosT;
        OleDbDataAdapter daGeneros;
        DataTable generosT;
        OleDbCommandBuilder cb;

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
                cmd.CommandText = "SELECT * from Eventos";

                daEventos = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daEventos);
                daEventos.SelectCommand = cmd;

                daEventos.Fill(ds, "Eventos");

                eventosT = ds.Tables["Eventos"];
                #endregion

                #region Canales
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Canales";

                daCanales = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daCanales);
                daCanales.SelectCommand = cmd;

                daCanales.Fill(ds, "Canales");

                canalesT = ds.Tables["Canales"];
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
            }
            catch (Exception)
            {

                MessageBox.Show("Error al conectar con la base de datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                form = new Programacion(emisionesT, paisesproduccionT, subgenerosT, generosT, ratingsT, eventosT,canalesT);
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
                form = new Usuarios();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Visible = true;
            }
        }

        private void InformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Informes"))
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
                form = new Informes();
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
