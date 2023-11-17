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
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void btnMesajKutusu_Click(object sender, EventArgs e)
        {
            String Mesaj = "Bu Form Kapatılsın Mı?";
            String Baslik = "Form Kapama";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;

            MessageBox.Show(Mesaj,Baslik, btn, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = MessageBox.Show("Form Ardalan Rengi Değişecek ?", "Form Rengi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (dialog_result == DialogResult.Yes)
            {
                // txtEkran.BackColor = Color.Red;
                this.BackColor = Color.Red;
                txtEkran.Text = "";
            }
            else if (dialog_result == DialogResult.No)
            {
                txtEkran.Text = "Hayır Ya basıldı";
            }
            else
            {
                txtEkran.Text = "İptal a basıldı";
            }

        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                String myFontname = "";
                float myFontSize = 0;

                myFontname = fontDialog.Font.Name;
                myFontSize = fontDialog.Font.Size;

                MessageBox.Show(" Seçili Font İsmi: " + myFontname + " Seçili Font Büyüklüğü : +" + myFontSize );

                btnFontDialog.Font = fontDialog.Font;
                btnFontDialog.BackColor = fontDialog.Color;

            }
        }
    }
}
