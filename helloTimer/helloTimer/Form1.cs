using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(button1.Visible == true)
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Visible=true;
            timer2.Enabled = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }
        int i = 0;
        int yon = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (yon == 0) 
            {
                i = i + 5;
            }
            else
            {
                i = i - 5;
            }
            if(i>500)
            {
                yon= 1;
            }
            if (i<0)
            {
                yon = 0;
            }
            button2.Location = new System.Drawing.Point(i, i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            pictureBox1.Visible = false;
        }
    }
}
