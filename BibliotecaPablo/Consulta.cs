﻿using System;
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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
            ConsultaTB.Text = Form1.libros[0].ToString();
        }
    }
}
