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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"kayıtlar.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"kayıtlar.xml");
            XElement node = x.Element("uyeler").Elements("uye").FirstOrDefault(
                a => a.Element("username").Value.Trim() == txtUsername.Text);
            if (node != null)
            {
                node.SetElementValue("name-surname", txtUser.Text);
                //node.SetElementValue("password", txtPwd.Text);
                node.SetElementValue("phone", txtPhone.Text);
                node.SetElementValue("city", txtCity.Text);
                node.SetElementValue("country", txtCountry.Text);
                node.SetElementValue("adress", txtAddress.Text);
                node.SetElementValue("e-mail", TxtEmail.Text);
                x.Save(@"kayıtlar.xml");
                Listele();
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"kayıtlar.xml");
            x.Root.Elements().Where(a => a.Element("name-surname").Value == txtUser.Text).Remove();
            x.Save(@"kayıtlar.xml");
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("kayıtlar.xml");
            string user = txtUsername.Text;
            foreach (XmlNode node in xmldoc.DocumentElement)
            {
                if (node["username"].InnerText == user)
                {
                    txtUser.Text = node["name-surname"].InnerText;
                    txtPwd.Text = node["password"].InnerText;
                    txtPhone.Text = node["phone"].InnerText;
                    txtCity.Text = node["city"].InnerText;
                    txtCountry.Text = node["country"].InnerText;
                    txtAddress.Text = node["adress"].InnerText;
                    TxtEmail.Text = node["e-mail"].InnerText;

                }
                else
                {
                    MessageBox.Show("Could'nt find the user!");
                }
            }
        }
    }
}
