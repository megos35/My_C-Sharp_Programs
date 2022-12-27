using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangmanV3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Content : System.Web.UI.Control
        {

        }
        string[] adam = { "___\n", " |\n", " O\n", " /", "|", "\\\n", " /", " \\\n", "___" };
        string[] kelimeler = { "anahtarlık", "çekmece", "araba", "bilgisayar", "terzi", "terzi", "istavrit", "bulmaca" };
        string secilenKelime;
        char[] yertutucu;
        int tahminSayisi = 0;
        private void btnUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, kelimeler.Length - 1);
            secilenKelime = kelimeler[index];
            yertutucu = new char[secilenKelime.Length];
            tahminSayisi = 0;
            lbAdam.Content = "";
            lbTahmin.Content = "";
            for (int i = 0; i < yertutucu.Length; i++)  //yazilimbilisim.net
            {
                yertutucu[i] = '-';
                lbTahmin.Content += yertutucu[i].ToString();
            }
        }

        private void btnKelime_Click(object sender, EventArgs e)
        {
            if (txtHarf.Text.Length == 1) //yazilimbilisim.net
            {
                bool durum = false;
                char harf = Convert.ToChar(txtHarf.Text);
                for (int i = 0; i < secilenKelime.Length; i++) //yazilimbilisim.net
                {
                    if (secilenKelime[i] == harf)
                    {
                        durum = true;
                        yertutucu[i] = harf;
                    }
                }
                lbTahmin.Content = "";
                for (int i = 0; i < yertutucu.Length; i++)  //yazilimbilisim.net
                {
                    lbTahmin.Content += yertutucu[i].ToString();
                }

                int kalanHarf = 0;
                for (int i = 0; i < yertutucu.Length; i++)
                {
                    if (yertutucu[i] == '-') kalanHarf++;
                }

                if (kalanHarf > 0)
                {
                    //adam dizisindeki nesne sayısı
                    if (!durum && tahminSayisi < 9)
                    {
                        lbAdam.Content += adam[tahminSayisi];
                        tahminSayisi++;
                    }

                    if (tahminSayisi == 9)
                    {
                        MessageBox.Show("Hakkınız Bitti");
                        lbTahmin.Content = secilenKelime;
                    }
                }
                else
                {
                    MessageBox.Show("Tebrikler Kazandınız");
                }


            }
            else
            {
                MessageBox.Show("Lüften tek harf girin");  //yazilimbilisim.net
            }
        }
    }
}
