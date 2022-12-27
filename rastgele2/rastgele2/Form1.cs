using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            Random rng = new Random();
            int[] dizi1 = new int[10];
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rng.Next(1, 101);
                listBox1.Items.Add(dizi1[i]);
            }
            
            int[] dizi2 = new int[10];
            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i] = rng.Next(1, 101);
                listBox2.Items.Add(dizi2[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (dizi1[i] == dizi2[j])
                    {
                        listBox3.Items.Add(dizi1[i]);
                    }
                }
            }


        }
    }
}
