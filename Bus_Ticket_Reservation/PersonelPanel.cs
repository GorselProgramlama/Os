using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Ticket_Reservation;
using Bus_Ticket_Reservation.Model;

namespace Bus_Ticket_Reservation
{
    public partial class PersonelPanel : Form
    {
        public PersonelPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.personel_ID = 1234;

            PersonelDB personeldb = new PersonelDB();
            personeldb.PersonelEkle(personel);


           
        }
    }
}
