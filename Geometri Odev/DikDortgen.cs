namespace Geometri_Odev
{
    internal class DikDortgen : IDortgen
    {
        public double UzunKenar { get; set; }
        public double KisaKenar { get; set; }
        public double CevreHesapla()
        {
            return (UzunKenar + KisaKenar) * 2;
        }
        public double AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }
    }
}