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
    public partial class Cliente : Form
    {
        private SortedList<string, Persona> clientes = new SortedList<string, Persona>();
        ArrayList clientesALT = new ArrayList();

        public Cliente()
        {
            InitializeComponent();
            cargarClientes();
            cargarCB();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            if (clientes.ContainsKey(nombreTB.Text + apellidosTB.Text))
            {
                MessageBox.Show("Ese cliente ya existe", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombreTB.Text == "" || apellidosTB.Text == "" || telefonoTB.Text == ""
                || comentariosTB.Text == "")
            {
                MessageBox.Show("Rellena todos los campos por favor", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                Persona p = new Persona(nombreTB.Text, apellidosTB.Text,
                telefonoTB.Text, comentariosTB.Text);

                clientes.Add(nombreTB.Text, p);
                clientesALT.Add(nombreTB.Text + ", " + apellidosTB.Text);

                MessageBox.Show("Cliente modificado con exito", "Guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            cargarCB();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            clientes.Remove(nombreTB.Text);

            Persona p = new Persona(nombreTB.Text, apellidosTB.Text,
                telefonoTB.Text, comentariosTB.Text);

            clientes.Add(nombreTB.Text, p);
            MessageBox.Show("Cliente modificado con exito", "Guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            clientesCB.SelectedItem = null;
            limpiar();
        }


        private void Borrar_Click(object sender, EventArgs e)
        {
            if (nombreTB.Text == "" || apellidosTB.Text == "")
            {
                MessageBox.Show("Error", "Escribe un nombre y apellido por favor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clientes.Remove(nombreTB.Text);
                MessageBox.Show("Cliente borado con exito", "Guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
            }
        }

        public void limpiar()
        {
            nombreTB.Text = "";
            apellidosTB.Text = "";
            telefonoTB.Text = "";
            comentariosTB.Text = "";
        }

        public void cargarClientes()
        {
            clientes.Add("Pablo",new Persona("Pablo", "Murillo", "684512589", "Espero aprobar"));
            clientesALT.Add("Pablo, Murillo");

            clientes.Add("Pepe",new Persona("Pepe", "Lopez", "621457120", "Comentario1"));
            clientesALT.Add("Pepe, Lopez");

            clientes.Add("Alejandro", new Persona("Alejandro", "Sanchez",
                "605481035", "Comentario2"));
            clientesALT.Add("Alejandro, Sanchez");
        }

        public void cargarCB()
        {
            clientesCB.Items.Clear();
            clientesCB.Items.AddRange(clientesALT.ToArray());
        }

        private void ClientesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String key = clientesCB.SelectedItem.ToString()
                .Substring(0, clientesCB.SelectedItem.ToString().IndexOf(','));

            int keynum = clientes.IndexOfKey(key);

            Persona p = clientes.Values[keynum];

            nombreTB.Text = p.Nombre;
            apellidosTB.Text = p.Apellido;
            telefonoTB.Text = p.Telefono;
            comentariosTB.Text = p.Comentario;

        }
    }
}
