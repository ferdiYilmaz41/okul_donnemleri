using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSecimDegistir_Click(object sender, EventArgs e)
        {
            mnCalender.MaxSelectionCount = 9;
        }

        private void mnCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbTarBas.Text = mnCalender.SelectionStart.ToLongDateString();
            lbTarBit.Text = mnCalender.SelectionEnd.ToLongDateString();

            TimeSpan timeSpan = mnCalender.SelectionEnd - mnCalender.SelectionStart;
            lbGun.Text = timeSpan.TotalDays.ToString();

        }
    }
}
