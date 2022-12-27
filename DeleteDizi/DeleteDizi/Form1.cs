using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kelimeler = { "ege", "deniz", "böhöyt", "uzay", "zort" };
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kelimeler.Length; i++)
            {
                listBox1.Items.Add(kelimeler[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
