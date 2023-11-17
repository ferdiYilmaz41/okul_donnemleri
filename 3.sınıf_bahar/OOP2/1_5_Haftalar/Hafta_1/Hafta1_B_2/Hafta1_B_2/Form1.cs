using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Hafta1_B_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            lb_Ekran.Text = "Merhaba Dünya";
            lb_Ekran.BackColor = Color.DarkBlue;
        }

        private void btn_Login_MouseMove(object sender, MouseEventArgs e)
        {
           // lb_Ekran.Text = "BUtonda HAreket" + e.X + " " + e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          //  lb_Ekran.Text = "FORMDA HAREKET "+e.X+" "+e.Y;
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            lb_Ekran.Text = "Mouse Üzerinde";
            lb_Ekran.BackColor = Color.Red;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            lb_Ekran.Text = "Mouse Üzerinde Deðil";
            lb_Ekran.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
