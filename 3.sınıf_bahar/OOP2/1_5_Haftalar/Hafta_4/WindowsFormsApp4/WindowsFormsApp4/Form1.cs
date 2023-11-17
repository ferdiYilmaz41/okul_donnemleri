using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cmbGunler.SelectedIndex = 1;
           // cmbGunler.Text = "Salı";
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            cmbGunler.SelectedIndex = 1;
            // db bağlan getir

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkle.Text.Length > 0) {
            cmbEkle.Items.Add(txtEkle.Text);
            txtEkle.Text = "";
            }
        }

        private void cmbEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seçili Eleman " + cmbEkle.Text);
        }

        private void cmbGunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seçili Eleman " + cmbGunler.Text);
            MessageBox.Show("Seçili İndeks " + cmbGunler.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cmbGunler.Items.Remove("Salı");
            cmbGunler.Items.RemoveAt(3);
        }
    }
}
