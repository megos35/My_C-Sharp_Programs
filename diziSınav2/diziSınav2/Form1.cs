using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziSınav2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] meyveler = new string[5];
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac < 5)
            {
               meyveler[sayac] = textBox1.Text;
                sayac++;
            }
            else
            {
                MessageBox.Show("dizi sınırı aşıldı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayac; i++)
            {
                listBox1.Items.Add(meyveler[i]);
            }
        }
    }
}
