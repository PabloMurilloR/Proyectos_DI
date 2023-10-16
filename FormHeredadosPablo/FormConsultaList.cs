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

namespace FormHeredadosPablo
{
    public partial class FormConsultaList : FormPrincipal
    {
        SortedList usuarios;
        public FormConsultaList(SortedList usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;
        }
    }
}
