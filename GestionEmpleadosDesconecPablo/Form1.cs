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

namespace GestionEmpleadosDesconecPablo
{
    public partial class Form1 : Form
    {
        OleDbConnection ctn;
        OleDbCommand cmd;
        DataSet ds;
        OleDbDataAdapter daDepart;
        OleDbDataAdapter daEmple;
        OleDbCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();

            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Temp\\Emple.mdb";
            ctn.Open();

            ds = new DataSet();

            #region Tabla Depart
            cmd = new OleDbCommand();
            cmd.Connection = ctn;
            cmd.CommandText = "SELECT * from DEPART";

            daDepart = new OleDbDataAdapter();
            cb = new OleDbCommandBuilder(daDepart);
            daDepart.SelectCommand = cmd;

            daDepart.Fill(ds, "DEPART");

            DataTable tabla = ds.Tables["DEPART"];

            foreach (DataRow registro in tabla.Rows)
            {
                this.NumLB.Items.Add(registro["DEPT_NO"]);
                this.DepartamentoLB.Items.Add(registro["DNOMBRE"]);
                this.LocalizacionLB.Items.Add(registro["LOC"]);
            }
            #endregion

            #region Tabla Emple
            cmd = new OleDbCommand();
            cmd.Connection = ctn;
            cmd.CommandText = "SELECT * from EMPLE";

            daEmple = new OleDbDataAdapter();
            cb = new OleDbCommandBuilder(daEmple);
            daEmple.SelectCommand = cmd;

            daEmple.Fill(ds, "EMPLE");
            #endregion

            ctn.Close();
        }

        private void SalirB_Click(object sender, EventArgs e)
        {
            daEmple.Update(ds, "EMPLE");
            ds.AcceptChanges();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void DepartamentoLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NumLB.SelectedIndex = this.DepartamentoLB.SelectedIndex;
            this.LocalizacionLB.SelectedIndex = this.DepartamentoLB.SelectedIndex;

            rellenarUsuarios();
        }

