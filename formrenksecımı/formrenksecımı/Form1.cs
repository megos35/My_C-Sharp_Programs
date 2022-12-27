using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formrenksecımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        int red = 0, green = 0, blue = 0;

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = trackBar3.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = trackBar2.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
