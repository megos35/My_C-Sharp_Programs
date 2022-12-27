using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace günBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }
        void gunhesabı()
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            switch (sayi)
            {
                case 1:
                    {
                        label1.Text = "Pazartesi";
                    }
                    break;
                case 2:
                    {
                        label1.Text = "salı";
                    }
                    break;
                case 3:
                    {
                        label1.Text = "çarsamba";
                    }
                    break;
                case 4:
                    {
                        label1.Text = "persembe";
                    }
                    break;
                case 5:
                    {
                        label1.Text = "cuma";
                    }
                    break;
                case 6:
                    {
                        label1.Text = "cumartesi";
                    }
                    break;
                case 7:
                    {
                        label1.Text = "pazar";
                    }
                    break;
                default:
                    {
                        MessageBox.Show("lütfen 7 günden fazla girmeyiniz!");
                    }
                    break;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunhesabı();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gunhesabı();
        }
    }
}
