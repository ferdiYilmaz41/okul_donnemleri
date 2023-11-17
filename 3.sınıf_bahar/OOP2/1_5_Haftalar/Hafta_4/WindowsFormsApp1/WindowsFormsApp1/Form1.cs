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

        private void btnSimpleMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Bir Mesaj","Bu Mesaj Kutusunun Başlığı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btnMsgDlg_Click(object sender, EventArgs e)
        {
            String Msg = "Bu programı kapatmak istiyor musunuz ?";
            String Baslik = "Program kapatilacak";
            DialogResult result = MessageBox.Show(Msg, Baslik, MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) {
                // this.Close();
                lbSonuc.Text = "Kullanıcı EVET Dedi";
            }  
            else if (result == DialogResult.No)
            {
                lbSonuc.Text = "Kullanıcı HAYIR Dedi";
            }
            else
            {
                lbSonuc.Text = "Kullanici İPTAL Dedi";
            }
            
                }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowColor = true;
            dialog.ShowHelp = true;

            if(dialog.ShowDialog() != DialogResult.Cancel)
            {
                string FontName = "";
                float FontSize = 0;

                FontName = dialog.Font.Name;
                FontSize = dialog.Font.Size;

                MessageBox.Show("Seçilen Font =" + FontName + " Seçilen Font Size " + FontSize);
                lbSonuc.Text = "Bu bir Mesajdır";
                lbSonuc.Font = dialog.Font;
                btnMsgDlg.Font = dialog.Font;

                lbSonuc.BackColor = dialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
