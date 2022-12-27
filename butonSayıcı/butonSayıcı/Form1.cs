using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butonSayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s = 0;
        int b = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = s.ToString();
            s++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b++;
            if(b==10)
            {
                button2.Visible= false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible= false;
            this.textBox1.Visible= true;
            this.button2.Visible= true;
            this.timer1.Enabled= true;
            
           
        }
        int higS = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            int higS = s / 10;
            textBox2.Text= higS.ToString();
              

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("C:\\Users\\megod\\Desktop\\skor\\skor.txt.txt",FileMode.Open,FileAccess.Read);//dosyayı buluyor ve okuma modunda açıyor
            StreamReader sr = new StreamReader(fs);
            String ilksatir =sr.ReadLine();//dosyadan tek satır okur 
            higS = Convert.ToInt32(ilksatir);
            sr.Close();
            fs.Close();
            label3.Text = ilksatir;

        }
    }
}
