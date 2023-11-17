using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                lbSonuc.Text = (int.Parse(txtSayi1.Text) / int.Parse(txtSayi2.Text)).ToString();
            }
            //catch (FormatException ex)
            //{
            //    lbHata.Text = ex.ToString();
 
            //    txtSayi1.Text = "0";
            //    txtSayi2.Text = "0";

            //    txtSayi1.BackColor = Color.Red;
            //    txtSayi2.BackColor = Color.Red;
            //}
            catch (Exception ex)
            {
                lbHata.Text = ex.ToString();
            }
        }
    }
}
