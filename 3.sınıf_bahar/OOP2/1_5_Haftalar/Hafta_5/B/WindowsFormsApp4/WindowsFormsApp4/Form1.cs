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
        Kedi[] Kediler;
        int SeciliSatirIndis = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTekSatir_Click(object sender, EventArgs e)
        {
            string[] row = { "Kolon 1", "Kolon 2", "Kolon 3" };
            ListViewItem viewItem = new ListViewItem(row);
            lstKediListesi.Items.Add(viewItem);
        }

        private void btnEkleParametre_Click(object sender, EventArgs e)
        {
            try
            {
                string[] row = { txtAdi.Text, txtCinsi.Text, txtYasi.Text };
                ListViewItem viewItem = new ListViewItem(row);
                lstKediListesi.Items.Add(viewItem);
                txtAdi.Text = "";
                txtCinsi.Text = "";
                txtYasi.Text = "";


            }
            catch (Exception)
            {

               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kediler = new Kedi[3];

            Kediler[0] = new Kedi("Minnoş", "Tekir", "3","kedi_1.jpg");
            Kediler[1] = new Kedi("Sarı", "Sarman", "1","kedi_2.jpg");
            Kediler[2] = new Kedi("Yaramaz", "Smokin", "1","kedi_3.jpg");

            for (int i = 0; i < Kediler.Length; i++)
            {
                String[] row = { Kediler[i].Adi, Kediler[i].Cinsi, Kediler[i].Yasi, Kediler[i].Resim };
                ListViewItem viewItem = new ListViewItem(row);
                lstKediListesi.Items.Add(viewItem);
            }
           
                
                
                
                }

        private void lstKediListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdi.Text = lstKediListesi.Items[lstKediListesi.FocusedItem.Index].SubItems[0].Text;
            txtCinsi.Text = lstKediListesi.Items[lstKediListesi.FocusedItem.Index].SubItems[1].Text;
            txtYasi.Text = lstKediListesi.Items[lstKediListesi.FocusedItem.Index].SubItems[2].Text;
            pcKedi.Image = Image.FromFile(@"..\..\Resim\" + lstKediListesi.Items[lstKediListesi.FocusedItem.Index].SubItems[3].Text);
            SeciliSatirIndis = lstKediListesi.FocusedItem.Index;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
             lstKediListesi.Items[SeciliSatirIndis].SubItems[0].Text = txtAdi.Text ;
             lstKediListesi.Items[SeciliSatirIndis].SubItems[1].Text = txtCinsi.Text ;
             lstKediListesi.Items[SeciliSatirIndis].SubItems[2].Text = txtYasi.Text;

        }
    }
}
