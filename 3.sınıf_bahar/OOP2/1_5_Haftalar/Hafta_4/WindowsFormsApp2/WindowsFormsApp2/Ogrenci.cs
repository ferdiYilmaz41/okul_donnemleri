using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Ogrenci
    {

        public Ogrenci (String OgrAd, String OgrSoyad, int OgrYas)
        {
            ogrAd = OgrAd;
            ogrSoyAd = OgrSoyad;
            ogrYas = OgrYas;
        }
        private string ogrAd;

        public string OgrAd
        {
            get { return ogrAd; }
            set { ogrAd = value; }
        }

        private string ogrSoyAd;

        public string OgrSoyAd
        {
            get { return ogrSoyAd; }
            set { ogrSoyAd = value; }
        }

        private int ogrYas;

        public int OgrYas
        {
            get { return ogrYas; }
            set { ogrYas = value; }
        }




    }
}
