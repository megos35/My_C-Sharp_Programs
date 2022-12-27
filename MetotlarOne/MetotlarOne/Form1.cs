using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotlarOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void selamla(String İSİM,int defa)
        {
            for (int i = 0; i < defa; i++)
            {
                MessageBox.Show("selaam" + İSİM);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selamla (" EGE ",3);
            
        }
    }
}
