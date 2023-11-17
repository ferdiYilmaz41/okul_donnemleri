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
        int[] int_dizi;
        Ogrenci[] ogr_dizi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            int_dizi[0] = 2;
            int_dizi[1] = 21;
            int_dizi[2] = 32;
            int_dizi[3] = 222;
            int_dizi[4] = 12;

            for (int i = 0; i < int_dizi.Length; i++)
            {
                txtEkran.Text += "Dizinin " + i + ". Elemanı :" + int_dizi[i]+Environment.NewLine;
            }
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            //  dizi = new int[5];

            int_dizi = new int[] { 1, 2, 3, 4, 5 };
            ogr_dizi = new Ogrenci[3];

        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            //Değerleri Doldurma

            ogr_dizi[0] = new Ogrenci("Uğur", "Gürel", 43);
            ogr_dizi[1] = new Ogrenci("Ada", "Gürel", 44);
            ogr_dizi[2] = new Ogrenci("Melike", "Ada", 44);
            // Listeleme
            txtEkran.Text = "";
            for (int i = 0; i < ogr_dizi.Length; i++)
            {
                txtEkran.Text += i + ". Öğrenci " + ogr_dizi[i].OgrAd + "\t" + ogr_dizi[i].OgrSoyAd + "\t" + ogr_dizi[i].OgrYas + Environment.NewLine;
            }
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            ogr_dizi[1].OgrAd = "DEĞİŞTİ";
            txtEkran.Text = "";
            for (int i = 0; i < ogr_dizi.Length; i++)
            {
                txtEkran.Text += i + ". Öğrenci " + ogr_dizi[i].OgrAd + "\t" + ogr_dizi[i].OgrSoyAd + "\t" + ogr_dizi[i].OgrYas + Environment.NewLine;
            }
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            foreach (int item in int_dizi)
            {
                txtEkran.Text += item + Environment.NewLine;
            }
        }
    }
}
