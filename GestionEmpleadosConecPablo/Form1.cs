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
    }
}
