using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megeGeriDonusüm
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
        void hesapla()
        {
            int baslangıc = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int artıs = Convert.ToInt32(textBox3.Text);

            for (int i = baslangıc; i < bitis; i+=artıs)
            {
                listBox1.Items.Add(i);
            }
                

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangıc = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int artıs = Convert.ToInt32(textBox3.Text);

            for (int i = baslangıc; i < bitis; i += artıs)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
