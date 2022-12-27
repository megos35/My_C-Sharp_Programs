using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{

    public partial class Form1 : Form
    {
        String[] kelimeler = { "BEN", "ARABA", "İNSAN", "BİLGİSAYAR", "YAZILIM", "MONİTÖR","BÖHÖYT","KİTAP","ÜÇGEN","OTOBÜS","MUVAFFAKİYETSİZ","BANKA","ÖLÜMSÜZLEŞTİREBİLMEK","RADYOAKLİFLEŞTİRME","UÇAK","JAPONYA", };
        String secim;
        String kelime;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            secim = kelimeler[rnd.Next(1, 16)];
            label2.Text = secim;
            kelime = "";
            for(int i = 0; i < secim.Length; i++)
            {
                kelime += " _ ";
            }
            label1.Text = kelime;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
