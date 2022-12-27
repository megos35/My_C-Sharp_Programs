using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itemComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();
            label2.Text = comboBox1.Text;
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] meyveler = { "muz", "elma", "ayva" };
            label3.Text = comboBox1.Text;
            comboBox1.DataSource = meyveler;
            // for (int i = 0; i<3;i++)
            //{
            // comboBox1.Items.Add(meyveler[i]);
            //}
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textEkle.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textEkle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
