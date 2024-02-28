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
    public partial class Actualizacion : Form
    {
        OleDbConnection ctn;
        IDbCommand cmd;
        IDataReader lector;
        int maxidEditores = 0;
        public Actualizacion()
        {
            InitializeComponent();

            try
            {
                ctn = new OleDbConnection();
                ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Temp\\Biblioteca.mdb";
                ctn.Open();

                editoresLB.Items.Clear();
                librosLB.Items.Clear();

                ctn.Close();

                #region Editores
                cargarEditores();

                ctn.Open();
                cmd = ctn.CreateCommand();
                cmd.CommandText = "SELECT MAX(EdID) from Editores";

                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    maxidEditores = lector.GetInt32(0)+1;
                }
                lector.Close();
                ctn.Close();
                #endregion

                #region Libros
                cargarLibros();
                #endregion

                ctn.Close();

                MessageBox.Show("Datos cargados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditoresLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editor editor = (Editor) editoresLB.SelectedItem;
            if (editoresLB.SelectedItem != null)
            {
                nombreTB.Text = editor.Nombre;
                direccionTB.Text = editor.Direccion;
                ciudadTB.Text = editor.Ciudad;
            }
        }

        private void LibrosLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro libro = (Libro)librosLB.SelectedItem;

            
            if (librosLB.SelectedItem != null)
            {
                ctn.Open();

                cmd = ctn.CreateCommand();
                cmd.CommandText = "select Nombre from Editores where EdID = " + libro.Edid;

                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    editorCB.Text = lector.GetString(0);
                }

                ctn.Close();
                tituloTB.Text = libro.Titulo;
                anioTB.Text = libro.Anyo.ToString();
                isbnTB.Text = libro.Isbn;
            }
        }

        private void LimpiareditorBT_Click(object sender, EventArgs e)
        {
            nombreTB.Text = "";
            direccionTB.Text = "";
            ciudadTB.Text = "";
            editoresLB.SelectedIndex = -1;
        }

        private void LimpiarlibroBT_Click(object sender, EventArgs e)
        {
            tituloTB.Text = "";
            editorCB.SelectedIndex = -1;
            editorCB.Text = "";
            anioTB.Text = "";
            isbnTB.Text = "";
            librosLB.SelectedIndex = -1;
        }

        private void NuevoBT_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if (!camposVaciosEditor())
                    {
                        ctn.Open();
                        cmd = ctn.CreateCommand();
                        cmd.CommandText = "INSERT INTO Editores (EdID, Nombre, Direccion, Ciudad) VALUES (" + maxidEditores
                            + ", '" + nombreTB.Text + "', '" + direccionTB.Text + "' , '" + ciudadTB.Text + "');";
                        cmd.ExecuteNonQuery();

                        ctn.Close();
                        MessageBox.Show("Editor " + nombreTB.Text + " ha sido creado con éxito", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarEditor();
                        cargarEditores();
                    }
                    else
                    {
                        MessageBox.Show("Por favor rellena todos los campos", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    break;

                case 1:
                    if (!camposVaciosLibro())
                    {
                        Editor editor = (Editor)editorCB.SelectedItem;
                        if (!comprobarISBN())
                        {
                            ctn.Open();
                            cmd = ctn.CreateCommand();
                            cmd.CommandText = "INSERT INTO Titulos (Titulo, Anyo, ISBN, EdID) VALUES('" + tituloTB.Text + "', "
                                + anioTB.Text + " , '" + isbnTB.Text + "', " + editor.Edid;
                            cmd.ExecuteNonQuery();

                            ctn.Close();

                            MessageBox.Show("Libro " + tituloTB.Text + " ha sido creado con éxito", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiarLibro();
                            cargarLibros();
                        } else
                        {
                            MessageBox.Show("Ese ISBN ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Por favor rellena todos los campos", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }

        private void ActualizarBT_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Editor editor = (Editor)editoresLB.SelectedItem;
                    if (!camposVaciosEditor())
                    {
                        ctn.Open();
                        cmd = ctn.CreateCommand();
                        cmd.CommandText = "UPDATE Editores SET EdID = "+ editor.Edid +", Nombre = '" + nombreTB.Text 
                            + "', Direccion = '"+ direccionTB.Text + "', Ciudad = " + ciudadTB.Text
                            + " WHERE EdID = " + editor.Edid;
                        cmd.ExecuteNonQuery();

                        ctn.Close();

                        MessageBox.Show("Editor " + nombreTB.Text + " ha sido modificado con éxito", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarEditor();
                        cargarEditores();
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona un editor", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case 1:
                    if (!camposVaciosLibro())
                    {
                        Libro libro = (Libro)librosLB.SelectedItem;

                        ctn.Open();
                        cmd = ctn.CreateCommand();
                        cmd.CommandText = "UPDATE Libros SET Titulo = '" + tituloTB.Text + "', Anyo = "
                            + Convert.ToInt32(anioTB.Text) + "', ISBN = '" + isbnTB.Text + "', EdID = "
                            + editorCB.SelectedItem +"  WHERE ISBN = " + libro.Isbn;
                        cmd.ExecuteNonQuery();

                        ctn.Close();

                        MessageBox.Show("Libro " + tituloTB.Text + " ha sido creado con éxito", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarLibro();
                        cargarLibros();
                    }

                    break;
            }
        }

        private void BorrarBT_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Editor editor = (Editor)editoresLB.SelectedItem;

                    if (editoresLB.SelectedIndex > 0)
                    {
                        ctn.Open();
                        cmd = ctn.CreateCommand();
                        cmd.CommandText = "DELETE FROM Editores WHERE EdID = " + editor.Edid;
                        cmd.ExecuteNonQuery();

                        ctn.Close();

                        limpiarEditor();
                        cargarEditores();

                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona un editor", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case 1:
                    Libro libro = (Libro)librosLB.SelectedItem;
                    if (librosLB.SelectedIndex > 0)
                    {
                        ctn.Open();
                        cmd = ctn.CreateCommand();
                        cmd.CommandText = "DELETE FROM Titulos WHERE ISBN = " + libro.Isbn;
                        cmd.ExecuteNonQuery();
                        ctn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona un libro", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void limpiarEditor()
        {
            nombreTB.Text = "";
            direccionTB.Text = "";
            ciudadTB.Text = "";
            editoresLB.SelectedIndex = -1;
        }

        private void limpiarLibro()
        {
            tituloTB.Text = "";
            editorCB.SelectedIndex = -1;
            editorCB.Text = "";
            anioTB.Text = "";
            isbnTB.Text = "";
            librosLB.SelectedIndex = -1;
        }

        private bool camposVaciosEditor()
        {
            return nombreTB.Text.Equals("") || direccionTB.Text.Equals("") || ciudadTB.Text.Equals("");
        }

        private bool camposVaciosLibro()
        {
            return tituloTB.Text.Equals("") || anioTB.Text.Equals("") || ciudadTB.Text.Equals("")
                || editorCB.Text.Equals("");
        }

        private void cargarEditores()
        {
            editoresLB.Items.Clear();

            ctn.Open();

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from Editores ORDER BY Nombre";

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Editor editor = new Editor(lector.GetInt32(0), lector.GetString(1),
                    lector.GetString(2), lector.GetString(3));
                editoresLB.Items.Add(editor);
                editorCB.Items.Add(editor);
            }
            lector.Close();

            ctn.Close();
        }

        private void cargarLibros()
        {
            librosLB.Items.Clear();
            ctn.Open();

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from Titulos ORDER BY Titulo";

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Libro libro = new Libro(lector.GetString(0), lector.GetInt16(1),
                    lector.GetString(2), lector.GetInt32(3));
                librosLB.Items.Add(libro);
            }
            lector.Close();

            ctn.Close();
        }

        private bool comprobarISBN()
        {
            Libro libro = (Libro)librosLB.SelectedItem;
            bool encontrado = false;

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Titulos WHERE ISBN = " + libro.Isbn;
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                encontrado = true;
            }
            ctn.Close();

            return encontrado;
        }
    }
}
