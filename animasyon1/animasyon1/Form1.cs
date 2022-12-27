using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animasyon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int yon = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        int x = 317;
        int y = 286;
        private void klavyeYakala(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                yon = 1;
            }
            else if (e.KeyCode == Keys.Left)
            {
                yon=2;
            }
            else if (e.KeyCode == Keys.Up)
            {
                yon=3;
            }
            else if (e.KeyCode == Keys.Down)
            {
                yon=4;
            }
            if (yon == 1)
            {
                pictureBox2.Image = Properties.Resources.yan;
            }
            if (yon == 2)
            {
                pictureBox2.Image = Properties.Resources.SAG;
            }
            if (yon == 3)
            {
                pictureBox2.Image = Properties.Resources.UST;
            }
            if (yon == 4)
            {
                pictureBox2.Image = Properties.Resources.ALT;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            if(yon == 1)
            {
                x++;
            }
            if (yon == 2)
            {
                x--;
            }
            if (yon == 3)
            {
                y++;
            }
            if (yon == 4)
            {
                y++;
            }
            pictureBox2.SetBounds(x, y, 76, 72);
        }
    }
}
