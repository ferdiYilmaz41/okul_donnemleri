using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormat
{
    public partial class Form1 : Form
    {
        DateTime simdi;
        public Form1()
        {
            InitializeComponent();
        }

        private void FormatMyStrings()
        {
            try
            {
                double sayi = double.Parse(txtFormatlanacakSayi.Text);
                txtSonuc.Text = "Para\t\t" + sayi.ToString("c") + Environment.NewLine;
                txtSonuc.Text += "Bilimsel\t\t" + sayi.ToString("e") + Environment.NewLine;
                txtSonuc.Text += "Fixed Point\t" + sayi.ToString("f") + Environment.NewLine;
                txtSonuc.Text += "General\t\t" + sayi.ToString("g") + Environment.NewLine;
                txtSonuc.Text += "Binlik\t\t" + sayi.ToString("n") + Environment.NewLine;
                txtSonuc.Text += "Custom\t\t" + sayi.ToString("(#).##") + Environment.NewLine;
                txtSonuc.Text += "Custom\t\t" + sayi.ToString("$#$.##") + Environment.NewLine;
                txtSonuc.Text += "Custom\t\t" + sayi.ToString("0.000");
                txtSonuc.Text += "______________________________________________" + Environment.NewLine;
                txtSonuc.Text = "Shortdate\t\t" + simdi.ToString("d") + Environment.NewLine;
                txtSonuc.Text += "LongDate\t\t" + simdi.ToString("D") + Environment.NewLine;
                txtSonuc.Text += "Short Time\t" + simdi.ToString("t") + Environment.NewLine;
                txtSonuc.Text += "Long dateTime\t" + simdi.ToString("f") + Environment.NewLine;
                txtSonuc.Text += "Short Datetime\t" + simdi.ToString("g") + Environment.NewLine;
                txtSonuc.Text += "Custom 1\t\t" + simdi.ToString("MM.dd.yyyy") + Environment.NewLine;
                txtSonuc.Text += "Custom 2\t\t" + simdi.ToString("dd.MM.yyyy") + Environment.NewLine;
                txtSonuc.Text += "Custom 3\t\t" + simdi.ToString("dd.MM.yyyy") + Environment.NewLine;
                txtSonuc.Text += "Custom 4\t\t" + simdi.ToString("dddd dd.MM.yyyy") + Environment.NewLine;
                txtSonuc.Text += "Custom 5\t\t" + simdi.ToString("MMMMM") + Environment.NewLine;
                txtSonuc.Text += "Custom 5\t\t" + simdi.ToString("dddd MMMMM dd.MM.yyyy HH:mm:ss") + Environment.NewLine;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {

            FormatMyStrings();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simdi = new DateTime();
            simdi = DateTime.Now;
           
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            simdi = dtTarih.Value;
            FormatMyStrings();
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            simdi = dtTarih.Value.AddDays(1);
            FormatMyStrings();
        }
    }
}
