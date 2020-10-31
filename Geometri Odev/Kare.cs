using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Odev
{
    class Kare : IDortgen
    {
        public double UzunKenar { get; set; }
        

        public double CevreHesapla()
        {
            return UzunKenar *4  ;
        }
        public double AlanHesapla ()
        {
            return UzunKenar * UzunKenar;
        }
    }
}
