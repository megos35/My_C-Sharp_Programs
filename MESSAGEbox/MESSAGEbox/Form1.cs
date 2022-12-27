using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSAGEbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("ÇIKMAK İSTEDİĞİNE EMİNMİİSN BROO...","uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
