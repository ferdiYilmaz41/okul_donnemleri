using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Araba
    {
        public int ModelYili { get; set; }
        public string Marka { get; set; }

        public Araba(int _ModelYili,string _Marka,int _KmMenzil)
        {
            ModelYili = _ModelYili;
            Marka = _Marka;
            kmMenzil = _KmMenzil;
        }


        private int kmMenzil;

        public int KmMenzil
        {
            get { return kmMenzil; }
            set {
                   if (kmMenzil<=0)
                        { kmMenzil = -1; }
                    else
                        { kmMenzil = value;}
                 }
        }


    }
}
