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

        private void Form1_Load(object sender, EventArgs e)
        {
            // lstElemanList.Items.Add("Eleman 1");
            for (int i = 0; i < 10; i++)
            {
                lstElemanList.Items.Add("Eleman " + (i + 1));

            }

            maskedTxt.BackColor = Color.White;
        }

        private void btnSecimiSil_Click(object sender, EventArgs e)
        {
            for (int i = lstElemanList.SelectedIndices.Count-1; i >=0; i--)
            {
                int secili_indis = lstElemanList.SelectedIndices[i];
                lstElemanList.Items.RemoveAt(secili_indis);
            }
        }

        private void mesajKutusuGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj Kutusu Gösterildi");
        }

        private void seçiliOlanlarıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = lstElemanList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int secili_indis = lstElemanList.SelectedIndices[i];
                lstElemanList.Items.RemoveAt(secili_indis);
            }
        }

        private void formuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formRenginiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void btnMaskedTb_Click(object sender, EventArgs e)
        {
            if(maskedTxt.MaskFull)
            {
                MessageBox.Show("Şablon Doğru");
                maskedTxt.BackColor = Color.White;
                lbSonuc.Text = maskedTxt.Text;

            }
            else
            {
                maskedTxt.BackColor = Color.Red;
            }
        }
    }
}
