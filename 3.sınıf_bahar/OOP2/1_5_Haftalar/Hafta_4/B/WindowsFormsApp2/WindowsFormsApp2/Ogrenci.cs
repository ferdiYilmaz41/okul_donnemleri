using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Ogrenci
    {

        public Ogrenci (string OgrAd,string OgrSoyad, int OgrYas)
        {
            ogrAd = OgrAd;
            ogrSoyad = OgrSoyad;
            ogrYas = OgrYas;
        }

        private string ogrAd;

        public string Ograd
        {
            get { return ogrAd; }
            set { ogrAd = value; }
        }

        private string ogrSoyad;

        public string OgrSoyad
        {
            get { return ogrSoyad; }
            set { ogrSoyad = value; }
        }

        private int ogrYas;

        public int OgrYas
        {
            get { return ogrYas; }
            set { ogrYas = value; }
        }



    }
}
