using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormatting
{
    public partial class Form1 : Form
    {
        double sayi;
        DateTime simdi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = 2345452.2224345;
            txtSayi.Text = sayi.ToString();
            simdi = DateTime.Now;
            
           
        }

        private void PrintSayiWithFormatting()
        {
            txtEkran.Text = "Para \t\t" + sayi.ToString("c")+Environment.NewLine;
            txtEkran.Text += "Bilimsel \t\t" + sayi.ToString("e") + Environment.NewLine;
            txtEkran.Text += "Fixed Point\t" + sayi.ToString("f")+Environment.NewLine;
            txtEkran.Text += "General\t\t" + sayi.ToString("g")+Environment.NewLine;
            txtEkran.Text += "Binler\t\t" + sayi.ToString("n") + Environment.NewLine;
            txtEkran.Text += "Custom\t\t" + sayi.ToString("(#).##") + Environment.NewLine;
            txtEkran.Text += "Custom 2\t\t" + sayi.ToString("$#$.###") + Environment.NewLine;
            txtEkran.Text = "";
            txtEkran.Text = "ShortDate \t\t" + simdi.ToString("d")+Environment.NewLine;
            txtEkran.Text += "Long date\t\t" + simdi.ToString("D") + Environment.NewLine;
            txtEkran.Text += "Short Time\t\t" + simdi.ToString("t") + Environment.NewLine;
            txtEkran.Text += "Long Date Time\t\t" + simdi.ToString("f") + Environment.NewLine;
            txtEkran.Text += "Short Date Time\t\t" + simdi.ToString("g") + Environment.NewLine;
            txtEkran.Text += "Custom 1\t\t\t" + simdi.ToString("MM.dd.yyyy") + Environment.NewLine;
            txtEkran.Text += "Custom 2\t\t\t" + simdi.ToString("dd.MM.yyyy") + Environment.NewLine;
            txtEkran.Text += "Custom 3\t\t\t" + simdi.ToString("yyyy dd.MM.yyyy") + Environment.NewLine;
            txtEkran.Text += "Custom 4\t\t\t" + simdi.ToString("dddd dd.MM.yyyy")+ Environment.NewLine;
            txtEkran.Text += "Custom 5\t\t\t" + simdi.ToString("dd.MM.yyyy dddd")+ Environment.NewLine;
            txtEkran.Text += "Custom 6\t\t\t" + simdi.ToString("dddd dd MMMMM yyyy HH:mm:ss") + Environment.NewLine;
            txtEkran.Text += "Custom 7\t\t\t" + simdi.ToString("dd.MM.yyyy HH:mm");
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            sayi = double.Parse(txtSayi.Text);
            PrintSayiWithFormatting();
        }

        private void dpZaman_ValueChanged(object sender, EventArgs e)
        {
            simdi = dpZaman.Value;
            PrintSayiWithFormatting();
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            simdi = dpZaman.Value.AddDays(1);
            PrintSayiWithFormatting();
        }

        private void btnSubDay_Click(object sender, EventArgs e)
        {
            simdi = dpZaman.Value.AddDays(-1);
            PrintSayiWithFormatting();
        }
    }
}
