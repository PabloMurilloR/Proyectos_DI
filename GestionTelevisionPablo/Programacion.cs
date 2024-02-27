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
    public partial class Programacion : Form
    {
        OleDbDataAdapter daEmisiones;
        DataSet ds;
        DataTable emisionesT;
        DataTable eventosT;
        DataTable paisesproduccionT;
        DataTable ratingsT;
        DataTable subgenerosT;
        DataTable generosT;
        int MaxIdEmision = 0;
        string idEmision;

        public Programacion(DataTable emisionesT, DataTable paisesproduccionT, DataTable subgenerosT,
            DataTable generosT, DataTable ratingsT, DataTable eventosT, OleDbDataAdapter daEmisiones, DataSet ds)
        {
            InitializeComponent();

            #region Emisiones
            this.emisionesT = emisionesT;

            this.titulotraducidoCB.DataSource = emisionesT;
            this.titulotraducidoCB.DisplayMember = "TituloTraducido";
            this.titulotraducidoCB.SelectedIndex = -1;
            #endregion

            #region Paises Produccion
            this.paisesproduccionT = paisesproduccionT;

            this.ppCB.DataSource = paisesproduccionT;
            this.ppCB.DisplayMember = "DescPais";
            this.ppCB.SelectedIndex = -1;
            #endregion

            #region Subgeneros
            this.subgenerosT = subgenerosT;

            this.subgeneroCB.DataSource = subgenerosT;
            this.subgeneroCB.DisplayMember = "Subgenero";
            this.subgeneroCB.SelectedIndex = -1;
            #endregion

            #region Generos
            this.generosT = generosT;

            this.generoCB.DataSource = generosT;
            this.generoCB.DisplayMember = "Genero";
            this.generoCB.SelectedIndex = -1;
            #endregion

            #region Ratings
            this.ratingsT = ratingsT;

            this.ratingCB.DataSource = ratingsT;
            this.ratingCB.DisplayMember = "Rating";
            this.ratingCB.SelectedIndex = -1;
            #endregion

            #region Eventos
            this.eventosT = eventosT;
            #endregion

            this.daEmisiones = daEmisiones;
            this.ds = ds;
        }

        private void SalirProg_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BuscarBT_Click(object sender, EventArgs e)
        {
            if ((DataRowView)titulotraducidoCB.SelectedItem != null)
            {
                DataRow tituloTrad = ((DataRowView)titulotraducidoCB.SelectedItem).Row;

                idEmision = tituloTrad["IdEmision"].ToString();

                tituloTB.Text = tituloTrad["TituloOriginal"].ToString();
                anioTB.Text = tituloTrad["YearProduccion"].ToString();
                actoresTB.Text = tituloTrad["Actores"].ToString();
                directorTB.Text = tituloTrad["Director"].ToString();
                sinopsisTB.Text = tituloTrad["Sinopsis"].ToString();
                duracionTB.Text = tituloTrad["Duracion"].ToString().Substring(11);

                int pos = 0;
                foreach (DataRow registro in paisesproduccionT.Rows)
                {
                    if (registro["idPais"].Equals(tituloTrad["IdPais"]))
                    {
                        ppCB.SelectedIndex = pos;
                    }
                    pos++;
                }

                pos = 0;

                string idgen = "";
                foreach (DataRow registro in subgenerosT.Rows)
                {
                    if (registro["idsubgenero"].Equals(tituloTrad["idsubgenero"]))
                    {
                        subgeneroCB.SelectedIndex = pos;

                        idgen = registro["idgenero"].ToString();
                    }
                    pos++;
                }

                pos = 0;
                foreach (DataRow registro in generosT.Rows)
                {
                    if (registro["idgenero"].ToString().Equals(idgen))
                    {
                        generoCB.SelectedIndex = pos;
                        pos++;
                    }
                }

                pos = 0;
                foreach (DataRow registro in ratingsT.Rows)
                {
                    if (registro["idrating"].Equals(tituloTrad["idrating"]))
                    {
                        ratingCB.SelectedIndex = pos;
                    }
                    pos++;
                }

                eventosT.DefaultView.RowFilter = "idemision = " + Convert.ToString(tituloTrad["idemision"]);

                dataGridView1.DataSource = eventosT;
                dataGridView1.Columns["idemision"].Visible = false;
                dataGridView1.Columns["canal"].ReadOnly = true;
                dataGridView1.Columns["fecha"].ReadOnly = true;
                dataGridView1.Columns["hora"].ReadOnly = true;
                dataGridView1.Columns["codificado"].ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Pelicula no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        private void BorrarBT_Click(object sender, EventArgs e)
        {
            if ((DataRowView)titulotraducidoCB.SelectedItem != null)
            {
                ((DataRowView)titulotraducidoCB.SelectedItem).Row.Delete();

                MessageBox.Show("Pelicula borrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
                titulotraducidoCB.SelectedIndex = -1;
                daEmisiones.Update(ds, "Emisiones");
            } else
            {
                MessageBox.Show("No ha seleccionado una película válida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            tituloTB.Text = "";
            ppCB.SelectedIndex = -1;
            anioTB.Text = "";
            ratingCB.SelectedIndex = -1;
            duracionTB.Text = "";
            actoresTB.Text = "";
            directorTB.Text = "";
            sinopsisTB.Text = "";
            generoCB.SelectedIndex = -1;
            subgeneroCB.SelectedIndex = -1;
        }

        private void NuevoBT_Click(object sender, EventArgs e)
        {
            try
            {
                bool usuarioExistente = false;

                foreach (DataRow registro in emisionesT.Rows)
                {
                    int id = Convert.ToInt32(registro["IdEmision"]);
                    if (id > MaxIdEmision)
                    {
                        MaxIdEmision = id;
                    }
                    if (registro["TituloOriginal"].Equals(titulotraducidoCB.Text))
                    {
                        MessageBox.Show("Pelicula ya existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        titulotraducidoCB.Text = "";
                        usuarioExistente = true;
                    }
                }

                if (!HayCamposVacios() && !usuarioExistente)
                {
                    DataRow nuevaFila = emisionesT.NewRow();
                    MaxIdEmision++;
                    nuevaFila["IdEmision"] = MaxIdEmision;
                    nuevaFila["TituloTraducido"] = titulotraducidoCB.Text;
                    nuevaFila["TituloOriginal"] = tituloTB.Text;
                    nuevaFila["IdPais"] = ((DataRowView)ppCB.SelectedItem)["idpais"];
                    nuevaFila["YearProduccion"] = anioTB.Text;
                    nuevaFila["IdSubgenero"] = ((DataRowView)subgeneroCB.SelectedItem)["idsubgenero"];
                    nuevaFila["IdRating"] = ((DataRowView)ratingCB.SelectedItem)["idrating"];
                    nuevaFila["Duracion"] = duracionTB.Text;
                    nuevaFila["Actores"] = actoresTB.Text;
                    nuevaFila["Director"] = directorTB.Text;
                    nuevaFila["Sinopsis"] = sinopsisTB.Text;

                    MessageBox.Show("Pelicula " + titulotraducidoCB.Text + " creada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    emisionesT.Rows.Add(nuevaFila);
                    daEmisiones.Update(ds, "Emisiones");
                }
                else
                {
                    MessageBox.Show("Hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                limpiar();
                titulotraducidoCB.SelectedIndex = -1;
                daEmisiones.Update(ds, "Emisiones");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de año o duración inválido.", "Formato inválido", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato de duración inválido.", "Formato inválido", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private bool HayCamposVacios()
        {
            return titulotraducidoCB.Text.Equals("") || tituloTB.Text.Equals("") ||
                ppCB.SelectedIndex == -1 || anioTB.Text.Equals("") ||
                generoCB.SelectedIndex == -1 || subgeneroCB.SelectedIndex == -1 ||
                ratingCB.SelectedIndex == -1 || duracionTB.Text.Equals("") ||
                actoresTB.Text.Equals("") || directorTB.Text.Equals("") ||
                sinopsisTB.Text.Equals("");
        }

        private void ModificarBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HayCamposVacios())
                {
                    DataRow[] filaencontrada = emisionesT.Select($"IdEmision =" + idEmision);
                    DataRow filaModificar = filaencontrada[0];
                    filaModificar.BeginEdit();
                    filaModificar["titulooriginal"] = tituloTB.Text;
                    filaModificar["titulotraducido"] = titulotraducidoCB.Text;
                    filaModificar["idsubgenero"] = ((DataRowView)subgeneroCB.SelectedItem)["idsubgenero"];
                    filaModificar["duracion"] = duracionTB.Text;
                    filaModificar["yearproduccion"] = anioTB.Text;
                    filaModificar["actores"] = actoresTB.Text;
                    filaModificar["director"] = directorTB.Text;
                    filaModificar["sinopsis"] = sinopsisTB.Text;
                    filaModificar["idrating"] = ((DataRowView)ratingCB.SelectedItem)["idrating"];
                    filaModificar["idpais"] = ((DataRowView)ppCB.SelectedItem)["idpais"];
                    filaModificar.EndEdit();

                    MessageBox.Show("Película " + tituloTB.Text + " modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    titulotraducidoCB.SelectedIndex = -1;
                    limpiar();
                    titulotraducidoCB.Text = "";
                    daEmisiones.Update(ds, "Emisiones");
                }
                else
                {
                    MessageBox.Show("Hay campos vacíos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de año inválido.", "Formato inválido", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No ha seleccionado una película válida.", "Selección inválida", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            } catch (ArgumentException)
            {
                MessageBox.Show("Formato de duración inválido.", "Formato inválido", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void subgeneroCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (generosT != null && ((ComboBox)sender).SelectedItem != null)
            {
                int idGen = (int)((DataRowView)((ComboBox)sender).SelectedItem).Row["idgenero"];
                generosT.DefaultView.RowFilter = "idgenero = " + idGen;
            }
        }
    }
}
