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
    public partial class Albltextbtn1 : Form
    {
        public Albltextbtn1()
        {
            InitializeComponent();
        }

        private void tıklandı(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Selim Çınar";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblAd.Text = "Yusuf Can";
            lblSoyad.Text = "Çınar";
            lblMeslek.Text = "Uzay mühendisi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yazılım Mühendisi";
            label4.Text = textBox1.Text;
        }

        private void lbltextbtn1_Load(object sender, EventArgs e)
        {

        }
    }
}
