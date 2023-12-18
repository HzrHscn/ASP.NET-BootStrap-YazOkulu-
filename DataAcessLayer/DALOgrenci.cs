using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayerFramework;

namespace DataAcessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrencı (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSıfre) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();
            
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TblOgrencı",Baglanti.bgl);
            if(komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = (dr["OGRAD"].ToString());
                ent.Soyad = (dr["OGRSOYAD"].ToString());
                ent.Numara= (dr["OGRNUMARA"].ToString());
                ent.Fotograf = (dr["OGRFOTO"].ToString());
                ent.Sifre= (dr["OGRSIFRE"].ToString());
                ent.Bakiye= Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBLOGRENCI where OGRID=@p1",Baglanti.bgl);
            if(komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;

        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from TblOgrencı where OGRID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = (dr["OGRAD"].ToString());
                ent.Soyad = (dr["OGRSOYAD"].ToString());
                ent.Numara = (dr["OGRNUMARA"].ToString());
                ent.Fotograf = (dr["OGRFOTO"].ToString());
                ent.Sifre = (dr["OGRSIFRE"].ToString());
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update TBLOGRENCI set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5 where OGRID=@P6",Baglanti.bgl);
            
            if(komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }

            komut5.Parameters.AddWithValue("@P1", deger.Ad);
            komut5.Parameters.AddWithValue("@P2", deger.Soyad);
            komut5.Parameters.AddWithValue("@P3", deger.Numara);
            komut5.Parameters.AddWithValue("@P4", deger.Fotograf);
            komut5.Parameters.AddWithValue("@P5", deger.Sifre);
            komut5.Parameters.AddWithValue("@P6", deger.Id);
            return komut5.ExecuteNonQuery() > 0;

        }
    }
}
