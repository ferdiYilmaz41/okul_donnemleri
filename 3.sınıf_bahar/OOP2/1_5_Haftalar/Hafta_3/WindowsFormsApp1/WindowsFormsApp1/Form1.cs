using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toplama_Dll;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            dort_islem islem = new dort_islem();
            lbSonuc.Text = islem.toplama(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text)).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            dort_islem islem = new dort_islem();
            lbSonuc.Text = islem.cikarma(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text)).ToString();
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            dort_islem islem = new dort_islem();
            lbSonuc.Text = islem.carpma(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text)).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
