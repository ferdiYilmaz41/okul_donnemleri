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
            for (int i = 0; i < 10; i++)
            {
                lst_liste.Items.Add("Eleman " + (i + 1));
            }
            txtMaske.BackColor = Color.White;
        }

        private void btnCokluSil_Click(object sender, EventArgs e)
        {
            for (int i = lst_liste.SelectedIndices.Count-1; i >=0 ; i--)
            {
                int Seciliİndis = lst_liste.SelectedIndices[i];
                lst_liste.Items.RemoveAt(Seciliİndis);
            }
        }

        private void mesajKutusuÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir Mesaj Kutusu");
        }

        private void seçimleriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = lst_liste.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int Seciliİndis = lst_liste.SelectedIndices[i];
                lst_liste.Items.RemoveAt(Seciliİndis);
            }
        }

        private void ardalanRenginiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void formuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckMask_Click(object sender, EventArgs e)
        {
            if (txtMaske.MaskFull)
            {
                MessageBox.Show("Formatlama Doğru");
                txtMaske.BackColor = Color.White;
            }
            else
            {
                txtMaske.BackColor = Color.Red;
            }
        }
    }
}
