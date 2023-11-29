using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAdicionalesPablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FechaNacTB1.ValidatingType = typeof(DateTime);
            FechaNacTB1.TypeValidationCompleted += FechaNac_Validacion;

            NIFTB1.ValidatingType = typeof(DateTime);
            NIFTB1.TypeValidationCompleted += NIF_Validacion;
        }

        public void FechaNac_Validacion(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                errorProvider1.SetError(FechaNacTB1, "Ingresa una fecha correcta");
            }
            else
            {
                errorProvider1.SetError(FechaNacTB1, "");
            }
        }

        public void NIF_Validacion(object sender, TypeValidationEventArgs e)
        {
            string dni = NIFTB1.Text;
            if (!ValidarDNI(dni))
            {
                errorProvider1.SetError(NIFTB1, "DNI no valido");
            }
            else
            {
                errorProvider1.SetError(NIFTB1, "");
            }
        }

        static bool ValidarDNI(string dni)
        {
            string patron = @"^\d{8}[A-Z]$";

            return Regex.IsMatch(dni, patron);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.trekbikes.com/es/es/");
            linkLabel1.LinkVisited = true;
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 100;

            RealizarTareaAsync();
        }

        private async Task RealizarTareaAsync()
        {
            await Task.Delay(600);
            MessageBox.Show("Datos guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar2.Value = 0;
        }
    }
}
