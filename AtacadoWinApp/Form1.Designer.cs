using System;
using System.Drawing;
using System.Windows.Forms;
namespace AtacadoWinApp
{



    /// <summary>
    /// No formulário Form1.cs do projeto inclua os seguintes controles:
    ///1 PictureBox - picBola 
    ///1 PictureBox - picRaquete
    ///1 Timer - timer1
    ///Inclua uma imagem no Resources do projeto chamada bola1.jpg;
    /// </summary>
    public partial class Form1 : frmMenu
    {
        public Form1(int valor)
        {
            InitializeComponent();
            if (valor == 0)
            {
                valor = 100;
            }
            else
            {
                picRaquete.Height = valor;
            }
        }

        int velocidade = 10;
        int resultado;
        bool topo, esquerda;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            picBola.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBola.Left > picRaquete.Left)
            {
                timer1.Enabled = false; MessageBox.Show("Você perdeu :  " + resultado.ToString());
                resultado = 0;
            }
            if (picBola.Left + picBola.Width >= picRaquete.Left && picBola.Left + picBola.Width
                <= picRaquete.Left + picRaquete.Width
                && picBola.Top + picBola.Height >= picRaquete.Top && picBola.Top + picBola.Height
                <= picRaquete.Top + picRaquete.Height + picBola.Height)
            {
                esquerda = false;
                resultado += 1;
                this.Text = resultado.ToString();
            }
            if (esquerda)
                picBola.Left += velocidade;
            else
                picBola.Left -= velocidade;
            if (topo)
                picBola.Top += velocidade;
            else
                picBola.Top -= velocidade;
            if (picBola.Top >= this.Height - 50)
                topo = false;
            if (picBola.Top <= 0)
                topo = true;
            if (picBola.Left <= 0)
                esquerda = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picRaquete.Top = e.Y;
        }
    }
}