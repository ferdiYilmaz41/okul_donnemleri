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
        public Form1()
        {
            InitializeComponent();
        }


        private int Topla(int a,int b)
        {
            int toplam = a + b;
            return toplam;
        }

        private string ToplaFormatli (int a, int b)
        {
            int toplam = a + b;
            return "Sayi 1 :"+ a+"Sayi 2:"+b+"Toplamlari :"+(a+b);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.SetOgrYas(26);
            lbOgrenciYas.Text = ogrenci.GetOgrYas().ToString();

            Kisi kisi = new Kisi(22, -10);
            

            lbOgrenciYas.Text = kisi.KisiBoy.ToString();

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // lbSonuc.Text = (int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString();
            // lbSonuc.Text = Topla(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text)).ToString();
            lbSonuc.Text = ToplaFormatli(int.Parse(txtSayi1.Text), int.Parse(txtSayi2.Text));
        }
    }
}
