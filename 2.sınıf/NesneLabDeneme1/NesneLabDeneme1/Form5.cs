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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("username.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string metin;
            
                string userName = sw.ReadLine();
                string password = sw.ReadLine();
                txtUsername.Text = userName;
                txtPwd.Text = password;
                
            
            

            sw.Close();
            fs.Close();
            
            XmlDocument xmldoc = new XmlDocument();




            xmldoc.Load("kayıtlar.xml");
            

            
            
            


            foreach (XmlNode node in xmldoc.DocumentElement)
            {
                if (node["username"].InnerText == userName )
                {
                    txtUser.Text = node["name-surname"].InnerText;
                    txtPhone.Text = node["phone"].InnerText;
                    txtCity.Text = node["city"].InnerText;
                    txtCountry.Text = node["country"].InnerText;
                    txtAddress.Text = node["adress"].InnerText;
                    TxtEmail.Text = node["e-mail"].InnerText;

                }
                
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"kayıtlar.xml");
            XElement node = x.Element("uyeler").Elements("uye").FirstOrDefault(
                a => a.Element("username").Value.Trim() == txtUsername.Text);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(txtPwd.Text);

            string sifreliVeri = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));
            if (node != null)
            {

                node.SetElementValue("name-surname", txtUser.Text);
                node.SetElementValue("password", sifreliVeri);
                node.SetElementValue("phone", txtPhone.Text);
                node.SetElementValue("city", txtCity.Text);
                node.SetElementValue("country", txtCountry.Text);
                node.SetElementValue("adress", txtAddress.Text);
                node.SetElementValue("e-mail", TxtEmail.Text);
                x.Save(@"kayıtlar.xml");
                
            }
        }
    }
}
