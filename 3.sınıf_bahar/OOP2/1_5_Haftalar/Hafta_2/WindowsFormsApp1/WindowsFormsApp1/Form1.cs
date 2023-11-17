using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String EkrandaYazilan = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "Merhaba İkinci Hafta";
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            txtEkran.BackColor = Color.Red;
            btnYaz.BackColor = Color.Blue;
             
        }

        private void BtnOku_Click(object sender, EventArgs e)
        {
            EkrandaYazilan = txtEkran.Text;
            lbEkran.Text = EkrandaYazilan;


            Color myColor = txtEkran.BackColor;
            lbEkran.Text = myColor.Name;
        }

        private void btnYaz_ML_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "1. Satır" + Environment.NewLine;
            txtEkran.Text = txtEkran.Text+ "2. Satır" + Environment.NewLine;
            txtEkran.Text += "3. Satır" + Environment.NewLine;
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            lbSifre.Text = txtSifre.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            txtSifre.Clear();
        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {
            // lbEvent.Text = txtEvent.Text; 
              
        }

        private void txtEvent_KeyDown(object sender, KeyEventArgs evaaa)
        {
            if (evaaa.KeyCode == Keys.Enter)
            {
                lbEvent.Text = txtEvent.Text;
                txtEvent.Text = "";
            }
        }

        private void txtEvent_Enter(object sender, EventArgs e)
        {
            txtEvent.BackColor = Color.Red;
        }

        private void txtEvent_Leave(object sender, EventArgs e)
        {
            txtEvent.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
