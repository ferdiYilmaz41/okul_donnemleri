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
        double AraToplam = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbSecim1_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbIndirim0.Checked)
            //{
            //    MessageBox.Show("Seçim 1 Seçili");
            //}

        }

        private void rbSecim2_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbIndirim10.Checked)
            //{
            //    MessageBox.Show("Seçim 2 Seçili");
            //}
        }

        private double IndirimOraniGetir ()
        {
            double indirimOrani = 0;
            if (rbIndirim0.Checked)
            { indirimOrani = 0; }
            else if (rbIndirim10.Checked)
            {
                indirimOrani = 10;
            }
            else
            {
                indirimOrani = 20;
            }
            return indirimOrani;
        }

        private void SecimiKontrolEt()
        {
            if (cbCorap.Checked)
            {
                MessageBox.Show("Çorap Seçili");
            }
            else
            {
                MessageBox.Show("Çorap Seçili Değil");
            }


            if (cbPantolon.Checked)
            {
                MessageBox.Show("Pantolon Seçili");
            }
            else
            {
                MessageBox.Show("Pantolon Seçili Değil");
            }

            if (cbAyakkabi.Checked)
            {
                MessageBox.Show("Ayakkabı Seçili");
            }
            else
            {
                MessageBox.Show("Ayakkabı Seçili Değil");
            }

        }
        private void cbCorap_CheckedChanged(object sender, EventArgs e)
        {
           // SecimiKontrolEt();
           if (cbCorap.Checked)
            {
                //AraToplam = AraToplam + 10;
                AraToplam += 10;
            }
            else
            {
                AraToplam -= 10;
            }
            lbAraToplam.Text = "Ara Toplam "+AraToplam.ToString("c");
            lbIndirimTutari.Text = "İndirim Tutarı " + (AraToplam * (IndirimOraniGetir() / 100)).ToString("c");
        }

        private void cbPantolon_CheckedChanged(object sender, EventArgs e)
        {
           // SecimiKontrolEt();
           if (cbPantolon.Checked)
            {
                AraToplam += 20;
            }
            else
            {
                AraToplam -= 20;
            }
            lbAraToplam.Text = "Ara Toplam " + AraToplam.ToString("c");
            lbIndirimTutari.Text = "İndirim Tutarı " + (AraToplam * (IndirimOraniGetir() / 100)).ToString("c");
        }

        private void cbAyakkabi_CheckedChanged(object sender, EventArgs e)
        {
            //SecimiKontrolEt();
            if (cbAyakkabi.Checked)
            {
                AraToplam += 30;
            }
            else
            {
                AraToplam -= 30;
            }

            lbAraToplam.Text = "Ara Toplam " + AraToplam.ToString("c");
            lbIndirimTutari.Text = "İndirim Tutarı "+(AraToplam * IndirimOraniGetir() / 100).ToString("c");
        }
    }
}
 
