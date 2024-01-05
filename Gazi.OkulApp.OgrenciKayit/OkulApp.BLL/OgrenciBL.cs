using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {

                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogr.Ad),
                                  new SqlParameter("@Soyad",ogr.Soyad),
                                  new SqlParameter("@Numara",ogr.Numara)
                            };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğrenci eklerken veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğrenci ekleme sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    //cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }

        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                var hlp = Helper.SDP;
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                var dr = hlp.ExecuteReader("SELECT OgrenciId,Ad,Soyad,Numara FROM tblOgrenciler WHERE Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                    ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                    // MessageBox.Show($"Ad:{ogr.Ad} Soyad:{ogr.Soyad}");
                }
                dr.Close();
                return ogr;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğrenci bulma sırasında veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğrenci bulma işlemi sırasında bir hata oluştu: " + ex.Message);
            }

        }

        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id", id) };
                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("DELETE from tblOgrenciler where OgrenciId=@Id", p) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğrenci silme sırasında veritabanı hatası oluştu: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğrenci silme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", ogr.Ad),
                new SqlParameter("@Soyad", ogr.Soyad),
                new SqlParameter("@Numara", ogr.Numara),
                new SqlParameter("@OgrenciId", ogr.Ogrenciid) };
                var hlp = Helper.SDP;

                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara WHERE OgrenciId=@OgrenciId", p) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Öğrenci güncelleme sırasında veritabanı hatası oluştu: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğrenci güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }


    }

}

