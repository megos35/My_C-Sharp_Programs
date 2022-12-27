using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formOlaylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "SGK";
            this.BackColor = Color.Azure;
            

            button1.Text = "Kapat";
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Azure;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
