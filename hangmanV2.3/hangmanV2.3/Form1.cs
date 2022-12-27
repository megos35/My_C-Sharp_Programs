using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangmanV2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = "VAMPİR";
            textBox1.Text = textBox1.Text.ToUpper();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Harf Girin");
            }
            if (textBox1.Text == "VAMPİR".ToString())
            {
                MessageBox.Show("TEBRİKLER TAM DOĞRU BİLDİNİZ");
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "V";
                }
                else
                {
                    if (textBox1.Text == kelime[1].ToString())
                    {
                        label2.Text = "A";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[2].ToString())
                        {
                            label3.Text = "M";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[3].ToString())
                            {
                                label4.Text = "P";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "İ";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[5].ToString())
                                    {
                                        label6.Text = "R";
                                    }
                                    else
                                    {
                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox6.Visible = false;
                                            MessageBox.Show("KALAN HAK : 5", "Maalesef Yazdığınız Harf Bulunmamakta");
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox4.Visible = false;
                                            MessageBox.Show("KALAN HAK :4", "Maalesef Yazdığınız Harf Bulunmamakta");
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox2.Visible = false;
                                            MessageBox.Show("KALAN HAK : 3", "Maalesef Yazdığınız Harf Bulunmamakta");
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox3.Visible = false;
                                            MessageBox.Show("KALAN HAK : 2", "Maalesef Yazdığınız Harf Bulunmamakta");
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox5.Visible = false;
                                            MessageBox.Show("KALAN HAK : 1", "Maalesef Yazdığınız Harf Bulunmamakta");
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.Visible = false;
                                            button1.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("KALAN HAK:0!!", "Oyunu Kaybettiniz!");
                                            MessageBox.Show("VAMPİR", "Cevap");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (label1.Text == "V")
            {
                textBox1.Clear();
                if (label2.Text == "A")
                {
                    textBox1.Clear();
                    if (label3.Text == "M")
                    {
                        textBox1.Clear();
                        if (label4.Text == "P")
                        {
                            textBox1.Clear();
                            if (label5.Text == "İ")
                            {
                                textBox1.Clear();
                                if (label6.Text == "R")
                                {
                                    textBox1.Clear();
                                    button1.Enabled = false;
                                    textBox1.Enabled = false;
                                    MessageBox.Show("Tebrikler Oyunu Kazandınız!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Bulunacak_Kelime()
            {
                Random rand = new Random();

                string[] kelimeler = new string[10];
                kelimeler[0] = "VAMPİR";
                kelimeler[1] = "Aşk";
                kelimeler[2] = "Araba";
                kelimeler[3] = "İhanet";
                kelimeler[4] = "Emek";
                kelimeler[5] = "Bilgisayar";
                kelimeler[6] = "Yazılım";
                kelimeler[7] = "Arkadaşlık";
                kelimeler[8] = "Dostluk";
                kelimeler[9] = "Öğretmen";
                int random_sayi = rand.Next(0, kelimeler.Length);
                return kelimeler[random_sayi];
            }
        }
    }
    
}
