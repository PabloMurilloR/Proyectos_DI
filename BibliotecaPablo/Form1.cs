using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            new Alta().Show();
        }
    }
}
