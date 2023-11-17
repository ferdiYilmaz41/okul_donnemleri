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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "Bu bir yazı"; 
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            txtEkran.BackColor = Color.Green;
            txtEkran.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "1. Satır" + Environment.NewLine;
            txtEkran.Text = txtEkran.Text+ "2. Satır" + Environment.NewLine;
            txtEkran.Text += "3. Satır" + Environment.NewLine;
        }

        private void btnBorder_Click(object sender, EventArgs e)
        {
            if (txtEkran.BorderStyle == BorderStyle.Fixed3D)
            { txtEkran.BorderStyle = BorderStyle.None; }
            else
            {
                txtEkran.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void btnPassRead_Click(object sender, EventArgs e)
        {
            lbSifre.Text = txtSifre.Text;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
           // lbSifre.Text = txtSifre.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            txtSifre.Clear();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs key_degisken)
        {
            //if (key_degisken.KeyChar == (char)Keys.Enter)
            //{
            //    lbSifre.Text = txtSifre.Text;
            //}
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbSifre.Text = txtSifre.Text;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            txtSifre.BackColor = Color.Red;
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            txtSifre.BackColor = Color.White;
        }
    }
}
