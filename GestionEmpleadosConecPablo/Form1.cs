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

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from EMPLE where " ;

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.EmpNumLB.Items.Add(lector.GetValue(0));
                this.ApellidosLB.Items.Add(lector.GetValue(1));
                this.OficioLB.Items.Add(lector.GetString(2));
                this.SalarioLB.Items.Add(lector.GetValue(3));
                this.FechaAltaLB.Items.Add(lector.GetValue(4));
                this.ComisionLB.Items.Add(lector.GetValue(5));
            }
            lector.Close();
        }

        private void limpiar()
        {
            ApellidosTB.Text = "";
            OficioTB.Text = "";
            SalarioTB.Text = "";
            FechaAltaDT.Value = DateTime.Today;
            ComisionTB.Text = "";
        }

        private void BorrarB_Click(object sender, EventArgs e)
        {
            cmd = ctn.CreateCommand();
            cmd.CommandText = "DELETE FROM EMPLE WHERE emp_no = "+ EmpNumLB.SelectedItem.ToString();

            lector = cmd.ExecuteReader();
            lector.Close();
            rellenarUsuarios();
            limpiar();
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            cmd = ctn.CreateCommand();
            cmd.CommandText = "UPDATE EMPLE SET APELLIDO = '" + ApellidosTB.Text + "', OFICIO = '" + OficioTB.Text +
                "', SALARIO = "+ Int32.Parse(SalarioTB.Text) + ", COMISION = "
                + Int32.Parse(ComisionTB.Text)+" WHERE EMP_NO = "+ EmpNumLB.SelectedItem.ToString() ;

            lector = cmd.ExecuteReader();
            lector.Close();
            rellenarUsuarios();
            

        }

        private void NuevoB_Click(object sender, EventArgs e)
        {
            ctn.Open();

            cmd.CommandText = "select * From emple";
            lector = cmd.ExecuteReader();
            bool usuarioExistente = false;

            while (lector.Read())
            {
                string fechaTiempo = FechaAltaDT.Value.Year.ToString() + "/" + FechaAltaDT.Value.Year.ToString() + "/" + FechaAltaDT.Value.Year.ToString();
                string fecha = lector.GetValue(4).ToString().Substring(0, lector.GetValue(4).ToString().IndexOf(' '));
                if ((lector.GetString(1).Equals(ApellidosLB.Text.ToString().ToUpper())) && fecha.Equals(fechaTiempo))
                {
                    usuarioExistente = false;
                }

            }

            lector.Close();
            ctn.Close();

            if (!usuarioExistente)
            { 
                Random random = new Random();

                int numero = 0;
                bool encontrado = false;

                do
                {
                    ctn.Open();

                    cmd.CommandText = "select EMP_NO From EMPLE";
                    lector = cmd.ExecuteReader();
                    numero = random.Next(10000);

                    while (lector.Read())
                    {
                        if (Convert.ToInt32(lector.GetValue(0)) == numero)
                        {
                            encontrado = true;
                        }

                    }

                    lector.Close();
                    ctn.Close();
                }
                while (encontrado == true);

                ctn.Open();

                cmd.CommandText = "INSERT into EMPLE (EMP_NO,APELLIDO,OFICIO,SALARIO,FECHA_ALT,COMISION,DEPT_NO) values('"
                    + numero + "','" + ApellidosTB.Text.ToUpper().ToString() + "','" +
                    OficioTB.Text.ToUpper().ToString() + "','" + Int32.Parse(SalarioTB.Text.ToString())
                    + "','" + System.DateTime.Now + "','" +
                    Int32.Parse(ComisionTB.Text.ToString()) + "','" + "30" + "');";


                MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                ctn.Close();
            }

            lector.Close();

            rellenarUsuarios();
        }

        private void rellenarUsuarios()
        {
            limpiarLB();

            cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from EMPLE where DEPT_NO =" + NumLB.SelectedItem;

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.EmpNumLB.Items.Add(lector.GetValue(0));
                this.ApellidosLB.Items.Add(lector.GetValue(1));
                this.OficioLB.Items.Add(lector.GetString(2));
                this.SalarioLB.Items.Add(lector.GetValue(5));
                this.FechaAltaLB.Items.Add(lector.GetValue(4));
                this.ComisionLB.Items.Add(lector.GetValue(6));
            }
            lector.Close();
        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
