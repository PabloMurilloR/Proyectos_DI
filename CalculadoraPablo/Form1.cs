using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPablo
{
    public partial class Calculadora : Form
    {
        String texto = "";
        double num1;
        double num2;
        double memoria = 0;
        string operador = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void MResultado_TextChanged(object sender, EventArgs e)
        {

        }

        #region Botones

        #region Numeros
        private void BtonNumeros(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Name.Equals("Cero"))
            {
                MResultado.Text += 0;
                texto += "0";
            } else if (bt.Name.Equals("Uno"))
            {
                MResultado.Text += 1;
                texto += "1";
            } else if (bt.Name.Equals("Dos"))
            {
                MResultado.Text += 2;
                texto += "2";
            } else if (bt.Name.Equals("Tres"))
            {
                MResultado.Text += 3;
                texto += "3";
            } else if (bt.Name.Equals("Cuatro"))
            {
                MResultado.Text += 4;
                texto += "4";
            } else if (bt.Name.Equals("Cinco"))
            {
                MResultado.Text += 5;
                texto += "5";
            } else if (bt.Name.Equals("Seis"))
            {
                MResultado.Text += 6;
                texto += "6";
            } else if (bt.Name.Equals("Siete"))
            {
                MResultado.Text += 7;
                texto += "7";
            } else if (bt.Name.Equals("Ocho"))
            {
                MResultado.Text += 8;
                texto += "8";
            } else if (bt.Name.Equals("Nueve"))
            {
                MResultado.Text += 9;
                texto += "9";
            }
        }
        #endregion

        #region Borrar
        private void CE_Click(object sender, EventArgs e)
        {
            if (texto.Substring(0, texto.Length - 1).Length > 0)
            {
                texto = texto.Substring(0, texto.Length - 1);
                MResultado.Text = texto;
            } else
            {
                MResultado.Text = "";
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            MResultado.Text = "";
            texto = "";
        }
        #endregion


        #region Operaciones
        private void Division1_Click(object sender, EventArgs e)
        {
            if (texto.Equals("0"))
            {
                MResultado.Text = "";
                MessageBox.Show("La division entre 0 no es válida");
            } else
            {
                double resultado = 1 / double.Parse(texto);
                MResultado.Text = resultado.ToString();
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            MResultado.Text = "";
            num1 = double.Parse(texto);
            texto = "";
            operador = "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            MResultado.Text = "";
            num1 = double.Parse(texto);
            texto = "";
            operador = "/";
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            MResultado.Text = "";
            num1 = double.Parse(texto);
            texto = "";
            operador = "+";
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            MResultado.Text = "";
            num1 = double.Parse(texto);
            texto = "";
            operador = "-";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(texto);
            if (operador.Equals("/"))
            {
                if(num2 == 0)
                {
                    MResultado.Text = "";
                    MessageBox.Show("La division entre 0 no es válida");
                } else
                {
                    MResultado.Text =  (num1 / num2).ToString();
                }
            } else if (operador.Equals("*"))
            {
                MResultado.Text = (num1 * num2).ToString();
            } else if (operador.Equals("+"))
            {
                MResultado.Text = (num1 + num2).ToString();
            } else if (operador.Equals("-"))
            {
                MResultado.Text = (num1 - num2).ToString();
            }

        }
        #endregion

        #region Memoria
        private void MC_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            MResultado.Text = memoria.ToString();
        }
        private void MS_Click(object sender, EventArgs e)
        {
            memoria = double.Parse(texto);
        }

        private void MMas_Click(object sender, EventArgs e)
        {
            memoria += double.Parse(texto);
        }
        #endregion

        #endregion

    }
}