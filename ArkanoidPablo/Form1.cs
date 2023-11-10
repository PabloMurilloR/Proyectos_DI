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
        private int velocidad = 30; // Velocidad del movimiento
        private int angulacion = 10;

        public Arkanoid()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IniciarMovimiento_Click(object sender, EventArgs e)
        {
            pelota.Location = new Point(pelota.Location.X, pelota.Location.Y);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                IniciarMovimiento_Click(sender, e);
                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            posX = pelota.Location.X;
            int posY = pelota.Location.Y;
            posX += velocidad;

            if (posX + pelota.Width > this.Width || posX < 0)
            {
                // Cambia la dirección al llegar a un límite
                velocidad = -velocidad;
            }
            else if (posY >= 450)
            {
                angulacion = 0;
                velocidad = 0;
                Console.WriteLine("Abajo");
                reinicio();
            }
            else if (posY + pelota.Width > this.Width || posY < 0)
            {
                angulacion = -angulacion;
            }
            pelota.Invalidate();
            // Actualiza la posición del PictureBox
            pelota.Location = new Point(posX, pelota.Location.Y - angulacion);

        }

        public void reinicio()
        {
            posX = barra1.Location.X + (barra1.Width/2) - 10; 
            timer1.Stop();
            pelota.Invalidate();
            pelota.Location = new Point(posX, 398);
           // this.KeyPreview = true;
            Console.WriteLine("Reinicio");
        }
    }
}
