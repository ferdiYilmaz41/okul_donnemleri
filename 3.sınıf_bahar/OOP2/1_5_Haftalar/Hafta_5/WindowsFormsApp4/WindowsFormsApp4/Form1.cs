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
        Ogrenci[] OgrListesi;
        int SeciliRowIndex = 0;
         int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

     

        private void lstOgrListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SeciliRowIndex = lstOgrListe.FocusedItem.Index;
                txtAd.Text = lstOgrListe.Items[lstOgrListe.FocusedItem.Index].SubItems[1].Text;
                txtSoyad.Text = lstOgrListe.Items[lstOgrListe.FocusedItem.Index].SubItems[2].Text;
                txtNo.Text = lstOgrListe.Items[lstOgrListe.FocusedItem.Index].SubItems[3].Text;
                lbSeciliIndex.Text = SeciliRowIndex.ToString();

                pcResim.Image = Image.FromFile(@"..\..\Resim\"+ lstOgrListe.Items[lstOgrListe.FocusedItem.Index].SubItems[4].Text);
            }
            catch (Exception)
            {

                 
            }
          

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //  string[] row = new string[4];
            id = id + 1;
            string[] row = { id.ToString(), txtAd.Text, txtSoyad.Text, txtNo.Text };
            ListViewItem viewItem = new ListViewItem(row);
            lstOgrListe.Items.Add(viewItem);
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtNo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrListesi = new Ogrenci[3];
            OgrListesi[0] = new Ogrenci(1, "123", "Uğur", "Gürel","kedi_1.jpg");
            OgrListesi[1] = new Ogrenci(2, "334", "Ali", "Gürel", "kedi_2.jpg");
            OgrListesi[2] = new Ogrenci(3,"434","Osman","Avdan", "kedi_3.jpg");

            for (int i = 0; i < OgrListesi.Length; i++)
            {
                string[] row = { OgrListesi[i].Id.ToString(), OgrListesi[i].Ogr_Ad,OgrListesi[i].Ogr_Soyad, OgrListesi[i].Ogr_No, OgrListesi[i].Ogr_Resim };
                ListViewItem viewItem = new ListViewItem(row);
                lstOgrListe.Items.Add(viewItem);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               lstOgrListe.Items[SeciliRowIndex].SubItems[1].Text = txtAd.Text  ;
               lstOgrListe.Items[SeciliRowIndex].SubItems[2].Text = txtSoyad.Text;
               lstOgrListe.Items[SeciliRowIndex].SubItems[3].Text = txtNo.Text;

            }
            catch (Exception)
            {
               
            }
           
        }
    }
}
