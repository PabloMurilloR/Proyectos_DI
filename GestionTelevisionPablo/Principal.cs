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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ProgramacionYEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Programacion"))
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
                form = new Programacion();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Visible = true;
            }
        }

        private void MantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form fForm in MdiChildren)
            {
                if (fForm.Name.Equals("Usuarios"))
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
                form = new Usuarios();
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
