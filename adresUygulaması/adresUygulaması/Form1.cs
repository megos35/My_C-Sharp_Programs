using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adresUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] KİSİ = { "MEHMET ", " BERAT", "EMİR "," SEZAİ ", };
        String[] soyad = { "MEHMET COŞĞUN ", " ZEYNEL BERAT ÇÖRDÜK", "EMİR BÜYÜKYILDIRIM", "EMİR SEZAİ ÖLMEZ", };
        int[] YAS = { 16, 16, 16,16,499 };
        String[] sehir = { "bornova", "buca", "konak","bayraklı","CENNET" };
        String[] tel = { "543 246 34 39", "551 123 45 89", "546 727 70 67","551 039 34 78", };
        String[] okul = { "Mazhar Zorlu MTAL", "Mazhar Zorlu MTAL", "Mazhar Zorlu MTAL", "Mazhar Zorlu MTAL", };

        ArrayList isimler = new ArrayList();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] KİSİ = { "MEHMET", "BERAT", "EMİR","SEZAİ",};
            label1.Text = comboBox1.Text;
            comboBox1.DataSource = KİSİ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            listBox1.Items.Add(soyad[comboBox1.SelectedIndex]);
            listBox1.Items.Add(YAS[comboBox1.SelectedIndex]);
            listBox1.Items.Add(sehir[comboBox1.SelectedIndex]);
            listBox1.Items.Add(tel[comboBox1.SelectedIndex]);
            listBox1.Items.Add(okul[comboBox1.SelectedIndex]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = isimler;
        }
    }
}
