using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToFly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] hamur = { "ince h.", "orta h.", "kalın h." };
        int[] hamurFiyat = { 10, 15, 20 };
        String[] pızza = { "karışık", "bol malzemeli", "sucuklu", "peynirli", "vejeteryan" };
        int[] pizzaFiyat = { 20, 22, 20, 17, 20 };
        String[] ıcecek = { "cola", "ayran", "su", "sprıte", "fanta", "şalgam" };
        int[] icecekFiyat = { 10, 6, 0, 10, 9, 5 };
        private void Form1_Load(object sender, EventArgs e)
        {
           
            comboBox2.DataSource = hamur;
            
            comboBox1.DataSource = pızza;
           
            comboBox3.DataSource = ıcecek;
            String[] portlar=SerialPort.GetPortNames();
            comboBox4.DataSource = portlar;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Text = comboBox2.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox3.Text);
            int toplam = hamurFiyat[comboBox2.SelectedIndex] + pizzaFiyat[comboBox1.SelectedIndex] + icecekFiyat[comboBox3.SelectedIndex];
            textBox2.Text = toplam.ToString();
            if(radioButton1.Checked)
            {
                toplam -= 10;
            };
            
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
