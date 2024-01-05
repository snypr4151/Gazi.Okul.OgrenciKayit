﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class frmOgrBul : Form
    {
        frmOgrKayit frm;
        public frmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
            if (ogr!=null)
            {
                frm.txtAd.Text = ogr.Ad;
                frm.txtSoyad.Text = ogr.Soyad;
                frm.txtNumara.Text = ogr.Numara;
                frm.Ogrenciid = ogr.Ogrenciid;


                frm.btnSil.Enabled = true;
                frm.btnGuncelle.Enabled = true;  //Öğrenci bulundugunda sil ve güncelle butonlarını aktif hale getirir.

                this.Close();  //Eger ögrenci bulunursa Bu formu kapatır

            }
            else
            {
                MessageBox.Show("Öğrenci Bulunamadı!!");
            }

        }
    }
}
