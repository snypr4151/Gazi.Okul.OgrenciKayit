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
using DAL;
using OkulApp.BLL;
using OkulApp.MODEL;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmOgrtSilme : Form
    {
        public frmOgrtSilme()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtSil.Text);

                var hlp = new Helper();
          
                bool silme = hlp.ExecuteNonQuery("DELETE FROM tblOgretmenler WHERE OgretmenId = @ID", new SqlParameter[] {new SqlParameter("@ID", Id)}) > 0;

                if (silme)
                {
                    MessageBox.Show($"'{Id}' Id'ye sahip kaydı başarıyla silindi. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
