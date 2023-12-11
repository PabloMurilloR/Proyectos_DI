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

namespace ExamenGestionHotelesPablo
{
    public partial class Reserva : Form
    {
        private ArrayList reservas = new ArrayList();
        private ArrayList categorias = new ArrayList();

        public Reserva()
        {
            cargarReservas();
            InitializeComponent();
            cargarLB();
            cargarReservasLB();
        }

        private void EliminarFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CategoriaLB.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado nigun filtro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategoriaLB.ClearSelected();
            }
        }

        public void cargarReservas()
        {
            reservas.Add(new ReservaC("Pablo", "Murillo", "12/12/2023", "Standard"));
            reservas.Add(new ReservaC("Pablo", "Murillo", "15/12/2023", "Premium"));
            reservas.Add(new ReservaC("Alejandro", "Sanchez", "20/05/2024", "Premium"));
            reservas.Add(new ReservaC("Pablo", "Murillo", "20/01/2024", "Basic"));
            reservas.Add(new ReservaC("Pepe", "Lopez", "20/11/2024", "Basic"));
            reservas.Add(new ReservaC("Pablo", "Murillo", "10/02/2023", "Exclusive"));
            reservas.Add(new ReservaC("Pepe", "Lopez", "15/12/2023", "Exclusive"));

        }

        public void cargarReservasLB()
        {
            reservasLB.Items.Clear();
            foreach (ReservaC item in reservas)
            {
                reservasLB.Items.Add(new ListViewItem(new string[] {item.Nombre + item.Apellidos,
                    item.Fecha, item.Categoria}));
            }
        }

        public void cargarLB()
        {
            categorias.Clear();
            foreach (ReservaC r in reservas)
            {
              if (!categorias.Contains(r.Categoria))
                {
                    categorias.Add(r.Categoria);
                }
            }
            CategoriaLB.Items.AddRange(categorias.ToArray());
        }

        private void CategoriaLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            reservasLB.Items.Clear();
            foreach (ReservaC item in reservas)
            {
                if (CategoriaLB.SelectedItem == null)
                {
                    reservasLB.Items.Add(new ListViewItem(new string[] {item.Nombre + item.Apellidos,
                        item.Fecha, item.Categoria}));
                }
                else if (item.Categoria.Equals(CategoriaLB.Text))
                {
                    reservasLB.Items.Add(new ListViewItem(new string[] {item.Nombre + item.Apellidos,
                        item.Fecha, item.Categoria}));
                }
            }
        }
    }
}
