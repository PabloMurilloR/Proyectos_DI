﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace ArkanoidPablo
{
    public partial class Arkanoid : Form
    {
        int posX;
        private int velocidad;
        private int angulacion;
        private bool retomar = true;
        private int tecla;
        public List<PictureBox> bloques;

        public Arkanoid()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            bloques = new List<PictureBox>();
            CrearPictureBoxes();
        }

        private void Arkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && retomar)
            {
                retomar = false;
                angulacion = 5;
                velocidad = 5;
                timer1.Start();
                IniciarMovimiento_Click();

            }
            else if (e.KeyCode == Keys.Right)
            {
                timer2.Start();
                tecla = 1;
            }
            else if (e.KeyCode == Keys.Left)
            {
                timer2.Start();
                tecla = 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IniciarMovimiento_Click()
        {
            pelota.Location = new Point(pelota.Location.X, pelota.Location.Y);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 10;

            posX = pelota.Location.X;
            int posY = pelota.Location.Y;

            posX += velocidad;

            if (posX + pelota.Width > this.Width || posX < 0)
            {
                velocidad = -velocidad;
            }
            else if (posY >= 450)
            {
                angulacion = 0;
                velocidad = 0;
                reinicio();
            }
            else if (posY + pelota.Width > this.Width || posY < 0)
            {
                angulacion = -angulacion;
            }
            pelota.Invalidate();
            pelota.Location = new Point(posX, pelota.Location.Y - angulacion);

            DetectarColisionConBarra();
        }

        public void reinicio()
        {
            posX = barra1.Location.X + (barra1.Width/2) - 10; 
            timer1.Stop();
            pelota.Invalidate();
            pelota.Location = new Point(posX, 397);
            retomar = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 10;
            barra1.Invalidate();

            switch (tecla)
            {
                case 1:
                    if (barra1.Location.X + 97 < this.Width )
                    {
                        if (velocidad == 0)
                        {
                            pelota.Location = new Point(pelota.Location.X + 20, pelota.Location.Y);
                        }
                        barra1.Location = new Point(barra1.Location.X + 20, barra1.Location.Y);
                    }
                    
                    break;

                case 2:
                    if (barra1.Location.X > 0)
                    {
                        if (velocidad == 0)
                        {
                            pelota.Location = new Point(pelota.Location.X - 20, pelota.Location.Y);
                        }
                        barra1.Location = new Point(barra1.Location.X - 20, barra1.Location.Y);
                    }
                    break;
            }
            
            timer2.Stop();
        }

        private void DetectarColisionConBarra()
        {
            if (pelota.Bounds.IntersectsWith(barra1.Bounds))
            {
                CambiarDireccionPelota();
            }
        }
        private void CambiarDireccionPelota()
        {
            angulacion = -angulacion;
        }

        private void CrearPictureBoxes()
        {
            int filas = 4;
            int posicionY = 12;

            for (int i = 0; i < filas; i++)
            {
                int posicionX = 12;
                int cajasPorFila = 1;

                while (cajasPorFila <= 5)
                {
                    PictureBox cajaNueva = new PictureBox();
                    cajaNueva.Size = new Size(82, 32);
                    cajaNueva.Image = Properties.Resources.bAzulC;
                    cajaNueva.SizeMode = PictureBoxSizeMode.StretchImage;

                    cajaNueva.Location = new Point(posicionX, posicionY);
                    posicionX += 88;
                    Controls.Add(cajaNueva);
                    cajaNueva.Visible = true;
                    bloques.Add(cajaNueva);
                    cajasPorFila++;
                }
                posicionY += 38;
            }
        }
    }
}
