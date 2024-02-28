using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenBibliotecaPablo
{
    public partial class Consulta : Form
    {
        OleDbConnection ctn;
        OleDbCommand cmd;
        DataSet ds;
        OleDbCommandBuilder cb;
        OleDbDataAdapter daEditores;
        DataTable editoresT;
        OleDbDataAdapter daTitulos;
        DataTable titulosT;

        public Consulta()
        {
            InitializeComponent();
        }

        private void CargarDatosBT_Click(object sender, EventArgs e)
        {
            try
            {
                ctn = new OleDbConnection();
                ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Temp\\Biblioteca.mdb";
                ctn.Open();

                ds = new DataSet();

                #region Editores
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Editores";

                daEditores = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daEditores);
                daEditores.SelectCommand = cmd;

                daEditores.Fill(ds, "Editores");

                editoresT = ds.Tables["Editores"];
                #endregion

                #region Titulos
                cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT * from Titulos ORDER BY Titulo";

                daTitulos = new OleDbDataAdapter();
                cb = new OleDbCommandBuilder(daTitulos);
                daTitulos.SelectCommand = cmd;

                daTitulos.Fill(ds, "Titulos");

                titulosT = ds.Tables["Titulos"];
                #endregion

                ctn.Close();

                CargaDatosLBL.Visible = false;
                tituloRB.Enabled = true;
                anioRB.Enabled = true;
                isbnRB.Enabled = true;
                editoresRB.Enabled = true;

                cargarListView("nada");

                this.editoresCB.DataSource = editoresT;
                this.editoresCB.DisplayMember = "Nombre";
                this.editoresCB.SelectedIndex = -1;

                MessageBox.Show("Datos cargados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OleDbException)
            {
                MessageBox.Show("Error al cargar la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditoresRB_CheckedChanged(object sender, EventArgs e)
        {
            editoresCB.Enabled = true;

            filtrarBT.Enabled = false;
            eliminarfiltroBT.Enabled = false;
            filtroTB.Enabled = false;
        }

        private void filtroTexto_CheckedChanged(object sender, EventArgs e)
        {
            filtrarBT.Enabled = true;
            eliminarfiltroBT.Enabled = true;
            filtroTB.Enabled = true;

            editoresCB.Enabled = false;
            editoresCB.SelectedIndex = -1;
        }

        private void EliminarfiltroBT_Click(object sender, EventArgs e)
        {
            editoresCB.SelectedIndex = -1;
            filtroTB.Text = "";
            cargarListView("nada");
            MessageBox.Show("Filtro eliminiado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditoresCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editoresRB.Checked)
            {
                eliminarfiltroBT.Enabled = true;
                cargarListView("editores");
            }
        }

        private void FiltrarBT_Click(object sender, EventArgs e)
        {
            if (tituloRB.Checked)
            {
                cargarListView("titulo");
            }
            else if (anioRB.Checked)
            {
                cargarListView("anio");
            }
            else if (isbnRB.Checked)
            {
                cargarListView("isbn");
            }
        }

        private void cargarListView(string filtro)
        {
            listView1.Items.Clear();
            int contador = 0;
            switch (filtro)
            {
                case "nada":
                    foreach (DataRow registro in titulosT.Rows)
                    {
                        listView1.Items.Add(new ListViewItem(new string[] {registro["Titulo"].ToString(),
                        registro["Anyo"].ToString(), registro["ISBN"].ToString() }));
                    }
                    break;
                case "titulo":
                    foreach (DataRow registro in titulosT.Rows)
                    {
                        string titulo = registro["Titulo"].ToString();

                        if (titulo.Contains(filtroTB.Text))
                        {
                            listView1.Items.Add(new ListViewItem(new string[] {registro["Titulo"].ToString(),
                            registro["Anyo"].ToString(), registro["ISBN"].ToString() }));
                            contador++;
                        }
                    }

                    if (contador>0)
                    {
                        MessageBox.Show("Filtrado por titulo completado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Texto a buscar no encontrado en este filtro", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "anio":
                    foreach (DataRow registro in titulosT.Rows)
                    {
                        string anio = registro["Anyo"].ToString();

                        if (anio.Contains(filtroTB.Text))
                        {
                            listView1.Items.Add(new ListViewItem(new string[] {registro["Titulo"].ToString(),
                            registro["Anyo"].ToString(), registro["ISBN"].ToString() }));
                            contador++;
                        }
                    }

                    if (contador > 0)
                    {
                        MessageBox.Show("Filtrado por año completado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Texto a buscar no encontrado en este filtro", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "isbn":
                    foreach (DataRow registro in titulosT.Rows)
                    {
                        string isbn = registro["ISBN"].ToString();

                        if (isbn.Contains(filtroTB.Text))
                        {
                            listView1.Items.Add(new ListViewItem(new string[] {registro["Titulo"].ToString(),
                            registro["Anyo"].ToString(), registro["ISBN"].ToString() }));
                            contador++;
                        }
                    }

                    if (contador > 0)
                    {
                        MessageBox.Show("Filtrado por ISBN completado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Texto a buscar no encontrado en este filtro", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "editores":
                    DataRow editor = ((DataRowView)editoresCB.SelectedItem).Row;
                    Console.WriteLine(editor["EdID"].ToString());

                    foreach (DataRow registro in titulosT.Rows)
                    {
                        if (registro["EdID"].Equals(editor["EdID"]))
                        {
                            listView1.Items.Add(new ListViewItem(new string[] {registro["Titulo"].ToString(),
                            registro["Anyo"].ToString(), registro["ISBN"].ToString() }));
                            contador++;
                        }
                    }

                    if (contador > 0)
                    {
                        MessageBox.Show("Filtrado por editor completado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

        }
    }
}
