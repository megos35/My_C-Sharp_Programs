using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgeleSayıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int[] dizi1 = new int[10];
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rng.Next(1, 101);
            }
            Convert.ToInt32(dizi1);
            listBox1.Items.Add(dizi1);

            int[] dizi2 = new int[10];
            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i] = rng.Next(1, 101);
            }
            Convert.ToInt32(dizi1);
            listBox2.Items.Add(dizi2);
        }
    }
}
