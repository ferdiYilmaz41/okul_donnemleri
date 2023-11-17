using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace NesneLabDeneme1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            XDocument xdosya = XDocument.Load("kayıtlar.xml");
            XElement rootelement = xdosya.Root;

            XElement element = new XElement("uye");

            XElement name_surname = new XElement("name-surname", textBox8.Text);
            XElement username = new XElement("username", textBox1.Text);
            ///////////////

            SHA256Managed sha256 = new SHA256Managed();
            byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(textBox2.Text);

            string sifreliVeri = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));
            ///////
            XElement password = new XElement("password", sifreliVeri);
            XElement phone = new XElement("phone", textBox3.Text);
            XElement city = new XElement("city", textBox4.Text);
            XElement adress = new XElement("adress", textBox5.Text);
            XElement e_mail = new XElement("e-mail", textBox6.Text);
            XElement country = new XElement("country", textBox7.Text);
            XElement difficulties = new XElement("difficulties", " ");
            XElement shape = new XElement("shape", " ");
            XElement color = new XElement("color", " ");


            element.Add(name_surname, username, password, phone, city, adress, e_mail, country,difficulties,shape,color);
            rootelement.Add(element);

            xdosya.Save("kayıtlar.xml");

            new Form1().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
