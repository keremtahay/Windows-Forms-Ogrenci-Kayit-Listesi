using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci.CRUD
{
    public class Ogreci_CRUD
    {

        //Öğrecileri Listele
        public List<Ogrenci>   GetOgrenciListe()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();

            using (SqlConnection con = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM OgrenciKayit", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    ogrencis.Add(
                        new Ogrenci
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Ad = dr["Ad"].ToString(),
                            Soyad = dr["Soyad"].ToString(),
                            Numara = Convert.ToInt32(dr["Numara"]),
                            DogumTarihi = Convert.ToDateTime( dr["DogumTarihi"])
                        }
                        ); 
                }

            }

            return ogrencis;
        }

        public DataTable GetOgrenciListe2()
        {
            DataTable ogrenciTable = new DataTable();

            using (SqlConnection con = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM OgrenciKayit", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ogrenciTable);
            }

            return ogrenciTable;
        }

        //Tek Öğreci Liste
        public Ogrenci GetOgrenci(int ID)
        {
            Ogrenci ogrenci = new Ogrenci();

            using (SqlConnection con = Baglanti.GetConnection())
            {
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Ogrenci WHERE ID="+ ID.ToString()+"", con);
                SqlCommand cmd = new SqlCommand("SELECT * FROM OgrenciKayit WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ogrenci.Id = Convert.ToInt32(dr["ID"]);
                    ogrenci.Ad = dr["Ad"].ToString();
                    ogrenci.Soyad = dr["Soyad"].ToString();
                    ogrenci.Numara = Convert.ToInt32(dr["Numara"]);
                    ogrenci.DogumTarihi = Convert.ToDateTime(dr["DogumTarihi"]);
                }
            }

            return ogrenci;
        }
        //Öğrenci Ekle
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            using (SqlConnection con = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO OgrenciKayit(Ad,Soyad,Numara,DogumTarihi) VALUES(@ad,@soyad,@numara,@DogumTarihi)", con);
                cmd.Parameters.AddWithValue("@ad", ogrenci.Ad);
                cmd.Parameters.AddWithValue("@soyad", ogrenci.Soyad);
                cmd.Parameters.AddWithValue("@numara", ogrenci.Numara);
                cmd.Parameters.AddWithValue("@DogumTarihi", ogrenci.DogumTarihi);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Öğrenci güncelle
        public void OgrenciGuncelle(Ogrenci ogrenci)
        {
            using (SqlConnection con = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE OgrenciKayit SET Numara = @Numara, Soyad = @Soyad, Ad = @Ad, DogumTarihi = @DogumTarihi  WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@Ad", ogrenci.Ad);
                cmd.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
                cmd.Parameters.AddWithValue("@Numara", ogrenci.Numara);
                cmd.Parameters.AddWithValue("@ID", ogrenci.Id);
                cmd.Parameters.AddWithValue("@DogumTarihi", ogrenci.DogumTarihi);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Öğrenci Sil
        public void OgrenciSil(int ID)
        {
            using (SqlConnection con = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE OgrenciKayit WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", ID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
