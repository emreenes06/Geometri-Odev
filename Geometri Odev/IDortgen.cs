using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Odev
{
    interface IDortgen
    {
         double UzunKenar { get; set; }
        
         double AlanHesapla();

         double CevreHesapla();
        
    }
}
