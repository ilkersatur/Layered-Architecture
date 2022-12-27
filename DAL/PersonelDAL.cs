using System.Configuration;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    // Model dll kullanmak için Add > Project Reference'den yapılır
    // Katmanlı mimari sayesinde proje daha yönetilebilir olur.
    public class PersonelDAL
    {
        SqlConnection conn;
        public PersonelDAL()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
            
        }
        public List<Personel> TumPersoneller()
        {
            //ADO.Net Bağlantılı Yöntem
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Personel", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Personel> personeller = new List<Personel>();
            while (dr.Read())
            {
                Personel personel = new Personel();
                personel.PerID = dr.GetInt32(0);
                personel.Ad = dr[1].ToString();
                personel.Soyad = dr[2].ToString();
                personel.BolumID = dr.GetInt32(3);
                personeller.Add(personel);
            }
            conn.Close();
            return personeller;
        }
        public void PersonelEkle(Personel personel)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Personel Values(@Ad, @Soyad, @BolumID)", conn);

            cmd.Parameters.AddWithValue("@Ad",personel.Ad);
            cmd.Parameters.AddWithValue("@Soyad",personel.Soyad);
            cmd.Parameters.AddWithValue("@BolumID",personel.BolumID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
