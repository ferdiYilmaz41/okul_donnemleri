using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta_1_win_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_Sonuc.Text = "FORM AÇILDI";
            btn_Login.Text = "MERHABA";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           lb_Sonuc.Text = "YENİDEN DEĞİŞTİ !!!";
           // lb_Sonuc.BackColor = Color.Red;
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            lb_Sonuc.Text = " MOUSE ÜZERİNDE";
            btn_Login.BackColor = Color.Red;
            btn_Login.Text = "TIKLAYABİLİRSİN";
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            lb_Sonuc.Text = "MOUSE ÜZERİNDE DEĞİL";
            btn_Login.BackColor = Color.SeaGreen;
            btn_Login.Text = "MERHABA";
        }
    }
}
