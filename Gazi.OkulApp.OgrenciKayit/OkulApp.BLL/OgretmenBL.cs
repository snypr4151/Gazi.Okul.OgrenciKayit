using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DAL;
using OkulApp.MODEL;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            try
            {
                if (ogrt.TcNo.Length != 11)
                {
                    throw new Exception("TC Kimlik Numarası 11 karakter olmalıdır!");
                }

                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogrt.Ad),
                                  new SqlParameter("@Soyad",ogrt.Soyad),
                                  new SqlParameter("@TcNo",ogrt.TcNo)
                            };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("Insert into tblOgretmenler (Ad,Soyad,TcNo) values (@Ad,@Soyad,@TcNo)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool OgretmenSilme(int Id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id", Id) };
                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("DELETE from tblOgretmenler where OgretmenId=@Id", p) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğretmen silme sırasında veritabanı hatası oluştu: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğretmen silme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        public Ogretmen OgretmenBul(string TcNo)
        {
            try
            {
                var hlp = Helper.SDP;
                SqlParameter[] p = { new SqlParameter("@TcNo", TcNo) };
                var dr = hlp.ExecuteReader("SELECT OgretmenId,Ad,Soyad,TcNo FROM tblOgretmenler WHERE TcNo=@TcNo", p);
                Ogretmen ogrt = null;
                if (dr.Read())
                {
                    ogrt = new Ogretmen();
                    ogrt.Ad = dr["Ad"].ToString();
                    ogrt.Soyad = dr["Soyad"].ToString();
                    ogrt.TcNo = dr["TcNo"].ToString();
                    ogrt.OgretmenId = Convert.ToInt32(dr["OgretmenId"]);
                }
                dr.Close();
                return ogrt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğretmen bulma sırasında veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğretmen bulma işlemi sırasında bir hata oluştu: " + ex.Message);
            }

        }

        public bool OgretmenGuncelle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", ogrt.Ad),
                new SqlParameter("@Soyad", ogrt.Soyad),
                new SqlParameter("@TcNo", ogrt.TcNo),
                new SqlParameter("@OgretmenId", ogrt.OgretmenId) };
                var hlp = Helper.SDP;

                return hlp.ExecuteNonQuery("Update tblOgretmenler set Ad=@Ad,Soyad=@Soyad,TcNo=@TcNo WHERE OgretmenId=@OgretmenId", p) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğretmen güncelleme sırasında veritabanı hatası oluştu: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğretmen güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }
    }
}
