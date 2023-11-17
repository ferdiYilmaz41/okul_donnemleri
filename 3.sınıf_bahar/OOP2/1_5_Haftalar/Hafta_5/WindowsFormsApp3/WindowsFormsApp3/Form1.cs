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

        private void btnYukle_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.AutoSize;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";
        }

        private void btnYukle2_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.CenterImage;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void btnYukle3_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.Normal;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void btnYukle4_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void btnYukle5_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.Zoom;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void Yukle_5_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.Zoom;
           // pcResim.Image = Image.FromFile(@"C:\Users\dualsoft\Source\Repos\2022_2023_OOP\Hafta_5\WindowsFormsApp3\WindowsFormsApp3\Resim\Kedi_3.jpg");
            pcResim.Image = Image.FromFile(@"..\..\Resim\Kedi_3.jpg");

        }
    }
}
