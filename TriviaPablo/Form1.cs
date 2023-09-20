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
            Random aleatorio = new Random();
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
            } else
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
            }
            else
            {
                escribir.Checked = true;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
