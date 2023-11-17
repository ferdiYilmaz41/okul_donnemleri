using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double ToplamTutar = 0;
        double IndirimOrani = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckChekedState()
        {
            //if (chkCorap.Checked)
            //{
            //    MessageBox.Show("Çorap Seçili");
            //}
            //else
            //{
            //    MessageBox.Show("Çorap Seçili Değil");
            //}

            //if (chkKazak.Checked)
            //{
            //    MessageBox.Show("Kazak Seçili");
            //}
            //else
            //{
            //    MessageBox.Show("Kazak Seçili Değil");
            //}
            //if (chkAtki.Checked)
            //{
            //    MessageBox.Show("Atkı Seçili");
            //}
            //else
            //{
            //    MessageBox.Show("Atkı Seçili Değil");

            //}




           
            
            

        }
        private void chkCorap_CheckedChanged(object sender, EventArgs e)
        {
            // CheckChekedState();

            if (chkCorap.Checked)
            {
                ToplamTutar += 1;
            }
            else
            {
                ToplamTutar -= 1;
            }
            lbToplamTutar.Text = "Toplam Tutar " + ToplamTutar.ToString("c");
        }

        private void chkKazak_CheckedChanged(object sender, EventArgs e)
        {

            //CheckChekedState(); 
            if (chkKazak.Checked)
            {
                ToplamTutar += 2;
            }
            else
            {
                ToplamTutar -= 2;

            }
            lbToplamTutar.Text = "Toplam Tutar " + ToplamTutar.ToString("c");
        }

        private void chkAtki_CheckedChanged(object sender, EventArgs e)
        {
            // CheckChekedState();
            if (chkAtki.Checked)
            {
                ToplamTutar += 3;
            }
            else
            {
                ToplamTutar -= 3;

            }
            lbToplamTutar.Text = "Toplam Tutar " + ToplamTutar.ToString("c");
        }

        private void rbIndirimYap20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (rbIndirimYapma.Checked)
            {
                IndirimOrani = 0;
            }
            else if (rbIndirimYap10.Checked)
            {
                IndirimOrani = 10;
            }
            else
            {
                IndirimOrani = 20;
            }

            lbIndirim.Text = "İndirim "+(ToplamTutar * (IndirimOrani / 100)).ToString("c");
            lbOdenecek.Text="Ödenecek "+ (ToplamTutar - (ToplamTutar * (IndirimOrani / 100))).ToString("c");
        }
    }
}
