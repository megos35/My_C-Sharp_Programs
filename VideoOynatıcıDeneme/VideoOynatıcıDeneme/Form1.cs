using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoOynatıcıDeneme
{
    public partial class Form1 : Form
    {
        string _url;
        public string VideoID
        {
            get
            {
                var yMacth = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match;(_url);
                return yMacth.Success ? yMacth[1].Value : String.Empty;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _url = textBox1.Text;
            MessageBox.Show(VideoID);
        }
    }
}
