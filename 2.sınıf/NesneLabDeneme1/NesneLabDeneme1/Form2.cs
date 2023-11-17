using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace NesneLabDeneme1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int sayı;
        public static int satir;
        public static int sutun;

        //customda seçilen şekiller
        public static int uk = 0;
        public static int uy = 0;
        public static int us = 0;

        public static int kk = 0;
        public static int ks = 0;
        public static int ky = 0;

        public static int dk = 0;
        public static int ds = 0;
        public static int dy = 0;

        
        private void SekilSıfırla()
        {
            uk = 1;
            uy = 1;
            us = 1;
            kk = 1;
            ks = 1;
            ky = 1;
            dk = 1;
            ds = 1;
            dy = 1;
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            //admin sayfası girişi izni

          


            FileStream fs = new FileStream("username.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            sw.Close();
            fs.Close();
            try
            {





                if (yazi == "admin")
                {
                    admingirisi.Visible = true;
                }
                

                

            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admingirisi_Click(object sender, EventArgs e)
        {
            new Form4().Show();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            PrePlay preplay = new PrePlay();
            this.Close();
            preplay.ShowDialog();

            
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f3 = new Form7();

            f3.ShowDialog();
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsatir_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsutun_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsatir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtsutun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chKsHAPES_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

            satir = 9;
            sutun = 9;

            SekilSıfırla();
            Connection connection = new Connection();
            connection.Show();
            this.Close();
            //Form10_multi multi = new Form10_multi();
            //multi.ShowDialog();
        }
    }
}
