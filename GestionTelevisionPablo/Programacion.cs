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
    public partial class Programacion : Form
    {
        DataTable emisionesT;
        DataTable eventosT;
        DataTable canalesT;
        DataTable paisesproduccionT;
        DataTable ratingsT;
        DataTable subgenerosT;
        DataTable generosT;

        public Programacion(DataTable emisionesT, DataTable paisesproduccionT, DataTable subgenerosT,
            DataTable generosT, DataTable ratingsT, DataTable eventosT, DataTable canalesT)
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

            #region Canales
            this.canalesT = canalesT;
            #endregion

        }

        private void SalirProg_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BuscarBT_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow tituloTrad = ((DataRowView)titulotraducidoCB.SelectedItem).Row;

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
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Pelicula no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarBT_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)titulotraducidoCB.SelectedItem).Row.Delete();
                limpiar();
            }
            catch (NullReferenceException)
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
            generoCB.SelectedIndex = -1;
            subgeneroCB.SelectedIndex = -1;
            ratingCB.SelectedIndex = -1;
            duracionTB.Text = "";
            actoresTB.Text = "";
            directorTB.Text = "";
            sinopsisTB.Text = "";
        }

        private void NuevoBT_Click(object sender, EventArgs e)
        {
            limpiar();
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

        private void ModoficarBT_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow filaNueva = ((DataRowView)titulotraducidoCB.SelectedItem).Row;
                if (!HayCamposVacios())
                {
                    filaNueva.BeginEdit();
                    filaNueva["titulooriginal"] = tituloTB.Text;
                    filaNueva["titulotraducido"] = titulotraducidoCB.Text;
                    filaNueva["idsubgenero"] = Convert.ToInt32(subgeneroCB.SelectedValue);
                    filaNueva["duracion"] = DateTime.Parse(duracionTB.Text);
                    filaNueva["yearproduccion"] = Convert.ToInt32(anioTB.Text);
                    filaNueva["actores"] = actoresTB.Text;
                    filaNueva["director"] = directorTB.Text;
                    filaNueva["sinopsis"] = sinopsisTB.Text;
                    filaNueva["idrating"] = Convert.ToInt32(ratingCB.SelectedValue);
                    filaNueva["idpais"] = Convert.ToInt32(ppCB.SelectedValue);
                    filaNueva.EndEdit();

                    limpiar();

                }
                else
                {
                    MessageBox.Show("Hay campos vacíos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de año o duración inválidos.", "Formato inválido", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No ha seleccionado una película válida.", "Selección inválida", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
