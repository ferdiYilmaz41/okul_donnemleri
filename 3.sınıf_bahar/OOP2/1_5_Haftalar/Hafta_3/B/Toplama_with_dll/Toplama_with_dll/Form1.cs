using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dort_Islem;

namespace Toplama_with_dll
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

        private void button1_Click(object sender, EventArgs e)
        {
           Islem myIslem = new Islem();
            int sonuc = myIslem.toplama(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text));
            lbsonuc.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Islem myIslem = new Islem();
            int sonuc = myIslem.cikarma(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text));
            lbsonuc.Text = sonuc.ToString();
        }

        private void btnToplama_2_Click(object sender, EventArgs e)
        {
            Islem myIslem = new Islem();
            lbsonuc.Text = myIslem.toplama_ret_str(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text));

        }
    }
}
