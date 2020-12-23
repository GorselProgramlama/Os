using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class Personel:Kisi
    {
        public int personel_ID { get => personel_ID; set => personel_ID = value; }
        public int departman_ID { get => departman_ID; set => departman_ID = value; }
        public int kisi_ID { get => kisi_ID; set => kisi_ID = value; }

        public Personel()
        {

        }

       

        public Personel(string ad, string soyad, int tc, string cinsiyet,
            int telefon_No, string mail, string sifre, DateTime dogum_Tarihi,
            int personel_ID, int departman_ID) 
            : base( ad,  soyad,  tc,  cinsiyet,
             telefon_No, mail,  sifre, dogum_Tarihi)
        {
           this.personel_ID = personel_ID;
            this.departman_ID = departman_ID;
        }


    }
}
