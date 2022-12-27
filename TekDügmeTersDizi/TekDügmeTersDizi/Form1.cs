using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekDügmeTersDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] arabalar = { "WolksWagen", "AUDI", "BMW", "Renault", "Seat", "Ford", "Mercedes-Benz", "Opel", "Honda", "Toyota", "Skoda", "Chevrolet", "Alfa Romeo", "Cıtroen", "Fıat", "Tofas", "Volvo" };
        bool tersmi = false;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (tersmi == true)
            {
                for (int i = 0; i < arabalar.Length; i++)
                {
                    listBox1.Items.Add(arabalar[i]);
                }
                tersmi = false;

            }
            else
            {
                for (int i = arabalar.Length - 1; i >= 0; i--)
                {
                    listBox1.Items.Add(arabalar[i]);
                }
                tersmi= true;
            }
        }
    }
}
