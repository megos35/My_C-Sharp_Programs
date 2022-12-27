using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YenidenDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] arabalar = { "WolksWagen", "AUDI", "BMW","Dacia", "Renault", "Seat", "Ford", "Mercedes-Benz", "Opel", "Honda", "Toyota", "Skoda", "Chevrolet", "Alfa Romeo", "Cıtroen", "Fıat", "Tofas", "Volvo", "Aston Martin", "TOGG" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                listBox1.Items.Add(arabalar[i]);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(arabalar);
            for (int i = 0; i < arabalar.Length; i++)
            {
                listBox2.Items.Add(arabalar[i]);
            }
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(arabalar);
            for (int i = 0; i < 3; i++)
            {
                listBox3.Items.Add(arabalar[i]);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Array.Sort(arabalar);
            for (int i = 3; i < 4; i++)
            {
                listBox4.Items.Add(arabalar[i]);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Array.Sort(arabalar);
            for (int i = 4; i < 6; i++)
            {
                listBox5.Items.Add(arabalar[i]);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Sort(arabalar);
            for (int i = 6; i < 7; i++)
            {
                listBox6.Items.Add(arabalar[i]);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E harfi araç listede bulunmamaktadır !");
        }
    }
}
