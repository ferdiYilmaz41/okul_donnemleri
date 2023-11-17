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
    public partial class PrePlay : Form
    {
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

        private void SekilSec()
        {
            if (redTri.Checked == true)
            {
                uk = 1;
            }
            if (greenTri.Checked == true)
            {
                uy = 1;
            }
            if (yellowtri.Checked == true)
            {
                us = 1;
            }
            if (redSqr.Checked == true)
            {
                kk = 1;
            }
            if (yellowSqr.Checked == true)
            {
                ks = 1;
            }
            if (greenSqr.Checked == true)
            {
                ky = 1;
            }
            if (redCrc.Checked == true)
            {
                dk = 1;
            }
            if (yellowCrc.Checked == true)
            {
                ds = 1;
            }
            if (greenCrc.Checked == true)
            {
                dy = 1;
            }

        }
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

        public PrePlay()
        {
            InitializeComponent();
        }

        private void PrePlay_Load(object sender, EventArgs e)
        {
            //admin sayfası girişi izni

            label4.Text = Form1.giden;
            label4.Visible = false;


            FileStream fs = new FileStream("username.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            sw.Close();
            fs.Close();
            try
            {





                //if (yazi == "admin")
                //{
                //    admingirisi.Visible = true;
                //}
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("kayıtlar.xml");

                foreach (XmlNode node in xmldoc.DocumentElement)
                {
                    if (node["username"].InnerText == label4.Text)
                    {
                        comboBox1.Text = node["difficulties"].InnerText;

                        string[] shape = node["shape"].InnerText.Split(',');
                        foreach (string index in shape)
                        {
                            if (index == "triangle")
                            {
                                redTri.Checked = true;
                            }
                            if (index == "square")
                            {
                                redSqr.Checked = true;
                            }
                            if (index == "circle")
                            {
                                redCrc.Checked = true;
                            }

                        }
                        string[] color = node["color"].InnerText.Split(',');
                        foreach (String renk in color)
                        {
                            if (renk == "red")
                            {
                                greenTri.Checked = true;
                            }
                            if (renk == "yellow")
                            {
                                greenSqr.Checked = true;
                            }
                            if (renk == "green")
                            {
                                greenCrc.Checked = true;
                            }
                        }
                    }



                }

            }
            catch (Exception)
            {

            }
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustom.Checked == true)
            {
                panel1.Enabled = true;
                comboBox1.Enabled = false;
            }
            if (chkCustom.Checked == false)
            {
                panel1.Enabled = false;
                comboBox1.Enabled = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (chkCustom.Checked == true)
            {
                if (txtsatir.Text == "" || txtsutun.Text == "")
                {
                    MessageBox.Show("Lütfen satır ve sütunu yazınız!");
                }
                else
                {
                    sutun = int.Parse(txtsutun.Text);
                    satir = int.Parse(txtsatir.Text);
                }

                if (satir < 20 && sutun < 20)
                {
                    if (satir >= 6 && sutun >= 6)
                    {
                        if (chKsHAPES.Checked == true)
                        {
                            SekilSec();

                        }
                        if (chKsHAPES.Checked == false)
                        {
                            SekilSıfırla();
                        }

                        Form6 f6 = new Form6();
                        f6.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Satır veya sütun sayısı 6'dan az olamaz!");

                }
                else
                {
                    MessageBox.Show("Satır veya sütun sayısı 20'den fazla olamaz!");

                }

            }
            else if (chkCustom.Checked == false)
            {
                if (comboBox1.Text == "easy")
                {
                    satir = 15;
                    sutun = 15;
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Close();
                }
                else if (comboBox1.Text == "normal")
                {
                    satir = 9;
                    sutun = 9;
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Close();
                }
                else if (comboBox1.Text == "hard")
                {
                    satir = 5;
                    sutun = 5;
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen zorluğu seçiniz!");
                }
                
            }
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

        private void txtsatir_TextChanged(object sender, EventArgs e)
        {

        }

        private void chKsHAPES_CheckedChanged(object sender, EventArgs e)
        {
            if (chKsHAPES.Checked == true)
            {
                panel2.Enabled = true;
            }
            else
                panel2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "easy")
            {
                satir = 15;
                sutun = 15;
            }
            if (comboBox1.Text == "normal")
            {
                satir = 9;
                sutun = 9;
            }
            if (comboBox1.Text == "hard")
            {
                satir = 5;
                sutun = 5;
            }

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("kayıtlar.xml");
            foreach (XmlNode node in xmldoc.DocumentElement)
            {
                if (node["username"].InnerText == label4.Text)
                {
                    node["difficulties"].InnerText = comboBox1.Text;
                    //node["shape"].InnerText = label5.Text;
                    //node["color"].InnerText = label5.Text;
                    if (redTri.Checked)
                    {
                        node["shape"].InnerText += "triangle,";
                    }
                    if (redSqr.Checked)
                    {
                        node["shape"].InnerText += "square,";
                    }
                    if (redCrc.Checked)
                    {
                        node["shape"].InnerText += "circle";
                    }
                    if (greenTri.Checked)
                    {
                        node["color"].InnerText += "red,";
                    }
                    if (greenCrc.Checked)
                    {
                        node["color"].InnerText += "green,";
                    }
                    if (greenSqr.Checked)
                    {
                        node["color"].InnerText += "yellow";
                    }
                }
            }
            xmldoc.Save("kayıtlar.xml");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Close();
            f2.Show();
        }
    }
}
