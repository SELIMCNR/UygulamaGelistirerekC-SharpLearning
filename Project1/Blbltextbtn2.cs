using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Blbltextbtn2 : Form
    {
        public Blbltextbtn2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAd.Text = textBox1.Text;
            lblSoyad.Text = textBox2.Text;
            lblMeslek.Text = textBox3.Text;
        }

        private void lbltextbtn2_Load(object sender, EventArgs e)
        {

        }
    }
}
