using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//bağlantının açık olup olmadığını kontrol eder
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;



namespace NesneLabDeneme1
{
    public partial class Form10_multi : Form
    {
        private bool clickTemp = false;
        private Color color;
        private string shape;
        private Button buttontemp;
        private Button[,] buttonarraytemp;

        static int satir =9;
        static int sutun = 9;
        int flag = (satir * sutun); // maks hamle sayısını hesaplıyor
        int flag1 = 0;

        int puan;

        int uk = Form2.uk;
        int uy = Form2.uy;
        int us = Form2.us;

        int kk = Form2.kk;
        int ks = Form2.ks;
        int ky = Form2.ky;

        int dk = Form2.dk;
        int ds = Form2.ds;
        int dy = Form2.dy;

        int x = 3; // dolu kare sayısını tutuyor

        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        
            

        public int player1 = 1;
        public int player2 = 2;

        public Form10_multi(bool isHost, string ip = null)
        {
            InitializeComponent();



            MessageReceiver.DoWork += MessageReceiver_DoWork;
            
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }

        }

        private BackgroundWorker b1 = new BackgroundWorker();
        private void MessageReceiver_RunWorkerCompleted(Button[,] butonlar)
        {


        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {

           
            








            /*
            if (CheckState())
                return;
            FreezeBoard();
            label1.Text = "Opponent's Turn!";
            ReceiveMove();
            label1.Text = "Your Trun!";
            if (!CheckState())
                UnfreezeBoard();
                */
        }

        private void Ucekle(Button[,] buton, int maks)
        {
            string ucgen = "▲";
            string daire = "○";
            string kare = "▀";

            for (int i = 0; i < maks; i++)
            {
                Random rastgele = new Random();
                int rSatir = rastgele.Next(satir);
                int rSutun = rastgele.Next(sutun);
                if (buton[rSatir, rSutun].Text == "")
                {


                    int tur = rastgele.Next(9);
                    if (tur == 0)
                    {
                        if (uk == 1)
                        {

                            buton[rSatir, rSutun].BackColor = Color.Red;
                            buton[rSatir, rSutun].Text = ucgen;
                        }
                        else i--;

                    }
                    if (tur == 1)
                    {

                        if (kk == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Red;
                            buton[rSatir, rSutun].Text = kare;
                        }
                        else i--;

                    }
                    if (tur == 2)
                    {
                        if (dk == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Red;
                            buton[rSatir, rSutun].Text = daire;
                        }
                        else i--;

                    }
                    if (tur == 3)
                    {
                        if (uy == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Green;
                            buton[rSatir, rSutun].Text = ucgen;
                        }
                        else i--;

                    }
                    if (tur == 4)
                    {
                        if (ky == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Green;
                            buton[rSatir, rSutun].Text = kare;
                        }
                        else i--;

                    }
                    if (tur == 5)
                    {
                        if (dy == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Green;
                            buton[rSatir, rSutun].Text = daire;
                        }
                        else i--;

                    }
                    if (tur == 6)
                    {
                        if (us == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Yellow;
                            buton[rSatir, rSutun].Text = ucgen;
                        }
                        else i--;

                    }
                    if (tur == 7)
                    {
                        if (ks == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Yellow;
                            buton[rSatir, rSutun].Text = kare;
                        }
                        else i--;

                    }
                    if (tur == 8)
                    {
                        if (ds == 1)
                        {
                            buton[rSatir, rSutun].BackColor = Color.Yellow;
                            buton[rSatir, rSutun].Text = daire;
                        }
                        else i--;
                    }
                }
                else i--;

            }//end-for


        }
        private void TabloyaKaydet()
        {
            SqlConnection connection1 = new SqlConnection("Data Source=myFirtsDB.mssql.somee.com;Initial Catalog=myFirtsDB;Persist Security Info=True;User ID=kacarberke_SQLLogin_1;Password=vgb5g6e8cb");
            connection1.Open();
            SqlCommand idc = new SqlCommand("Select * from puanTablosu", connection1);
            idc.ExecuteNonQuery();
            SqlDataReader oku;
            int flag = 0;
            oku = idc.ExecuteReader();
            while (oku.Read())
            {
                if (oku["username"].ToString() == Form1.giden)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            oku.Close();

            if (flag == 0)
            {
                SqlCommand ekle = new SqlCommand("insert into puanTablosu(username,puan) values(@puser,@ppuan) ", connection1);
                ekle.Parameters.AddWithValue("@puser", Form1.giden);
                ekle.Parameters.AddWithValue("@ppuan", puan);
                ekle.ExecuteNonQuery();
            }
            if (flag == 1)
            {
                SqlCommand komut = new SqlCommand("update puanTablosu set username=@puser ,puan=@ppuan", connection1);
                komut.Parameters.AddWithValue("@puser", Form1.giden);
                komut.Parameters.AddWithValue("@ppuan", puan);
                komut.ExecuteNonQuery();
            }
            connection1.Close();

        }
        private void ButonlarıDondur(Button[,] donacakButon)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    donacakButon[i, j].Enabled = false;
                }
            }
        }
        private void ButonlarıCoz(Button[,] cozulecekButon)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cozulecekButon[i, j].Enabled = true;
                }
            }
        }
        private void BesliyiSil(Button[,] buttonarraytemp)
        {
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun - 5; j++)
                {
                    if (buttonarraytemp[i, j].Text != "")
                    {
                        for (int a = 0; a < 5; a++)
                        {
                            if (buttonarraytemp[i, j].Text == buttonarraytemp[i, j + a].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i, j + a].BackColor)
                            {
                                flag1 += 1;
                            }
                            else break;
                        }
                    }
                    if (flag1 == 5)
                    {
                        SoundPlayer warband = new SoundPlayer(@"3.wav");
                        warband.Play();
                        if (flag <= 36)
                        {
                            puan += 5;
                        }
                        if (flag <= 81 && flag > 36)
                        {
                            puan += 3;
                        }
                        if (flag <= 225 && flag > 81)
                        {
                            puan += 1;
                        }
                        for (int a = 0; a < 5; a++)
                        {
                            buttonarraytemp[i, j + a].Text = "";
                            buttonarraytemp[i, j + a].BackColor = Color.AliceBlue;
                        }
                        x -= 5;
                    }
                    flag1 = 0;
                }
            }
            for (int i = 0; i < satir - 5; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (buttonarraytemp[i, j].Text != "")
                    {
                        for (int a = 0; a < 5; a++)
                        {
                            if (buttonarraytemp[i, j].Text == buttonarraytemp[i + a, j].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i + a, j].BackColor)
                            {
                                flag1 += 1;
                            }
                            else break;
                        }
                    }
                    if (flag1 == 5)
                    {
                        SoundPlayer warband = new SoundPlayer(@"3.wav");
                        warband.Play();
                        if (flag <= 36)
                        {
                            puan += 5;
                        }
                        if (flag <= 81 && flag > 36)
                        {
                            puan += 3;
                        }
                        if (flag <= 225 && flag > 81)
                        {
                            puan += 1;
                        }
                        for (int a = 0; a < 5; a++)
                        {
                            buttonarraytemp[i + a, j].Text = "";
                            buttonarraytemp[i + a, j].BackColor = Color.AliceBlue;
                        }
                        x -= 5;
                    }
                    flag1 = 0;
                }
            }
            label2.Text = puan.ToString();
        }

        private void Button_Click(System.Object sender, System.EventArgs e)
        {

            Button btn = (Button)sender;
            //buttonarraytemp = kral;

            if (x < flag)
            {
                if (flag - 1 == x)
                {
                    if (clickTemp == false && btn.BackColor != Color.AliceBlue)
                    {
                        color = btn.BackColor;
                        shape = btn.Text;
                        buttontemp = btn;


                        clickTemp = true;

                    }
                    if (clickTemp == true && btn.BackColor == Color.AliceBlue)
                    {
                        btn.BackColor = color;
                        btn.Text = shape;
                        buttontemp.BackColor = Color.AliceBlue;
                        buttontemp.Text = "";
                        clickTemp = false;
                        SoundPlayer music = new SoundPlayer(@"1.wav");
                        music.Play();
                        string ucgen = "▲";
                        string daire = "○";
                        string kare = "▀";
                        for (int i = 0; i < 1; i++)
                        {
                            Random rastgele = new Random();
                            int rSatir = rastgele.Next(satir);
                            int rSutun = rastgele.Next(sutun);
                            if (buttonarraytemp[rSatir, rSutun].Text == "")
                            {


                                int tur = rastgele.Next(9);
                                if (tur == 0)
                                {
                                    if (uk == 1)
                                    {

                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 1)
                                {

                                    if (kk == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 2)
                                {
                                    if (dk == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;

                                }
                                if (tur == 3)
                                {
                                    if (uy == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 4)
                                {
                                    if (ky == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 5)
                                {
                                    if (dy == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;

                                }
                                if (tur == 6)
                                {
                                    if (us == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 7)
                                {
                                    if (ks == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 8)
                                {
                                    if (ds == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;
                                }
                            }
                            else i--;

                        }//end-for
                        x += 1;

                    }
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun - 5; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i, j + a].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i, j + a].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i, j + a].Text = "";
                                    buttonarraytemp[i, j + a].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    for (int i = 0; i < satir - 5; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i + a, j].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i + a, j].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i + a, j].Text = "";
                                    buttonarraytemp[i + a, j].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    label2.Text = puan.ToString();
                }

                if (flag - 2 == x)
                {
                    if (clickTemp == false && btn.BackColor != Color.AliceBlue)
                    {
                        color = btn.BackColor;
                        shape = btn.Text;
                        buttontemp = btn;
                        clickTemp = true;

                    }
                    if (clickTemp == true && btn.BackColor == Color.AliceBlue)
                    {
                        btn.BackColor = color;
                        btn.Text = shape;
                        buttontemp.BackColor = Color.AliceBlue;
                        buttontemp.Text = "";
                        clickTemp = false;
                        SoundPlayer music = new SoundPlayer(@"1.wav");
                        music.Play();
                        string ucgen = "▲";
                        string daire = "○";
                        string kare = "▀";
                        for (int i = 0; i < 2; i++)
                        {
                            Random rastgele = new Random();
                            int rSatir = rastgele.Next(satir);
                            int rSutun = rastgele.Next(sutun);
                            if (buttonarraytemp[rSatir, rSutun].Text == "")
                            {


                                int tur = rastgele.Next(9);
                                if (tur == 0)
                                {
                                    if (uk == 1)
                                    {

                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 1)
                                {

                                    if (kk == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 2)
                                {
                                    if (dk == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;

                                }
                                if (tur == 3)
                                {
                                    if (uy == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 4)
                                {
                                    if (ky == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 5)
                                {
                                    if (dy == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;

                                }
                                if (tur == 6)
                                {
                                    if (us == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 7)
                                {
                                    if (ks == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 8)
                                {
                                    if (ds == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;
                                }
                            }
                            else i--;

                        }//end-for
                        x += 2;

                    }
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun - 5; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i, j + a].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i, j + a].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i, j + a].Text = "";
                                    buttonarraytemp[i, j + a].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    for (int i = 0; i < satir - 5; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i + a, j].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i + a, j].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i + a, j].Text = "";
                                    buttonarraytemp[i + a, j].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    label2.Text = puan.ToString();
                }
                else
                {
                    if (clickTemp == false && btn.BackColor != Color.AliceBlue)
                    {
                        color = btn.BackColor;
                        shape = btn.Text;
                        buttontemp = btn;
                        clickTemp = true;
                    }
                    if (clickTemp == true && btn.BackColor == Color.AliceBlue)
                    {
                        btn.BackColor = color;
                        btn.Text = shape;
                        buttontemp.BackColor = Color.AliceBlue;
                        buttontemp.Text = "";
                        clickTemp = false;
                        SoundPlayer music = new SoundPlayer(@"1.wav");
                        music.Play();
                        string ucgen = "▲";
                        string daire = "○";
                        string kare = "▀";
                        
                        
                        for (int i = 0; i < 3; i++)
                        {
                            Random rastgele = new Random();
                            int rSatir = rastgele.Next(satir);
                            int rSutun = rastgele.Next(sutun);
                            if (buttonarraytemp[rSatir, rSutun].Text == "")
                            {


                                int tur = rastgele.Next(9);
                                if (tur == 0)
                                {
                                    if (uk == 1)
                                    {

                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 1)
                                {

                                    if (kk == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 2)
                                {
                                    if (dk == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Red;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;

                                }
                                if (tur == 3)
                                {
                                    if (uy == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 4)
                                {
                                    if (ky == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 5)
                                {
                                    if (dy == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Green;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;

                                }
                                if (tur == 6)
                                {
                                    if (us == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = ucgen;
                                    }
                                    else i--;

                                }
                                if (tur == 7)
                                {
                                    if (ks == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = kare;
                                    }
                                    else i--;

                                }
                                if (tur == 8)
                                {
                                    if (ds == 1)
                                    {
                                        buttonarraytemp[rSatir, rSutun].BackColor = Color.Yellow;
                                        buttonarraytemp[rSatir, rSutun].Text = daire;
                                    }
                                    else i--;
                                }
                            }
                            else i--;

                        }//end-for                       
                        x += 3;
                    }
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun - 5; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i, j + a].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i, j + a].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i, j + a].Text = "";
                                    buttonarraytemp[i, j + a].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    for (int i = 0; i < satir - 5; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            if (buttonarraytemp[i, j].Text != "")
                            {
                                for (int a = 0; a < 5; a++)
                                {
                                    if (buttonarraytemp[i, j].Text == buttonarraytemp[i + a, j].Text && buttonarraytemp[i, j].BackColor == buttonarraytemp[i + a, j].BackColor)
                                    {
                                        flag1 += 1;
                                    }
                                    else break;
                                }
                            }
                            if (flag1 == 5)
                            {
                                SoundPlayer warband = new SoundPlayer(@"3.wav");
                                warband.Play();
                                if (flag <= 36)
                                {
                                    puan += 5;
                                }
                                if (flag <= 81 && flag > 36)
                                {
                                    puan += 3;
                                }
                                if (flag <= 225 && flag > 81)
                                {
                                    puan += 1;
                                }
                                for (int a = 0; a < 5; a++)
                                {
                                    buttonarraytemp[i + a, j].Text = "";
                                    buttonarraytemp[i + a, j].BackColor = Color.AliceBlue;
                                }
                                x -= 5;
                            }
                            flag1 = 0;
                        }
                    }
                    label2.Text = puan.ToString();
                }
            }
            else
            {
                string point = puan.ToString();
                TabloyaKaydet();
                this.Hide();
                MessageBox.Show("Oyun bitti puanınız: " + point);
                new Form2().Show();
            }
        }

        private void Form10_multi_Load(object sender, EventArgs e)
        {

            int horizotal = 0;
            int vertical = 40;
            Button[,] buttonArray = new Button[satir, sutun];
            buttonarraytemp = buttonArray;

            for (int i = 0; i < satir; i++)
            {
                for (int y = 0; y < sutun; y++)
                {
                    buttonArray[i, y] = new Button();
                    buttonArray[i, y].Size = new Size(40, 40);
                    buttonArray[i, y].Location = new Point(horizotal, vertical);
                    buttonArray[i, y].BackColor = Color.AliceBlue;
                    buttonArray[i, y].Click += Button_Click; // click event yükle


                    horizotal += 40;
                    this.Controls.Add(buttonArray[i, y]);
                }
                vertical += 40;
                horizotal = 0;
            }
            /////////şekil renk ekleme
            Ucekle(buttonarraytemp, 3);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            TabloyaKaydet();
            this.Close();
            Form2 menü = new Form2();
            menü.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
