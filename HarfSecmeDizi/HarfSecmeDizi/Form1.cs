using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarfSecmeDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] arabalar = { "WolksWagen", "AUDI", "BMW", "Renault", "Seat", "Ford", "Mercedes-Benz", "Opel", "Honda", "Toyota", "Skoda", "Chevrolet", "Alfa Romeo", "Cıtroen", "Fıat", "Tofas", "Volvo" };
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0,1);
                if(ilkHarf == "a" || ilkHarf == "A")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "b" || ilkHarf == "B")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "g" || ilkHarf == "G")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "f" || ilkHarf == "F")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "e" || ilkHarf == "E")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "d" || ilkHarf == "D")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "c" || ilkHarf == "C")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                String ilkHarf = arabalar[i].Substring(0, 1);
                if (ilkHarf == "W" || ilkHarf == "w")
                {
                    listBox1.Items.Add(arabalar[i]);
                }
            }
        }
    }
}
