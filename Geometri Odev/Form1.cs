using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometri_Odev
{
    public partial class GeometriForm : Form
    {
        public GeometriForm()
        {
            InitializeComponent();
        }

        private void GeometriForm_Load(object sender, EventArgs e)
        {
            cbSekil.Items.Add("-- Seçiniz --");
            cbSekil.Items.Add("DikDörtgen");
            cbSekil.Items.Add("Kare");
            cbSekil.Items.Add("EşKenarÜçgen");
            cbSekil.Items.Add("DikÜçgen");
            cbSekil.Items.Add("Daire");
            cbSekil.SelectedIndex = 0;
            pDikDortgen.Visible = false;
            pKare.Visible = false;
            pEsKenarUcgen.Visible = false;
            pDikUcgen.Visible = false;
            pDaire.Visible = false;
            Point point = new Point();
            point.X = 14;
            point.Y = 42;
            pKare.Location = point;
            pEsKenarUcgen.Location = point;
            pDikUcgen.Location = point;
            pDaire.Location = point;
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            if (cbSekil.SelectedIndex != 0 && cbHesapla.SelectedIndex != 0)
            {
                if (cbSekil.SelectedIndex == 1) // DikDörtgen
                {
                    
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        DikDortgen dikDortgen = new DikDortgen();
                        dikDortgen.UzunKenar = Convert.ToDouble(tbUzunKenar.Text, new CultureInfo("tr"));
                        dikDortgen.KisaKenar = Convert.ToDouble(tbKisaKenar.Text, new CultureInfo("tr"));
                        sonuc = dikDortgen.CevreHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }
                    else   // Alan
                    {
                        DikDortgen dikDortgen = new DikDortgen();
                        dikDortgen.UzunKenar = Convert.ToDouble(tbUzunKenar.Text, new CultureInfo("tr"));
                        dikDortgen.KisaKenar = Convert.ToDouble(tbKisaKenar.Text, new CultureInfo("tr"));
                        sonuc = dikDortgen.AlanHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }
                }


                if (cbSekil.SelectedIndex == 2) // Kare
                {
                    Kare kare = new Kare();
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {

                        kare.UzunKenar = Convert.ToDouble(tbKare.Text, new CultureInfo("tr"));

                        sonuc = kare.CevreHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }
                    else   // Alan
                    {
                        kare.UzunKenar = Convert.ToDouble(tbKare.Text, new CultureInfo("tr"));

                        sonuc = kare.AlanHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }

                }


                if (cbSekil.SelectedIndex == 3) // EşKenar Üçgen
                {
                    EsKenarUcgen esKenarUcgen = new EsKenarUcgen();
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {

                        esKenarUcgen.Taban = Convert.ToDouble(tbEsKenarUcgen.Text, new CultureInfo("tr"));

                        sonuc = esKenarUcgen.CevreHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }
                    else   // Alan
                    {
                        esKenarUcgen.Taban = Convert.ToDouble(tbEsKenarUcgen.Text, new CultureInfo("tr"));

                        sonuc = esKenarUcgen.AlanHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }

                }



                if (cbSekil.SelectedIndex == 4) // DikÜçgen
                {
                    DikUcgen dikUcgen = new DikUcgen();
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {

                        dikUcgen.Taban = Convert.ToDouble(tbDikUcgenTaban.Text, new CultureInfo("tr"));
                        dikUcgen.Yukseklik = Convert.ToDouble(tbDikUcgenYukseklik.Text, new CultureInfo("tr"));

                        sonuc = dikUcgen.CevreHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }
                    else   // Alan
                    {
                        dikUcgen.Taban = Convert.ToDouble(tbDikUcgenTaban.Text, new CultureInfo("tr"));
                        dikUcgen.Yukseklik = Convert.ToDouble(tbDikUcgenYukseklik.Text, new CultureInfo("tr"));
                        sonuc = dikUcgen.AlanHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }

                }

                if (cbSekil.SelectedIndex == 5) // Daire
                {
                    Daire daire = new Daire();
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {

                        daire.YariCap = Convert.ToDouble(tbYariCap.Text, new CultureInfo("tr"));
                        

                        sonuc = daire.CevreHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }
                    else   // Alan
                    {
                        daire.YariCap = Convert.ToDouble(tbYariCap.Text, new CultureInfo("tr"));
                        
                        sonuc = daire.AlanHesapla();
                        lbSonuc.Items.Add(sonuc);
                    }

                }
            }

        }

        private void cbSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            pDikDortgen.Visible = false;
            pKare.Visible = false;
            pEsKenarUcgen.Visible = false;
            pDikUcgen.Visible = false;
            pDaire.Visible = false;

            if (cbSekil.SelectedIndex == 1)
            {
                pDikDortgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 2)
            {
                pKare.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 3)
            {
                pEsKenarUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 4)
            {
                pDikUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 5)
            {
                pDaire.Visible = true;
            }
        }
    }
}
