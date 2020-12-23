using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class PersonelDB
    {

        public int PersonelEkle(Personel personel)
        {
            try
            {
                if (PersonelExists(personel.personel_ID))
                {
                    throw new Exception("Course with same name exists");
                }

                string query = $"INSERT INTO Personel(personel_ID,departman_ID,kisi_ID)VALUES('{personel.personel_ID}',{personel.departman_ID},{personel.kisi_ID})";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private bool PersonelExists(int personel_ID)
        {
            try
            {
                List<Personel> list = new List<Personel>();
                string query = $"select * from Personel where Personel_ID='{personel_ID}'";
                var dt = DbHelper.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }
        public int PersonelUpdate(Personel personel)
        {
            try
            {
                string query = $"UPDATE Personel SET Departma_ID='{personel.departman_ID}' WHERE Personel_ID={personel.personel_ID}";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int PersonelDelete(int personel_ID)
        {
            try
            {
                string query = $"Delete from Personel where personel_ID='{personel_ID}'";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Personel> GetPersonel()
        {
            try
            {
                List<Personel> list = new List<Personel>();
                string query = $"SELECT a.Personel_ID,a.Departman_ID,b.Ad,b.Soyad from personel a,kisi b where a.Kisi_ID=b.Kisi_ID ";
                var dt = DbHelper.ExecuteQuery(query);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Personel personel = new Personel();
                    personel.personel_ID = int.Parse(dt.Rows[i]["Personel_ID"].ToString());
                    personel.ad = dt.Rows[i]["Ad"].ToString();
                    personel.soyad = dt.Rows[i]["Soyad"].ToString();

                    list.Add(personel);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }
    }
}
