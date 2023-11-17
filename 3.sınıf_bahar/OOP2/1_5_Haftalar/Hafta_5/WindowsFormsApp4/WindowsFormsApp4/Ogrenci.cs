using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Ogrenci
    {
        public Ogrenci(int myId,string No,String Ad,String Soyad,String Resim)
        {
            Id = myId;
            Ogr_No = No;
            Ogr_Ad = Ad;
            Ogr_Soyad = Soyad;
            Ogr_Resim = Resim;
        }
        public int Id { get; set; }
        public string Ogr_No{ get; set; }
        public string Ogr_Ad { get; set; }
        public string Ogr_Soyad { get; set; }
        public string Ogr_Resim { get; set; }
    }
}
