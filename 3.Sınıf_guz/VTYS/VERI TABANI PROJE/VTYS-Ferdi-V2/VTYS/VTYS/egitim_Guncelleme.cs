using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace VTYS
{
    public partial class egitim_Guncelleme : Form
    {
        public egitim_Guncelleme()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"Data Source = DESKTOP-R9M819K\\MSSQLSERVERYENI; Initial Catalog = egitim; Integrated Security = True;");

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Baglanti.Parameters.AddWithValue("@EGITIM_KODU", txt_egitimKodu.Text);
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_ADI", txt_egitimAdi.Text);
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_TUR_ID", int.Parse(txt_egitimTurId.Text));
            //    commandAdd1.Parameters.AddWithValue("@ZAMAN_ID", int.Parse(txt_zamanId.Text));
            //    commandAdd1.Parameters.AddWithValue("@EGITMEN_ID", int.Parse(txt_egitmenId.Text));
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_KONU", txt_egitimKonu.Text);
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_YER", txt_egitimYer.Text);
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_ACK", txt_egitimAck.Text);
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_SERTIFIKA", Convert.ToInt16(check_sertifika.Checked));
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_DURUM_TUR_ID", int.Parse(txt_egitimDurumTurId.Text));
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_DURUM_ACK", txt_egitimDurumAck.Text);
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_KATILIMCI_SAYI", int.Parse(txt_egitimKatilimciSayi.Text));
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_GECME_NOTU", decimal.Parse(txt_egitimGecmeNotu.Text));
            //    commandAdd1.Parameters.AddWithValue("@EGITIM_SINAV_ID", int.Parse(txt_egitimSinavId.Text));
            //    commandAdd1.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Veri tiplerini doğru giriniz.");
            //}

            //Baglanti.Close();



            //SqlCommand cmd = new SqlCommand("UPDATE_Katılımcı", Baglanti);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@TC", txt_tc.Text); // Örnek veritabanına ekleme şekli
            //cmd.Parameters.AddWithValue("@AD", txt_ad.Text);
            //cmd.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            //cmd.Parameters.AddWithValue("@DOGUM_IL_ID", int.Parse(txt_dogumIlId.Text));
            //cmd.Parameters.AddWithValue("@DOGUM_YERI", txt_dogumYeri.Text);
            //cmd.Parameters.AddWithValue("@DOGUM_TRH", datetime_DogumTarihiUpdate.Value);
            //cmd.Parameters.AddWithValue("@EMAIL", txt_email.Text);
            //cmd.Parameters.AddWithValue("@TELEFON", txt_telefon.Text);
            //cmd.Parameters.AddWithValue("@UNVAN_ID", int.Parse(txt_unvanId.Text));
            //cmd.Parameters.AddWithValue("@KIMLIK_ID", txt_kimlikId.Text);

            //Baglanti.Open();
            //cmd.ExecuteNonQuery();
            //Baglanti.Close();

        }

        private void egitim_Guncelleme_Load(object sender, EventArgs e)
        {
            

        }
    }
}
