using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Ogrenci
    {
        private string ogr_ad;

        public void SetName (String Name)
        {
            ogr_ad = Name;
        }

        public string GetName ()
        {
            return ogr_ad;
        }
    }
}
