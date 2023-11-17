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
           
            int_dizi[0] = 1;
            int_dizi[1] = 2;
            int_dizi[2] = 3;
            int_dizi[3] = 4;
            int_dizi[4] = 5;

            for (int i = 0; i < int_dizi.Length; i++)
            {
                txtEkran.Text += "Dizinin " + i + ". Elemanı " + int_dizi[i]+Environment.NewLine;
            }


            foreach (int item in int_dizi)
            {
                txtEkran.Text +=item + Environment.NewLine;
            }
  
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            int_dizi[1] = 233;

            txtEkran.Text += "___________DEĞİŞTİ___________" + Environment.NewLine;
            for (int i = 0; i < int_dizi.Length; i++)
            {
                txtEkran.Text += "Dizinin " + i + ". Elemanı " + int_dizi[i] + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogr_dizi = new Ogrenci[3];

            //  int_dizi = new int[5];
           double[] int_dizi_2 =  { 11,22,33,44,55};

            int_dizi = new int[] { 111, 111, 222, 333, 444, 555 };


            for (int i = 0; i < int_dizi_2.Length; i++)
            {
                txtEkran.Text += "Dizinin " + i + ". Elemanı " + int_dizi_2[i] + Environment.NewLine;
            }
        }

        private void btnOgre_ArrayListe_Click(object sender, EventArgs e)
        {

            ogr_dizi[0] = new Ogrenci("Uğur", "Gürel", 42);
            ogr_dizi[1] = new Ogrenci("Ali", "Gürel", 44);
            ogr_dizi[2] = new Ogrenci("Ayşe", "Gürel", 49);


            txtEkran.Text = "";
            for (int i = 0; i < ogr_dizi.Length; i++)
            {
                txtEkran.Text += ogr_dizi[i].Ograd + "\t" + ogr_dizi[i].OgrSoyad + "\t" + ogr_dizi[i].OgrYas + Environment.NewLine;
            }
        }

        private void ogrArrayDegistir_Click(object sender, EventArgs e)
        {
            ogr_dizi[1].Ograd = "MEHMET";
            txtEkran.Text += "___________DEĞİŞTİ___________" + Environment.NewLine;
            for (int i = 0; i < ogr_dizi.Length; i++)
            {
                txtEkran.Text += ogr_dizi[i].Ograd + "\t" + ogr_dizi[i].OgrSoyad + "\t" + ogr_dizi[i].OgrYas + Environment.NewLine;
            }
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "";
            foreach (Ogrenci ogr in ogr_dizi)
            {
                txtEkran.Text += ogr.Ograd + "\t" + ogr.OgrSoyad + "\t" + ogr.OgrYas + Environment.NewLine;
            }
        }
    }
}
