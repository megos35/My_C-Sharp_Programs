using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabaAnimasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sag = 200;
        int y = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sag-=7;
            pictureBox1.SetBounds(sag, 110, 278, 105);
            if (sag <= -238) { sag = 786; }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.timer2.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sag+=2;
            pictureBox1.SetBounds(sag, 110, 278, 105);
            if (sag >= 786) { sag = -238; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int paraX=0;
        int y= -50;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer3.Enabled = false;
        }
    }
}
