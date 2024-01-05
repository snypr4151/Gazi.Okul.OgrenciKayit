using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;
using OkulApp.MODEL;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmOgrtKayit : Form
    {
        public int Ogretmenid { get; set; }
        public frmOgrtKayit()
        {
            InitializeComponent();
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                bool sonuc = obl.OgretmenEkle(new Ogretmen { Ad = tbOgrtAd.Text.Trim(), Soyad = tbOgrtSoyad.Text.Trim(), TcNo = tbOgrtTcNo.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                tbOgrtAd.Clear();
                tbOgrtSoyad.Clear();
                tbOgrtTcNo.Clear();

                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmOgrtBul(this);
                frm.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenGuncelle(new Ogretmen { Ad = tbOgrtAd.Text.Trim(), Soyad = tbOgrtSoyad.Text.Trim(), TcNo = tbOgrtTcNo.Text.Trim(), OgretmenId = Ogretmenid }) ? "Güncelleme Başarılı" : "İşlem Başarısız!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı güncelleme hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretmen güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenSilme(Ogretmenid) ? "Silme Başarılı" : "İşlem Başarısız!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı silme hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretmen silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
