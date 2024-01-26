using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GestionEmpleadosConecPablo
{
    public partial class Form1 : Form
    {
        private OleDbConnection ctn;
        IDbCommand cmd;
        IDataReader lector;

        public Form1()
        {
            InitializeComponent();
        }

        private void SalirB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Temp\\Emple.mdb";
            ctn.Open();

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from DEPART";

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.NumLB.Items.Add(lector.GetValue(0));
                this.DepartamentoLB.Items.Add(lector.GetString(1));
                this.LocalizacionLB.Items.Add(lector.GetString(2));
            }
            lector.Close();

        }

        private void DepartamentoLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ListBox tabla Departamentos
            this.NumLB.SelectedIndex = this.DepartamentoLB.SelectedIndex;
            this.LocalizacionLB.SelectedIndex = this.DepartamentoLB.SelectedIndex;
            #endregion

            #region ListBox de informacion del empleado
            limpiarLB();

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from EMPLE where DEPT_NO ="+ NumLB.SelectedItem;

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.ApellidosLB.Items.Add(lector.GetValue(1));
                this.OficioLB.Items.Add(lector.GetString(2));
                this.SalarioLB.Items.Add(lector.GetValue(3));
                this.FechaAltaLB.Items.Add(lector.GetValue(4));
                this.ComisionLB.Items.Add(lector.GetValue(5));
            }
            lector.Close();
            #endregion
        }

        private void LocalizacionLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NumLB.SelectedIndex = this.LocalizacionLB.SelectedIndex;
            this.DepartamentoLB.SelectedIndex = this.LocalizacionLB.SelectedIndex;
        }

        public void limpiarLB()
        {
            ApellidosLB.Items.Clear();
            OficioLB.Items.Clear();
            SalarioLB.Items.Clear();
            FechaAltaLB.Items.Clear();
            ComisionLB.Items.Clear();
        }

        private void ApellidosLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.OficioLB.SelectedIndex = this.ApellidosLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.ApellidosLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.ApellidosLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.ApellidosLB.SelectedIndex;

            this.ApellidosTB.Text = ApellidosLB.SelectedItem.ToString();
        }

        private void ArribaB_Click(object sender, EventArgs e)
        {
            if (ApellidosLB.Items.Count == 0)
            {

            }
            else if(this.ApellidosLB.SelectedIndex > 0)
            {
                this.ApellidosLB.SelectedIndex--;
            }
            else
            {
                this.ApellidosLB.SelectedIndex = this.ApellidosLB.Items.Count - 1;
            }

        }

        private void AbajoB_Click(object sender, EventArgs e)
        {
            if (ApellidosLB.Items.Count == 0)
            {

            }
            else if (this.ApellidosLB.SelectedIndex < this.ApellidosLB.Items.Count - 1)
            {
                this.ApellidosLB.SelectedIndex++;
            }
            else
            {
                this.ApellidosLB.SelectedIndex = 0;
            }
        }

        private void OficioLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApellidosLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.OficioLB.SelectedIndex;

            this.OficioTB.Text = OficioLB.SelectedItem.ToString();
        }

        private void SalarioLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApellidosLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.OficioLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.SalarioLB.SelectedIndex;

            this.SalarioTB.Text = SalarioLB.SelectedItem.ToString();
        }

        private void FechaAltaLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApellidosLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.OficioLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;

            this.FechaAltaTB.Text = FechaAltaLB.SelectedItem.ToString();
        }

        private void ComisionLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApellidosLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.OficioLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.ComisionLB.SelectedIndex;

            this.ComisionTB.Text = ComisionLB.SelectedItem.ToString();
        }

        private void BusquedaB_Click(object sender, EventArgs e)
        {
            limpiarLB();

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from EMPLE where "+ ;

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.ApellidosLB.Items.Add(lector.GetValue(1));
                this.OficioLB.Items.Add(lector.GetString(2));
                this.SalarioLB.Items.Add(lector.GetValue(3));
                this.FechaAltaLB.Items.Add(lector.GetValue(4));
                this.ComisionLB.Items.Add(lector.GetValue(5));
            }
            lector.Close();
        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
            ApellidosTB.Text = "";
            OficioTB.Text = "";
            SalarioTB.Text = "";
            FechaAltaTB.Text = "";
            ComisionTB.Text = "";
        }
    }
}
