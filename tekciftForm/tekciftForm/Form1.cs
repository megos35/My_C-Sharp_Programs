using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tekciftForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi = Convert.ToInt32(textBox1.Text);
            
            if (sayi % 2 == 0)
            {
                CIFT.Items.Add(textBox1.Text);
            }
            else
            {
                TEK.Items.Add(textBox1.Text);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
