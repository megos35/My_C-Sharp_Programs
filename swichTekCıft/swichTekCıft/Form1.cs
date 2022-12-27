using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swichTekCıft
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
            int kalan = sayi % 2;
            switch (kalan)
            {
                case 0:
                    {
                        CIFT.Items.Add(textBox1.Text);
                    }
                    break;
                case 1:
                    {
                        TEK.Items.Add(textBox1.Text);
                    }
                    break;
            }

                
              
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
