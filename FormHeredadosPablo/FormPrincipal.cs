using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHeredadosPablo
{
    public partial class FormPrincipal : Form
    {

        public static SortedList<string, Usuario> usuarios = new SortedList<string, Usuario>();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OpcionMS(object sender, EventArgs e)
        {
            if (sender.ToString().Equals("Alta")) 
            {
                FormAlta alta = new FormAlta();
                alta.Show();
            } else if (sender.ToString().Equals("Consulta lista"))
            {
                FormConsultaList consultaList = new FormConsultaList();
                consultaList.Show();
            } else if (sender.ToString().Equals("Consulta tree"))
            {
                FormConsultaTree consultaTree = new FormConsultaTree();
                consultaTree.Show();

            } else if (sender.ToString().Equals("Salir"))
            {
                Dispose();
            }
        }
    }
}
