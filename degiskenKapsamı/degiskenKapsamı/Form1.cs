using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degiskenKapsamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            textBox1.Text =a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a--;
            textBox1.Text = a.ToString();
        }
    }
}
