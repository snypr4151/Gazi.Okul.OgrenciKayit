﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.OkulAppSube2BLG
{
    public partial class OkulAnaSayfa : Form
    {
        Form frmOgrKayit = new frmOgrKayit();
        Form frmOgrtKayit = new frmOgrtKayit();
        public OkulAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frmOgrKayit.Show();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            frmOgrtKayit.Show();
        }

        private void OkulAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
