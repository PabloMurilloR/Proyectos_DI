using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenBibliotecaPablo
{
    public partial class gestionBiblioteca : Form
    {
        public gestionBiblioteca()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Consulta"))
                {
                    form = fForm;
                }
                else
                {
                    fForm.Hide();
                }
            }

            if (form == null)
            {
                form = new Consulta();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Visible = true;
            }
        }

        private void ActualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Actualizacion"))
                {
                    form = fForm;
                }
                else
                {
                    fForm.Hide();
                }
            }

            if (form == null)
            {
                form = new Actualizacion();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Visible = true;
            }
        }
    }
}
