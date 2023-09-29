using System;
using System.Windows.Forms;

namespace BibliotecaPablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = "Hora actual: "+DateTime.Now.ToString("HH:mm:ss");
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("Alta") == false)
            {
                Alta alta = new Alta();
                alta.MdiParent = this;
                alta.Dock = DockStyle.Fill;
                alta.Show();
            }
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("Consulta") == false)
            {
                Consulta consulta = new Consulta();
                consulta.MdiParent = this;
                consulta.Dock = DockStyle.Fill;
                consulta.Show();
            }
        }

        bool formIsOpen(string nombre_form)
        {
            foreach (var form_hijo in this.MdiChildren)
            {
                if (form_hijo.Text == nombre_form)
                {
                    form_hijo.BringToFront();
                    return true;
                }
            }
            return false;
        }
    }
}
