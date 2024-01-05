using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;
using OkulApp.MODEL;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmOgrtBul : Form
    {
        frmOgrtKayit frm;
        public frmOgrtBul(frmOgrtKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OgretmenBL obl = new OgretmenBL();
            Ogretmen ogr = obl.OgretmenBul(txtTcNo.Text.Trim());
            if (ogr != null)
            {
                frm.tbOgrtAd.Text = ogr.Ad;
                frm.tbOgrtSoyad.Text = ogr.Soyad;
                frm.tbOgrtTcNo.Text = ogr.TcNo;
                frm.Ogretmenid = ogr.OgretmenId;


                frm.btnSil.Enabled = true;
                frm.btnGuncelle.Enabled = true; 
                this.Close(); 

            }
            else
            {
                MessageBox.Show("Öğretmen Bulunamadı!!");
            }
        }
    }
}
