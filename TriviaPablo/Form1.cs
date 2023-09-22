using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPablo
{
    public partial class Form1 : Form
    {
        private String[] Capitales = new string[] { "Berlín", "Viena", "Bruselas", "Sofía", "Nicosia", "Zagreb", "Copenhague",
                "Bratislava", "Liubliana" , "Madrid", "Tallin", "Helsinki", "París", "Atenas", "Budapest", "Dublín",
                "Roma", "Riga", "Vilna", "Luxemburgo", "La Valeta", "Ámsterdam", "Varsovia", "Lisboa", "Londres",
                "Praga", "Bucarest", "Estocolmo" };
        private String[] Paises = new string[] { "Alemania", "Austria", "Bélgica", "Bulgaria", "Chipre", "Croacia", "Dinamarca",
                "Eslovaquia", "Eslovenia", "España", "Estonia", "Finlandia", "Francia", "Grecia", "Hungría", "Irlanda",
                "Italia", "Letonia", "Lituania", "Luxemburgo", "Malta", "Países Bajos", "Polonia", "Portugal",
                "Reino Unido", "Chéquia", "Rumanía", "Suecia" };
        public Form1()
        {
            InitializeComponent();
            //Random aleatorio = new Random();
            //int numAleatorio = aleatorio.Next(0, Paises.Length);

            //this.Pregunta = Paises.;
        }

        private void MenuOpciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NombreCapitalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem capital = (ToolStripMenuItem)sender;
            ToolStripMenuItem paises = (ToolStripMenuItem)this.nombrePaisesToolStripMenuItem;
            if (paises.Checked)
            {
                capital.Checked = true;
                paises.Checked = false;
                Opcion1.Text = "Pais:";
                Opcion2.Text = "Capital:";
            }
            else
            {
                capital.Checked = true;
            }
        }

        private void NombrePaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem capital = (ToolStripMenuItem)this.nombreCapitalesToolStripMenuItem;
            ToolStripMenuItem paises = (ToolStripMenuItem)sender;
            if (capital.Checked)
            {
                paises.Checked = true;
                capital.Checked = false;
                Opcion1.Text = "Capital:";
                Opcion2.Text = "Pais:";
            }
            else
            {
                paises.Checked = true;
            }
        }

        private void MúltiplesOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem escribir = (ToolStripMenuItem)this.escribirRespuestaToolStripMenuItem;
            ToolStripMenuItem multiples = (ToolStripMenuItem)sender;

            if (escribir.Checked)
            {
                multiples.Checked = true;
                escribir.Checked = false;
                Respuesta1.Visible = true;
                Respuesta1.Enabled = false;
                Respuesta2.Visible = true;
                Respuesta3.Visible = true;
                Respuesta4.Visible = true;
            }
            else
            {
                multiples.Checked = true;
            }
        }

        private void EscribirRespuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem multiples = (ToolStripMenuItem)this.múltiplesOpcionesToolStripMenuItem;
            ToolStripMenuItem escribir = (ToolStripMenuItem)sender;
            if (multiples.Checked)
            {
                escribir.Checked = true;
                multiples.Checked = false;
                Respuesta1.Enabled = true;
                Respuesta2.Visible = false;
                Respuesta3.Visible = false;
                Respuesta4.Visible = false;
            }
            else
            {
                escribir.Checked = true;
            }
        }

        private void Respuesta1_Click(object sender, EventArgs e)
        {

        }

        private void Respuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Respuesta2_Click(object sender, EventArgs e)
        {

        }

        private void Respuesta3_Click(object sender, EventArgs e)
        {

        }

        private void Respuesta4_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
