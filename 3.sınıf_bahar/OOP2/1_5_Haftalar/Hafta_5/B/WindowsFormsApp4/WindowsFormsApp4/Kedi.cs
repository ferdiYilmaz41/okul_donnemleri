using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Kedi
    {
        public Kedi (String _Adi,String _Cinsi, String _Yasi,String _Resim)
        {
            Adi = _Adi;
            Cinsi = _Cinsi;
            Yasi = _Yasi;
            Resim = _Resim;
        }
        public string Adi { get; set; }
        public string Cinsi { get; set; }
        public string Yasi { get; set; }
        public string Resim { get; set; }
    }
}
