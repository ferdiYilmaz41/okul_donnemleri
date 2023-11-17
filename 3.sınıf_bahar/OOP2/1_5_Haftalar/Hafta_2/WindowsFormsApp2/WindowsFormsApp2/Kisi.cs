using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Kisi
    {
        public Kisi (int Yas,int Boy)
        {
            kisiBoy = Boy;
            KisiYas = Yas;
        }
        public int KisiYas { get; set; }

        private int kisiBoy;

        public int KisiBoy
        {
            get { return kisiBoy; }
            set {   if (value <= 10)
                        { kisiBoy = 0; }
                    else
                        { kisiBoy = value; }
                }
        }

    }
}
