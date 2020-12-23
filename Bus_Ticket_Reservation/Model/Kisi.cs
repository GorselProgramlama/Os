using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
   class Kisi
    {
       public string ad;
       public string soyad;
       public int tc;
       public string cinsiyet;
       public int telefon_No;
       public string mail;
       public string sifre;
       public DateTime dogum_Tarihi;

        public Kisi()
        {
            int kisi_ID;
        }

        public Kisi(string ad, string soyad, int tc, string cinsiyet,
            int telefon_No,string mail, string sifre, DateTime dogum_Tarihi)
        {
            ad = ad;
            soyad = soyad;
            tc = tc;
            cinsiyet = cinsiyet;
            telefon_No = telefon_No;
            mail = mail;
            sifre = sifre;
            dogum_Tarihi = dogum_Tarihi;
        }

        public bool Giris(string mail, string sifre)
        {
            return true;
        }
    }
}
