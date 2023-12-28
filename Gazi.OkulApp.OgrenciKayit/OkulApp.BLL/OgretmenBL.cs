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

                var hlp = new Helper();
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
    }
}