        private void LocalizacionLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NumLB.SelectedIndex = this.LocalizacionLB.SelectedIndex;
            this.DepartamentoLB.SelectedIndex = this.LocalizacionLB.SelectedIndex;

        }

        public void limpiarLB()
        {
            EmpNumLB.Items.Clear();
            ApellidosLB.Items.Clear();
            OficioLB.Items.Clear();
            SalarioLB.Items.Clear();
            FechaAltaLB.Items.Clear();
            ComisionLB.Items.Clear();
        }

        private void ApellidosLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EmpNumLB.SelectedIndex = this.ApellidosLB.SelectedIndex;
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
            else if (this.ApellidosLB.SelectedIndex > 0)
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
            this.EmpNumLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.ApellidosLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.OficioLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.OficioLB.SelectedIndex;

            this.OficioTB.Text = OficioLB.SelectedItem.ToString();
        }

        private void SalarioLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EmpNumLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.ApellidosLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.OficioLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.SalarioLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.SalarioLB.SelectedIndex;

            this.SalarioTB.Text = SalarioLB.SelectedItem.ToString();
        }

        private void FechaAltaLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EmpNumLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.ApellidosLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.OficioLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;
            this.ComisionLB.SelectedIndex = this.FechaAltaLB.SelectedIndex;

            this.FechaAltaDT.Value = DateTime.Parse(FechaAltaLB.Text.ToString());
        }

        private void ComisionLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EmpNumLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.ApellidosLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.OficioLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.SalarioLB.SelectedIndex = this.ComisionLB.SelectedIndex;
            this.FechaAltaLB.SelectedIndex = this.ComisionLB.SelectedIndex;

            this.ComisionTB.Text = ComisionLB.SelectedItem.ToString();
        }

        private void BusquedaB_Click(object sender, EventArgs e)
        {
            limpiarLB();

            int consulta = 0;
            bool numero = false;

            switch (BuscarLB.SelectedItem.ToString())
            {
                case "Apellidos":
                    consulta = 1;
                    break;
                case "Oficio":
                    consulta = 2;
                    break;
                case "Salario":
                    consulta = 5;
                    numero = true;
                    break;
                case "Fecha Alta":
                    consulta = 4;
                    break;
                case "Comisión":
                    consulta = 6;
                    numero = true;
                    break;
            }

            limpiarLB();

            DataTable tabla = ds.Tables["EMPLE"];

            foreach (DataRow registro in tabla.Rows)
            {
                if (registro[consulta].Equals(BusquedaTB.Text.ToString()))
                {

                    ApellidosTB.Text = Convert.ToString(registro["APELLIDO"]);
                    OficioTB.Text = Convert.ToString(registro["OFICIO"]);
                    SalarioTB.Text = Convert.ToString(registro["SALARIO"]);
                    FechaAltaDT.Value = Convert.ToDateTime(registro["FECHA_ALT"]);
                    ComisionTB.Text = Convert.ToString(registro["COMISION"]);
                    EmpNumTB.Text = Convert.ToString(registro["EMP_NO"]);

                    this.ApellidosLB.Items.Add(registro["APELLIDO"]);
                    ApellidosLB.SelectedItem = true;
                    this.OficioLB.Items.Add(registro["OFICIO"]);
                    OficioLB.SelectedItem = true;
                    this.SalarioLB.Items.Add(registro["SALARIO"]);
                    SalarioLB.SelectedItem = true;
                    this.FechaAltaLB.Items.Add(registro["FECHA_ALT"]);
                    FechaAltaLB.SelectedItem = true;
                    this.ComisionLB.Items.Add(registro["COMISION"]);
                    ComisionLB.SelectedItem = true;
                    this.EmpNumLB.Items.Add(registro["EMP_NO"]);
                    EmpNumLB.SelectedItem = true;
                }
            }

        }

        private void limpiar()
        {
            ApellidosTB.Text = "";
            OficioTB.Text = "";
            SalarioTB.Text = "";
            FechaAltaDT.Value = DateTime.Today;
            ComisionTB.Text = "";
            EmpNumTB.Text = "";
        }

        private void BorrarB_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["EMPLE"];
            int indexaux = -1;
            int index = 0;
            foreach (DataRow registro in tabla.Rows)
            {
                indexaux++;
                if (registro["EMP_NO"].Equals(this.EmpNumLB.SelectedItem))
                {
                    index = indexaux;

                }
            }

            DataRow reg = tabla.Rows[index];
            reg.Delete();

            rellenarUsuarios();
            limpiar();
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["EMPLE"];
            int indexaux = -1;
            int index = 0;
            foreach (DataRow registro in tabla.Rows)
            {
                indexaux++;
                if (registro["EMP_NO"].Equals(this.EmpNumLB.SelectedItem))
                {
                    index = indexaux;
                }
            }

            DataRow reg = tabla.Rows[index];

            reg.BeginEdit();

            reg["APELLIDO"] = ApellidosTB.Text;
            reg["OFICIO"] = OficioTB.Text;
            reg["SALARIO"] = Int32.Parse(SalarioTB.Text);
            reg["COMISION"] = Int32.Parse(ComisionTB.Text);
            reg["FECHA_ALT"] = FechaAltaDT.Value;

            reg.EndEdit();

            rellenarUsuarios();
        }

        private void NuevoB_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["EMPLE"];

            bool usuarioExistente = false;

            foreach (DataRow registro in tabla.Rows)
            {
                string fechaTiempo = FechaAltaDT.Value.Year.ToString() + "/" + FechaAltaDT.Value.Year.ToString()
                    + "/" + FechaAltaDT.Value.Year.ToString();
                string fecha = registro["FECHA_ALT"].ToString().Substring(0, registro["FECHA_ALT"].ToString().IndexOf(' '));
                if (registro["APELLIDO"].Equals(ApellidosLB.Text.ToString().ToUpper()) && fecha.Equals(fechaTiempo))
                {
                    usuarioExistente = true;
                }

            }

            if (!usuarioExistente)
            {
                Random random = new Random();

                int numero = 0;
                bool encontrado = false;

                do
                {
                    numero = random.Next(10000);

                    foreach (DataRow registro in tabla.Rows)
                    {
                        if (Convert.ToInt32(registro["EMP_NO"]) == numero)
                        {
                            encontrado = true;
                        }

                    }
                }
                while (encontrado == true);

                DataRow reg = tabla.NewRow();

                reg["EMP_NO"] = numero;
                reg["APELLIDO"] = ApellidosTB.Text;
                reg["OFICIO"] = OficioTB.Text;
                reg["DIR"] = 0;
                reg["FECHA_ALT"] = FechaAltaDT.Value;
                reg["SALARIO"] = Int32.Parse(SalarioTB.Text);
                reg["COMISION"] = Int32.Parse(ComisionTB.Text);
                reg["DEPT_NO"] = 40;

                tabla.Rows.Add(reg);

                limpiar();
            }
        }

        private void rellenarUsuarios()
        {
            limpiarLB();

            DataTable tabla = ds.Tables["EMPLE"];

            foreach (DataRow registro in tabla.Rows)
            {
                if (registro["DEPT_NO"].Equals(this.NumLB.SelectedItem))
                {
                    this.EmpNumLB.Items.Add(registro["EMP_NO"]);
                    this.ApellidosLB.Items.Add(registro["APELLIDO"]);
                    this.OficioLB.Items.Add(registro["OFICIO"]);
                    this.SalarioLB.Items.Add(registro["SALARIO"]);
                    this.FechaAltaLB.Items.Add(registro["FECHA_ALT"]);
                    this.ComisionLB.Items.Add(registro["COMISION"]);
                }
            }
        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
            daEmple.Update(ds, "EMPLE");
            ds.AcceptChanges();
            limpiar();
        }
    }
}
