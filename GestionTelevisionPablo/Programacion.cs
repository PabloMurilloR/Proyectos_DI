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
            DataRow tituloTrad = ((DataRowView) titulotraducidoCB.SelectedItem).Row;
            foreach (DataRow registro in emisionesT.Rows)
            {
                if (registro["IdEmision"].Equals(tituloTrad["IdEmision"]))
                {

                }
            }
        }
    }
}
