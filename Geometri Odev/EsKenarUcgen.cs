using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Odev
{
    class EsKenarUcgen : IUcgen
    {
        
        public double Taban { get; set; }
        

        public double CevreHesapla()
        {
            return Taban * 3;
        }
        public double AlanHesapla()
        {
            return (Taban * Taban) * Math.Sqrt(3) / 4;
        }
    }
}
