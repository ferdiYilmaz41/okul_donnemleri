using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dort_Islem
{
    public class Islem
    {
        public int toplama(int a,int b)
        {
            return a + b;
        }

        public string toplama_ret_str (int a,int b)
        {
            // return "Sayi 1:" + a + " Sayi2:" + b + " Sonuç:" + (a + b);
            return  a + " + " + b + " = " + (a + b);

        }

        public int cikarma (int a,int b)
        {
            return a - b;
        }
    }
}
