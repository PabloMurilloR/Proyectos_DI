using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ArkanoidPablo
{
    public partial class Arkanoid : Form
    {
        int puntuacion;
        int vidas;
        int posX;
        private int ejeX;
        private int ejeY;
        private bool retomar = true;
        private int tecla;
        public List<PictureBox> bloques;
        private Random random = new Random();

        public Arkanoid()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            vida1.Visible = true;
            vida2.Visible = true;
            vida3.Visible = true;
            vidas = 4;
            bloques = new List<PictureBox>();
            CrearPictureBoxes();
        }

        private void Arkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && retomar)
            {
                retomar = false;
                ejeY = 5;
                ejeX = 5;
                timerPelota.Start();
                IniciarMovimiento_Click();

            }
            else if (e.KeyCode == Keys.Right)
            {
                tecla = 1;
                timerBarra.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tecla = -1;
                timerBarra.Start();
            }
        }

        private void IniciarMovimiento_Click()
        {
            pelota.Location = new Point(pelota.Location.X, pelota.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timerPelota.Interval = 10;

            posX = pelota.Location.X;
            int posY = pelota.Location.Y;

            posX += ejeX;

            if (posX + pelota.Width > this.Width || posX < 0)
            {
                ejeX = -ejeX;
            }
            else if (posY >= 450)
            {
                ejeY = 0;
                ejeX = 0;
                reinicioPelota();
            }
            else if (posY + pelota.Width > this.Width || posY < 0)
            {
                ejeY = -ejeY;
            }
            pelota.Invalidate();
            pelota.Location = new Point(posX, pelota.Location.Y - ejeY);

            DetectarColisionConBarra();
            DetectarColisionConBloques();

        }

        public void reinicioPelota()
        {
            vidas--;

            if (vidas == 3)
            {
                vida1.Visible = false;
            }
            else if (vidas == 2)
            {
                vida2.Visible = false;
            }
            else if (vidas == 1)
            {
                vida3.Visible = false;
            }
            else if (vidas == 0)
            {
                DialogResult resultado = 
                    MessageBox.Show("¿Desea reiniciar?", "Has perdido",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    foreach (PictureBox bloque in bloques)
                    {
                        Controls.Remove(bloque);
                    }
                    iniciarJuego();
                }
                else
                {
                    Dispose();
                }
            }
            posX = barra1.Location.X + (barra1.Width/2) - 10; 
            timerPelota.Stop();
            pelota.Invalidate();
            pelota.Location = new Point(posX, 397);
            retomar = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timerBarra.Interval = 10;
            barra1.Invalidate();

            switch (tecla)
            {
                case -1:
                    if (barra1.Location.X > 0)
                    {
                        if (ejeX == 0)
                        {
                            pelota.Location = new Point(pelota.Location.X - 5, pelota.Location.Y);
                        }
                        barra1.Location = new Point(barra1.Location.X - 5, barra1.Location.Y);
                    }
                    break;
                case 1:
                    if (barra1.Location.X + 100 < this.Width )
                    {
                        if (ejeX == 0)
                        {
                            pelota.Location = new Point(pelota.Location.X + 5, pelota.Location.Y);
                        }
                        barra1.Location = new Point(barra1.Location.X + 5, barra1.Location.Y);
                    }
                    
                    break;
            }
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
            ejeY = -ejeY;
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
                    PictureBox bloqueNuevo = new PictureBox();

                    int numeroRandom = random.Next(0, bloquesImg.Images.Count);

                    bloqueNuevo.Image = bloquesImg.Images[numeroRandom];

                    bloqueNuevo.Size = new Size(82, 32);
                    bloqueNuevo.SizeMode = PictureBoxSizeMode.StretchImage;

                    bloqueNuevo.Location = new Point(posicionX, posicionY);
                    posicionX += 88;

                    Controls.Add(bloqueNuevo);
                    bloqueNuevo.Visible = true;
                    bloques.Add(bloqueNuevo);

                    cajasPorFila++;
                }
                posicionY += 38;
            }
        }

        private void DetectarColisionConBloques()
        {
            List<PictureBox> bloquesAux = new List<PictureBox>();

            foreach (PictureBox bloque in bloques)
            {
                if (pelota.Bounds.IntersectsWith(bloque.Bounds))
                {
                    bloquesAux.Add(bloque);
                    ejeY = -ejeY;
                }
            }

            foreach (PictureBox bloque in bloquesAux)
            {
                bloques.Remove(bloque);
                Controls.Remove(bloque);
            }
        }

        private void Arkanoid_KeyUp(object sender, KeyEventArgs e)
        {
            tecla = 0;
        }
    }
}
