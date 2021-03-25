using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        int pontos = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            Random sorteio = new Random();
            x = sorteio.Next(1, 14);

            switch (x)
            {
                case 1: 
                    pictureBox1.Image = Properties.Resources.a;
                    pontos += 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    pontos += 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    pontos += 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    pontos += 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    pontos += 5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    pontos += 6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    pontos += 7;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    pontos += 8;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    pontos += 9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    pontos += 10;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.J;
                    pontos += 11;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.Q;
                    pontos += 12;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.K;
                    pontos += 13;
                    break;

            }

            

            if(pontos <= 21)
            {   // JOGANDO
                lbl_Pontos.Text = Convert.ToString(pontos);
                if(pontos == 21)
                {
                    lbl_Pontos.Text = "GANHOU!!!";
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos.Text = "PERDEU!!!! (" + Convert.ToString(pontos) + " pontos)";
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pontos = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            lbl_Pontos.Text = "0";
            pictureBox1.Image = Properties.Resources._0;
        }
    }
}
