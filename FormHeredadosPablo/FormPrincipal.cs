using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormHeredadosPablo
{
    public partial class FormPrincipal : Form
    {
        public static SortedList<string, Usuario> usuarios = new SortedList<string, Usuario>();
        public static bool VentanaAlta = false;
        public static bool VentanaConsultaList = false;
        public static bool VentanaConsultaTree = false;

        public FormPrincipal()
        {

            InitializeComponent();
            
        }

        private void OpcionMS(object sender, EventArgs e)
        {
            string opcion = sender.ToString();
            switch (opcion)
            {
                case "Alta":
                    MostrarFormulario(new FormAlta());
                    break;
                case "Consulta lista":
                    MostrarFormulario(new FormConsultaList());
                    break;
                case "Consulta tree":
                    MostrarFormulario(new FormConsultaTree());
                    break;
                case "Salir":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void MostrarFormulario(Form form)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == form.GetType())
                {
                    f.Show();
                    this.Hide();
                    return;
                }
            }

            form.Show();
            this.Hide();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
