using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGestionHotelesPablo
{
    public partial class Form1 : Form
    {

        //private SortedList<string, Persona> clientes = new SortedList<string, Persona>();
        //private SortedList<string, ReservaC> reservas = new SortedList<string, ReservaC>();
        public Form1()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("Cliente") == false)
            {
                Cliente cliente = new Cliente();
                cliente.MdiParent = this;
                cliente.Dock = DockStyle.Fill;
                cliente.Show();
            }
        }


        private void ReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("Reserva") == false)
            {
                Reserva reserva = new Reserva();
                reserva.MdiParent = this;
                reserva.Dock = DockStyle.Fill;
                reserva.Show();
            }
        }

        private void FicheroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichero de clientes|*.txt|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar fichero";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.OpenFile();
                }
            }
        }

        private void FicheroReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichero de reservas|*.txt|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar fichero";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.OpenFile();
                }
            }
        }
    }
}
