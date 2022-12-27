using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca.Deneme149
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

        int hak = 0;
        private void button1_Click(object sender, EventArgs e)
            {
                string kelime = "BOKSÖR";
                textBox1.Text = textBox1.Text.ToUpper();
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Harf Girin");
                }
                else
                {
                    if (textBox1.Text == kelime[0].ToString())
                    {
                        label1.Text = "B";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[1].ToString())
                        {
                            label2.Text = "O";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[2].ToString())
                            {
                                label3.Text = "K";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[3].ToString())
                                {
                                    label4.Text = "S";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[4].ToString())
                                    {
                                        label5.Text = "Ö";
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
                                                MessageBox.Show("BOKSÖR", "Cevap");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (label1.Text == "B")
                {
                    if (label2.Text == "O")
                    {
                        if (label3.Text == "K")
                        {
                            if (label4.Text == "S")
                            {
                                if (label5.Text == "Ö")
                                {
                                    if (label6.Text == "R")
                                    {
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
        }
    }
}
