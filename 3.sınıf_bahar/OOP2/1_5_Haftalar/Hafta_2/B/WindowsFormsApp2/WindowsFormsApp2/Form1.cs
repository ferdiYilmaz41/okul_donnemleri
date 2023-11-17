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
        Ogrenci ogrenci;
        Araba araba;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenci  = new Ogrenci();
            ogrenci.SetName("Uğur");

            araba = new Araba(2022,"Tofaş",-90);
           // araba.Marka = "Tesla";
           // araba.ModelYili = 2022;
           // araba.KmMenzil = -200;
        }

        private int Topla(int a , int b)
        {
            int toplam_sayi = a + b;
            return toplam_sayi;
        }

        private string ToplaFormatli (int a,int b)
        {
            int toplam_sayi = a + b;
            return "Sayi1 :" + a + " Sayi2:" + b + " Toplam değeri :" + (a + b);
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            txtOgrAd.Text = ogrenci.GetName();
        }

        private void btnOkuAraba_Click(object sender, EventArgs e)
        {
            txtArabaMarka.Text = araba.Marka;
            txtArabaModel.Text = araba.ModelYili.ToString();
            txtKmMenzil.Text = araba.KmMenzil.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);

            // lbSonuc.Text = Topla(sayi1, sayi2).ToString();
            lbSonuc.Text = ToplaFormatli(sayi1, sayi2);
        }
    }
}
