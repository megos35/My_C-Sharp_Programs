using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toplama_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textSayı1.Text);
            int sayı2 = Convert.ToInt32(textSayı2.Text);
            int toplam = sayı1 + sayı2;
            Sonuc.Text = toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textSayı1.Text);
            int sayı2 = Convert.ToInt32(textSayı2.Text);
            if(sayı1<sayı2)
            {
                int a = sayı2 - sayı1;
                Sonuc.Text = a.ToString();
            }
            else
            {
                int b = sayı2 - sayı1;
                Sonuc.Text = b.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textSayı1.Text);
            int sayı2 = Convert.ToInt32(textSayı2.Text);
           
                int c = sayı1 / sayı2;
                Sonuc.Text = c.ToString();
            if(sayı2 == 0 )
            {
                //Sadece mesaj gösterimi.
                MessageBox.Show("HATA");

               
            }
          
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textSayı1.Text);
            int sayı2 = Convert.ToInt32(textSayı2.Text);
            int toplam = sayı1 * sayı2;
            Sonuc.Text = toplam.ToString();
        }
    }
}
