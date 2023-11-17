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
using System.Security.Cryptography;

namespace NesneLabDeneme1
{
    public partial class Form1 : Form
    {
        public static string giden;
        public string FromXML_user = "";
        public string FromXML_password = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pws = txtpassword.Text;
            giden = user;
            


            XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("kayıtlar.xml");

            foreach (XmlNode node in xmldoc.DocumentElement)
            {
                if (node["username"].InnerText == user)
                {
                    SHA256Managed sha256 = new SHA256Managed();
                    byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(pws);

                    string sifreliVeri = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));

                    if (node["password"].InnerText == sifreliVeri)
                    {
                        FileStream fw;
                        StreamWriter sw;
                        fw = new FileStream("username.txt", FileMode.OpenOrCreate, FileAccess.Write);

                        sw = new StreamWriter(fw);
                        sw.WriteLine(txtusername.Text);
                        sw.WriteLine(txtpassword.Text);
                        sw.Close();
                        fw.Close();
                        txtpassword.Clear();
                        new Form2().Show();
                        this.Hide();
                    }
                    else
                    {
                        lbluyarı.Text = "Wrong password!";
                        txtpassword.Clear();
                    }
                }
            }
                


            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("username.txt", FileMode.OpenOrCreate);
                StreamReader sw = new StreamReader(fs);
                string yazi = sw.ReadLine();

                sw.Close();
                fs.Close();
                txtusername.Text = yazi;
            }
            catch (Exception)
            {

            }
            try
            {
                XDocument xdosya1 = XDocument.Load("kayıtlar.xml");
            }
            catch (Exception)
            {
                XmlTextWriter dosya = new XmlTextWriter("kayıtlar.xml", Encoding.UTF8);
                dosya.Formatting = Formatting.Indented;
                dosya.WriteStartElement("uyeler");

                dosya.WriteEndElement();

                dosya.Close();

                XDocument xdosya1 = XDocument.Load("kayıtlar.xml");
                XElement rootelement1 = xdosya1.Root;

                XElement element1 = new XElement("uye");

                XElement name_surname1 = new XElement("name-surname", "admin");
                string adm_pass="admin";
                SHA256Managed sha256 = new SHA256Managed();
                byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(adm_pass);

                string sifreliVeri1 = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));
                XElement username1 = new XElement("username", "admin");
                XElement password1 = new XElement("password", sifreliVeri1);
                XElement phone1 = new XElement("phone", "admin");
                XElement city1 = new XElement("city", "admin");
                XElement adress1 = new XElement("adress", "admin");
                XElement e_mail1 = new XElement("e-mail", "admin");
                XElement country1 = new XElement("country", "admin");
                XElement difficulties = new XElement("difficulties", " ");
                XElement shape = new XElement("shape", " ");
                XElement color = new XElement("color", " ");
                element1.Add(name_surname1, username1, password1, phone1, city1, adress1, e_mail1, country1, difficulties, shape, color);
                rootelement1.Add(element1);

                xdosya1.Save("kayıtlar.xml");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoster.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            
            f3.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            
        }
    }
}
