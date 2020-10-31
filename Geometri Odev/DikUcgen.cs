using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Odev
{
    class DikUcgen : IUcgen
    {
        public double Yukseklik { get; set; }

        public double Taban { get; set; }

        public double CevreHesapla()
        {
            double Hipotenus = Math.Sqrt(Math.Pow(Taban, 2) + Math.Pow(Yukseklik, 2));
            return Hipotenus + Yukseklik + Taban;
        }
        public double AlanHesapla()
        {
            return (Taban * Yukseklik) / 2;
        }
        
    }
}
