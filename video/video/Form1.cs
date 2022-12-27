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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace video
{
    public partial class Form1 : Form
    {
        string _yUrl;
        public string VideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_yUrl);
                return yMatch.Success ? yMatch.Groups[1].Value : string.Empty;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "https://www.youtube.com/watch?v=GuZRA5Tz-P4";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _yUrl = textBox1.Text;
            webBrowser1.DocumentText = String.Format("<meta http-equiv='X-UA-Compatible' content='IE=Edge'/><iframe width='100%' height='315'" +
                " src='https://www.youtube.com/embed/{0}?autoplay=1' frameborder='0' allow='accelerometer; autoplay;" +
                " encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>", VideoID);
        }


    }
}
