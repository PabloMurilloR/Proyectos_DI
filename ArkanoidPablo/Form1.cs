using System;
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
        private int ejeX;
        private int ejeY;
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

        /*public void reinicioJuego()
        {
            pelota.Location = new Point(ejeX, ejeY);

            foreach (PictureBox bloque in bloques)
            {
                bloque.Location = ObtenerPosicionInicialBloque();
                Controls.Add(bloque);
            }
        }*/

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
                timerBarra.Start();
                tecla = 1;
            }
            else if (e.KeyCode == Keys.Left)
            {
                timerBarra.Start();
                tecla = 2;
            }
            else if (e.KeyCode == Keys.R)
            {
                iniciarJuego();
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
                case 1:
                    if (barra1.Location.X + 97 < this.Width )
                    {
                        if (ejeX == 0)
                        {
                            pelota.Location = new Point(pelota.Location.X + 20, pelota.Location.Y);
                        }
                        barra1.Location = new Point(barra1.Location.X + 20, barra1.Location.Y);
                    }
                    
                    break;

                case 2:
                    if (barra1.Location.X > 0)
                    {
                        if (ejeX == 0)
                        {
                            pelota.Location = new Point(pelota.Location.X - 20, pelota.Location.Y);
                        }
                        barra1.Location = new Point(barra1.Location.X - 20, barra1.Location.Y);
                    }
                    break;
            }
            
            timerBarra.Stop();
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

        private void DetectarColisionConBloques()
        {
            foreach (PictureBox bloque in bloques)
            {
                if (pelota.Bounds.IntersectsWith(bloque.Bounds))
                {
                    bloques.Remove(bloque);
                    Controls.Remove(bloque);
                    ejeY = -ejeY;
                    break;
                }
            }
        }
    }
}
