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

        private void btnSecim_Click(object sender, EventArgs e)
        {
            lbSecim.Text = "Text "+cmbGunler.Text +" Index"+cmbGunler.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGunler.SelectedIndex = 1;
        }

        private void cmbGunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSecim.Text = "index " + cmbGunler.SelectedIndex;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkle.Text.Length > 0)
            {
                cmbGunler_2.Items.Add(txtEkle.Text);
                txtEkle.Text = "";
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            cmbGunler_2.Items.Remove("Ugur");
        }

        private void btnCikar_2_Click(object sender, EventArgs e)
        {
            try
            {
                cmbGunler_2.Items.RemoveAt(2);
            }
            catch (Exception)
            {
 
            }
           
        }
    }
}
