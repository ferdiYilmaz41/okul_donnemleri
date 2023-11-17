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

        private void btnYukle_1_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.AutoSize;
            //pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";
            pcResim.Image = Image.FromFile(@"..\..\Resim\Esogu_logo.png");

        }

        private void btnYukle_2_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.CenterImage;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void btnYukle_3_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.Normal;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void btnYukle_4_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pcResim.SizeMode = PictureBoxSizeMode.Zoom;
            pcResim.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/6/6d/Esogu_logo.png?20200406220948";

        }
    }
}
